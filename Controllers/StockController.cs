using Genesyst.Models;
using jaruernCore.localLib;
using jaruernCore.Models;
using jaruernCore.Models.dbs_jaruern_inv;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.EntityFrameworkCore;
using ServiceLib;
using System.Data.SqlClient;
using System.Globalization;
using System.Net;
using System.Text.Json;

namespace jaruernCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockController : BaseController
    {
        private readonly ILogger<WeatherForecastController> _logger;

        public StockController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpPost("NewStockInCard")]
        public async Task<ActionResult> NewStockInCard(mdlStockInCard StockInCard)
        {
            try
            {
                this.GetUser();
                using (var jivdb = new JaruernInvContext())
                {
                    var jrn_transaction = jivdb.Database.BeginTransaction();
                    try
                    {
                        DateTime? atDate = ServiceText.APIParamToDate(StockInCard.Atdate);
                        string CardNo = new serviceStock(StockInCard.Storeid).newCardNo(atDate.Value,StockInCard.Culture);
                        Guid CardId = Guid.NewGuid();   

                        foreach (var goods in StockInCard.StockInGoods)
                        {
                            jivdb.StkGoods.Add(new StkGood() { 
                                Active = true,
                                Cardid = CardId,
                                Cost = goods.Cost,
                                CreateDate = DateTime.Now,
                                Discount = goods.Discount,
                                Goodid = goods.Goodid,
                                Id = Guid.NewGuid(),
                                Memberprice = goods.Memberprice,
                                Remark = goods.Remark,
                                Saleprice = goods.Saleprice,
                                Tag = null,
                                Piece = goods.Piece,
                                Unitid = goods.UnitId
                            });

                            jivdb.SaveChanges();
                        }

                        jivdb.StkCards.Add(new StkCard()
                        {
                            Atdate = atDate.Value,
                            Cardno = CardNo,
                            CreateBy = this.UserId.Value,
                            CreateDate = DateTime.Now,
                            Id = CardId,
                            Remark = StockInCard.Remark,
                            Storeid = StockInCard.Storeid,
                            Stt = "A",
                            Tag = null,
                            UpdateBy = null,
                            UpdateDate = null
                        });

                        jivdb.SaveChanges();
                        jrn_transaction.Commit();

                        return Ok(new { id = 0,msg = CardNo }) ;
                    }
                    catch(Exception ex)
                    {
                        jrn_transaction.Rollback();
                        return Ok(new { id = 1, msg = ex.Message });
                    }
                }

                
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetStockLastPricesRefer")]
        public async Task<ActionResult> GetStockLastPricesRefer(Guid GoodsId,Guid? StoreId)
        {
            try
            {
                spSTKLastPrice result_data = new spSTKLastPrice();

                this.GetUser();
                using (var jivdb = new JaruernInvContext())
                {
                    if(StoreId.HasValue)
                    {
                        String spText = "EXECUTE spSTKLastPrice @p0,@p1 ";
                        var isRefer = jivdb.spSTKLastPrice.FromSqlRaw(spText, StoreId, GoodsId).ToList();

                        if (isRefer.Count > 0)
                        {
                            result_data.Id = isRefer.FirstOrDefault().Id;
                            result_data.SalePrice = isRefer.FirstOrDefault().SalePrice;
                            result_data.Discount = isRefer.FirstOrDefault().Discount;
                            result_data.MemberPrice = isRefer.FirstOrDefault().MemberPrice;
                            result_data.Cost = isRefer.FirstOrDefault().Cost;

                            return Ok(new { id = 0, data = result_data });
                        }
                    }
                    else
                    {
                        var isRefer = jivdb.StkGoods.Where(c => 
                                                            c.Goodid == GoodsId && c.Active == true)
                                                            .OrderByDescending(o => o.CreateDate)
                                                            .FirstOrDefault();
                        if (isRefer != null)
                        {
                            result_data.Id = isRefer.Id;
                            result_data.SalePrice = isRefer.Saleprice.Value;
                            result_data.Discount = isRefer.Discount;
                            result_data.MemberPrice = isRefer.Memberprice;
                            result_data.Cost = isRefer.Cost;

                            return Ok(new { id = 0, data = result_data });
                        }
                    }
                }

                return Ok(new { id = 0, data = result_data });
            }
            catch(Exception ex)
            {
                return BadRequest(new { id = 1, msg = ex.Message });
            }
        }

        [HttpGet("GetStockCards")]
        public async Task<ActionResult> GetStockCards(int load_index, Guid StoreId,string? atdate,string culture)
        {
            mdlGResultSet<mdlStockCard> res = new mdlGResultSet<mdlStockCard>();
            List<mdlStockCard> cards = new List<mdlStockCard>();

            try
            {
                this.GetUser();
                using (var jivdb = new JaruernInvContext())
                {
                    List<StkCard> cardsList = new List<StkCard>();
                    if (string.IsNullOrEmpty(atdate))
                    {
                        cardsList = jivdb.StkCards.Where(c =>
                                                        c.Storeid == StoreId && c.Stt != "X"
                                                        ).OrderByDescending(o => o.CreateDate).ToList();
                    }
                    else
                    {
                        DateTime? atDate = ServiceText.APIParamToDate(atdate);
                        cardsList = jivdb.StkCards.Where(c =>
                                                        c.Storeid == StoreId && c.Stt != "X"
                                                        && c.Atdate == atDate
                                                        ).OrderByDescending(o => o.CreateDate).ToList();
                    }

                    #region page split
                    int per_load = 50;
                    if (load_index == 0)
                        cardsList = cardsList.Take(per_load).ToList();
                    else
                    {
                        int skip = load_index * per_load;
                        int take = skip + load_index;
                        cardsList = cardsList.Skip(skip).Take(take).ToList();
                    }

                    #endregion

                    DateCulture set_culture = DateCulture.ctEng;
                    if (culture.ToLower() == "th")
                        set_culture = DateCulture.ctThai;

                    foreach (var card in cardsList)
                    {
                        string ownerName = new serviceJCore().UserName(card.CreateBy);

                        var goodss = jivdb.StkGoods.Where(c => c.Cardid == card.Id && c.Active == true).ToList();
                        int pie = goodss.Select(s => s.Piece).Sum() ?? 0;

                        cards.Add(new mdlStockCard() {
                            Atdate = card.Atdate.Date,
                            AtdateStr = ServiceDateTime.ToDateTimeString(card.Atdate,"d/M/yyyy", set_culture),
                            Cardno = card.Cardno,
                            Id = card.Id,
                            OwnerId = card.CreateBy,
                            Ownername = ownerName,
                            Remark = card.Remark,
                            CreateDate = card.CreateDate,
                            Goods = goodss.Count,
                            Piece = pie,
                        }) ;
                    }

                    res.Code = HttpStatusCode.OK.ToString();
                    res.Count = cards.Count;
                    res.Message = "SUCCESS";
                    res.Results = cards.ToList();
                }
            }
            catch (Exception ex)
            {
                res.Code = HttpStatusCode.NotFound.ToString();
                res.Message = ex.Message;
            }

            return Ok(res);
        }

        [HttpGet("GetStockGoods")]
        public async Task<ActionResult> GetStockGoods(int load_index, Guid StoreId, string? atdate, string culture)
        {
            mdlGResultSet<mdlStockGoodsList> res = new mdlGResultSet<mdlStockGoodsList>();
            List<mdlStockGoodsList> goods = new List<mdlStockGoodsList>();

            try
            {
                this.GetUser();
                using (var jivdb = new JaruernInvContext())
                {
                    List<ViewStkgood> goodsList = new List<ViewStkgood>();
                    if (string.IsNullOrEmpty(atdate))
                    {
                        goodsList = jivdb.ViewStkgoods.Where(c =>
                                                        c.Storeid == StoreId 
                                                        ).OrderByDescending(o => o.CreateDate).ToList();
                    }
                    else
                    {
                        DateTime? atDate = ServiceText.APIParamToDate(atdate);
                        goodsList = jivdb.ViewStkgoods.Where(c =>
                                                        c.Storeid == StoreId
                                                        && c.Atdate == atDate
                                                        ).OrderByDescending(o => o.CreateDate).ToList();
                    }

                    #region page split
                    int per_load = 50;
                    if (load_index == 0)
                        goodsList = goodsList.Take(per_load).ToList();
                    else
                    {
                        int skip = load_index * per_load;
                        int take = skip + load_index;
                        goodsList = goodsList.Skip(skip).Take(take).ToList();
                    }

                    #endregion

                    DateCulture set_culture = DateCulture.ctEng;
                    if (culture.ToLower() == "th")
                        set_culture = DateCulture.ctThai;

                    foreach (var gl in goodsList)
                    {
                        string unit = gl.Uniten;
                        if (set_culture == DateCulture.ctThai)
                            unit = gl.Unitth;

                        goods.Add(new mdlStockGoodsList() { 
                            Atdate = gl.Atdate,
                            AtdateStr = ServiceDateTime.ToDateTimeString(gl.Atdate, "d/M/yyyy", set_culture),
                            CardNo = gl.Cardno,
                            Cost = gl.Cost,
                            Discount = gl.Discount,
                            Id = gl.Id,
                            Member = gl.Memberprice,
                            Piece = gl.Piece.Value,
                            Price = gl.Saleprice.Value,
                            Remark = gl.Remark,
                            SkuCode = gl.Skucode,
                            SkuName = gl.Skuname,
                            Unitname = unit,
                            Barcode = gl.Skubarcode,
                            QRcode = gl.Skuqrcode,
                            Size = gl.Skusize,
                            CreateDate = ServiceDateTime.ToDateTimeString(gl.CreateDate, "d/M/yyyy HH:mm", set_culture),
                        });
                    }

                    res.Code = HttpStatusCode.OK.ToString();
                    res.Message = "SUCCESS";
                    res.Count = goods.Count;
                    res.Results = goods.ToList();
                }
            }
            catch (Exception ex)
            {
                res.Code = HttpStatusCode.NotFound.ToString();
                res.Message = ex.Message;
            }

            return Ok(res);
        }

        [HttpGet("GetStockCardsDetail")]
        public async Task<ActionResult> GetStockCardsDetail(Guid StoreId,String CardNo)
        {
            mdlGResultSet<ViewStkgood> res = new mdlGResultSet<ViewStkgood>();
            List<ViewStkgood> goodss = new List<ViewStkgood>();

            try
            {
                this.GetUser();
                using (var jivdb = new JaruernInvContext())
                {
                    goodss = jivdb.ViewStkgoods.Where(c => 
                                                c.Storeid == StoreId && 
                                                c.Cardno == CardNo)
                                                .OrderBy(o=>o.CreateDate).ToList();
                }

                res.Code = HttpStatusCode.OK.ToString();
                res.Message = "SUCCESS";
                res.Count = goodss.Count;
                res.Results = goodss.ToList();
            }
            catch(Exception ex) {
                res.Code = HttpStatusCode.NotFound.ToString();
                res.Message = ex.Message;
            }

            return Ok(res);
        }

        [HttpPost("DeleteStkInCards")]
        public async Task<ActionResult> DeleteStkInCards([FromBody] JsonElement jsonElement)
        {
            string CardId = jsonElement.GetProperty("CardId").ToString();
            try
            {
                this.GetUser();
                using (var jivdb = new JaruernInvContext())
                {
                    var stkCard = jivdb.StkCards.Where(c => c.Id == new Guid(CardId)).FirstOrDefault();
                    if (stkCard != null)
                    {
                        var jrn_transaction = jivdb.Database.BeginTransaction();
                        try
                        {
                            var stkGoodss = jivdb.StkGoods.Where(c => c.Cardid == new Guid(CardId)).ToList();
                            foreach(var stkGoods in stkGoodss)
                            {
                                var stk_g = jivdb.StkGoods.Where(c=>c.Id == stkGoods.Id).FirstOrDefault();
                                stk_g.UpdateDate = DateTime.Now;
                                stk_g.Active = false;
                                jivdb.SaveChanges();
                            }

                            stkCard.Stt = "X";
                            stkCard.UpdateDate = DateTime.Now;
                            stkCard.UpdateBy = this.UserId;
                            jivdb.SaveChanges();

                            jrn_transaction.Commit();

                            return Ok(new { id = 0, msg = "SUCCESS" });
                        }
                        catch (Exception ex)
                        {
                            jrn_transaction.Rollback();
                            return Ok(new { id = 1, msg = ex.Message });
                        }
                    }
                    else
                    {
                        return Ok(new { id = 2, msg = "Card not exist" });
                    }
                }
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpPost("DeleteStkInGoods")]
        public async Task<ActionResult> DeleteStkInGoods(Guid Id)
        {
            try
            {
                this.GetUser();
                using (var jivdb = new JaruernInvContext())
                {
                    var stkGoods = jivdb.StkGoods.Where(c => c.Id == Id).FirstOrDefault();
                    if(stkGoods!=null)
                    {
                        var jrn_transaction = jivdb.Database.BeginTransaction();
                        try
                        {
                            stkGoods.UpdateDate = DateTime.Now;
                            stkGoods.Active = false;
                            jivdb.SaveChanges();

                            jrn_transaction.Commit();

                            return Ok(new { id = 0, msg = "SUCCESS" });
                        }
                        catch (Exception ex)
                        {
                            jrn_transaction.Rollback();
                            return Ok(new { id = 1, msg = ex.Message });
                        }
                    }
                    else
                    {
                        return Ok(new { id = 2, msg = "Goods not exist" });
                    }
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpGet("GetStockBalance")]
        public async Task<ActionResult> GetStockBalance(string Atdate, Guid StoreId)
        {
            mdlGResultSet<mdlStockBalance> Res = new mdlGResultSet<mdlStockBalance>();
            List<mdlStockBalance> stkBal = new List<mdlStockBalance>();
            try
            {
                this.GetUser();
                using (var jivdb = new JaruernInvContext())
                {
                    DateTime atdate = ServiceText.APIParamToDate(Atdate).Value;

                    var goodss = jivdb.ViewStkgoods.GroupBy(g => new { g.Goodid, g.Skuname })
                                        .Select(s => new { s.Key.Goodid, s.Key.Skuname }).ToList();

                    string atdate_param = atdate.Year + "-" + atdate.Month + "-" + atdate.Day;

                    String spText = "EXECUTE spStockTBF @p0,@p1 ";
                    var goodsTbfs = jivdb.spStockBal.FromSqlRaw(spText, atdate_param, StoreId).ToList();

                    spText = "EXECUTE spSaleTBF @p0,@p1 ";
                    var goodsSaleTbfs = jivdb.spSale.FromSqlRaw(spText, atdate_param, StoreId).ToList();

                    spText = "EXECUTE spStockInGoods @p0,@p1,@p2 ";
                    DateTime atdate2 = atdate.AddDays(1);
                    string atdate_param2 = atdate2.Year + "-" + atdate2.Month + "-" + atdate2.Day;
                    var goodsIn = jivdb.spStockBal.FromSqlRaw(spText, atdate_param, atdate_param2, StoreId).ToList();

                    spText = "EXECUTE spSaleGoods @p0,@p1,@p2 ";
                    var goodsOut = jivdb.spSale.FromSqlRaw(spText, atdate_param, atdate_param2, StoreId).ToList();


                    foreach (var go in goodss)
                    {
                        int tbf_pie = 0;
                        decimal tbf_cost = 0;

                        int tbf_sale = 0;
                        decimal tbf_cash = 0;

                        int stk_in = 0;
                        decimal stk_in_cost = 0;

                        int saleout = 0;
                        decimal salecash = 0;

                        #region
                        var tbf = goodsTbfs.Where(c=>c.GoodsId == go.Goodid).FirstOrDefault();
                        if(tbf!=null)
                        {
                            tbf_pie = tbf.Piece;
                            tbf_cost = tbf.Cost;
                        }

                        var tbfsale = goodsSaleTbfs.Where(c => c.GoodsId == go.Goodid).FirstOrDefault();
                        if(tbfsale!=null)
                        {
                            tbf_sale = tbfsale.Piece;
                            tbf_cash = tbfsale.Cash;
                        }

                        var stkin = goodsIn.Where(c => c.GoodsId == go.Goodid).FirstOrDefault();
                        if(stkin!=null)
                        {
                            stk_in = stkin.Piece;
                            stk_in_cost = stkin.Cost;
                        }

                        var stkOut = goodsOut.Where(c => c.GoodsId == go.Goodid).FirstOrDefault();
                        if(stkOut!=null)
                        {
                            saleout = stkOut.Piece;
                            salecash = stkOut.Cash;
                        }

                        #endregion

                        stkBal.Add(new mdlStockBalance() { 
                            GoodsId = go.Goodid,
                            GoodsName = go.Skuname,
                            TBFPiece = tbf_pie - tbf_sale,
                            TBFcost = tbf_cost - tbf_cash ,
                            InPiece = stk_in,
                            Incost = stk_in_cost,
                            OutPiece = saleout,
                            Outcost = salecash,
                            TCFPiece = ((tbf_pie - tbf_sale) + stk_in) - saleout,
                            TCFcost = ((tbf_cost - tbf_cash) + stk_in_cost) - salecash,
                        });
                    }

                    Res.Code = HttpStatusCode.OK.ToString();
                    Res.Message = "SUCCESS";
                    Res.Results = stkBal.OrderBy(o=>o.GoodsName).ToList();
                    Res.Count = stkBal.Count;
                }
            }
            catch(Exception ex) {
                Res.Code = HttpStatusCode.NotFound.ToString();
                Res.Message = ex.Message;
            }

            return Ok(Res);
        }

    }
}
