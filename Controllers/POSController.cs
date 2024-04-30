using Azure;
using Genesyst.Models;
using jaruernCore.localLib;
using jaruernCore.Models;
using jaruernCore.Models.dbs_jaruern_inv;
using jaruernCore.Models.dbs_jmmdatacenter;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using ServiceLib;
using System.Globalization;
using System.Net;
using ReceiptH = jaruernCore.Models.dbs_jaruern_inv.ReceiptH;

namespace jaruernCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class POSController : BaseController
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IWebHostEnvironment _hostingEnvironment;

        public POSController(ILogger<WeatherForecastController> logger, IWebHostEnvironment hostingEnvironment)
        {
            _logger = logger;
            _hostingEnvironment = hostingEnvironment;
        }

        [HttpGet("GetSaleProduct")]
        public async Task<ActionResult> GetSaleProduct(Guid StoreId)
        {
            mdlGResultSet<mdlSaleProduct> res = new mdlGResultSet<mdlSaleProduct>();
            try
            {
                List<mdlSaleProduct> result_data = new List<mdlSaleProduct>();

                this.GetUser();
                using (var jivdb = new JaruernInvContext())
                {
                    String spText = "EXECUTE spGoodsForSale @p0 ";
                    var sale_data = jivdb.spGoodsForSale.FromSqlRaw(spText, StoreId).ToList();

                    List<ViewStkgood> stkGoods = new List<ViewStkgood>();
                    if(sale_data.Count > 0)
                    {
                        List<Guid> goodsIds = sale_data.Select(x => x.GoodsId).ToList();
                        stkGoods = jivdb.ViewStkgoods.Where(c=>
                                                            c.Storeid == StoreId && 
                                                            goodsIds.ToArray().Contains(c.Goodid)).ToList();
                    }

                    foreach (var item in sale_data.Where(c=>c.Sale_Pie < c.Stk_Pie))
                    {
                        var isGoods = stkGoods.Where(c => 
                                                        c.Goodid == item.GoodsId)
                                                        .OrderByDescending(o => o.Atdate).FirstOrDefault();
                        if (isGoods != null)
                        {
                            result_data.Add(new mdlSaleProduct
                            {
                                GoodsId = item.GoodsId,
                                Id = item.Id,
                                Sale_Pie = item.Sale_Pie,
                                SkuBarcode = item.SkuBarcode,
                                SkuQRcode = item.SkuQRcode,
                                Stk_Pie = item.Stk_Pie,
                                Amt_Pie = item.Stk_Pie - item.Sale_Pie,
                                Skuname = item.Skuname,
                                Skucode = item.Skucode,
                                Price = isGoods.Saleprice.Value,
                                Discount = isGoods.Discount ?? 0,
                                Member = isGoods.Memberprice ?? 0,
                            });
                        }
                    }

                    res.Code = HttpStatusCode.OK.ToString();
                    res.Message = "SUCCESS";
                    res.Count = result_data.Count;
                    res.Results = result_data;
                }
            }
            catch(Exception ex)
            {
                res.Code = HttpStatusCode.NotFound.ToString();
                res.Message = ex.Message;
            }

            return Ok(res);
        }

        [HttpGet("GetSaleProductOrder")]
        public async Task<ActionResult> GetSaleProductOrder(Guid StoreId)
        {
            mdlGResultSet<mdlSaleProductOrder> res = new mdlGResultSet<mdlSaleProductOrder>();

            try
            {
                List<mdlSaleProductOrder> result_data = new List<mdlSaleProductOrder>();

                this.GetUser();
                using (var jivdb = new JaruernInvContext())
                {
                    String spText = "EXECUTE spGoodsForSale @p0 ";
                    var sale_data = jivdb.spGoodsForSale.FromSqlRaw(spText, StoreId).ToList();

                    List<ViewStkgood> stkGoods = new List<ViewStkgood>();
                    if (sale_data.Count > 0)
                    {
                        List<Guid> goodsIds = sale_data.Select(x => x.GoodsId).ToList();
                        stkGoods = jivdb.ViewStkgoods.Where(c =>
                                                            c.Storeid == StoreId &&
                                                            goodsIds.ToArray().Contains(c.Goodid)).ToList();
                    }

                    foreach (var item in sale_data.Where(c => c.Sale_Pie < c.Stk_Pie))
                    {
                        var isGoods = stkGoods.Where(c =>
                                                        c.Goodid == item.GoodsId)
                                                        .OrderByDescending(o => o.Atdate).FirstOrDefault();
                        if (isGoods != null)
                        {
                            var goods = jivdb.Goods.Where(c => c.Id == item.GoodsId).FirstOrDefault();

                            result_data.Add(new mdlSaleProductOrder
                            {
                                GoodsId = item.GoodsId,
                                Id = item.Id,
                                Sale_Pie = item.Sale_Pie,
                                SkuBarcode = item.SkuBarcode,
                                SkuQRcode = item.SkuQRcode,
                                Stk_Pie = item.Stk_Pie,
                                Amt_Pie = item.Stk_Pie - item.Sale_Pie,
                                Skuname = item.Skuname,
                                Skucode = item.Skucode,
                                Price = isGoods.Saleprice.Value,
                                Discount = isGoods.Discount ?? 0,
                                Member = isGoods.Memberprice ?? 0,
                                skuSize = goods.Skusize,
                            });
                        }
                    }

                    res.Code = HttpStatusCode.OK.ToString();
                    res.Message = "SUCCESS";
                    res.Count = result_data.Count;
                    res.Results = result_data;
                }
            }
            catch(Exception ex)
            {
                res.Code = HttpStatusCode.NotFound.ToString();
                res.Message = ex.Message;
            }

            return Ok(res);
        }

        [HttpPost("NewReceript")]
        public async Task<ActionResult> NewReceript(mdlNewReceriptH RecriptData)
        {
            try
            {
                this.GetUser();
                using (var jivdb = new JaruernInvContext())
                {
                    Guid ReceiptId = Guid.NewGuid();
                    DateTime Atdate = ServiceText.APIParamToDateTime(RecriptData.Atdate).Value;

                    string ReceiptNo = new serviceSale(RecriptData.Storeid)
                                        .newReceiptNo(Atdate, 
                                                        RecriptData.TypeCode, 
                                                        RecriptData.Culture);
                    

                    var jrn_transaction = jivdb.Database.BeginTransaction();
                    try
                    {
                        List<mdlNewReceript> goodsReceipt = RecriptData.NewReceripts;
                        foreach(var gr in goodsReceipt)
                        {
                            jivdb.Recripts.Add(new Recript() { 
                                Active = true,
                                CreateDate = DateTime.Now,
                                Goodsid = gr.Goodsid,
                                Id = Guid.NewGuid(),
                                Cash = gr.Cash,
                                Cashtype = gr.CashType,
                                Piece = gr.Piece.Value,
                                Saleprice = gr.SalePrice,
                                Recriptid = ReceiptId
                            });

                            jivdb.SaveChanges();
                        }

                        #region receipt Head

                        Guid? RefId = null;
                        if (!string.IsNullOrEmpty(RecriptData.RefId))
                            RefId = new Guid(RecriptData.RefId);

                        jivdb.ReceiptHs.Add(new ReceiptH() { 
                            Atdate = Atdate,
                            Cash = RecriptData.Cash,
                            CreateBy = this.UserId.Value,
                            CreateDate = DateTime.Now,
                            Discount = RecriptData.Discount,
                            Id = ReceiptId,
                            Receiptno = ReceiptNo,
                            Remark = RecriptData.Remark,
                            Storeid = RecriptData.Storeid,
                            Stt = "A",
                            Taxrate = RecriptData.TaxRate,
                            Vat = RecriptData.Vat,
                            Vatrate = RecriptData.VatRate,
                            Memberid = RecriptData.MemberId,
                            Deposit = RecriptData.Deposit,
                            Fullprice = RecriptData.Fullprice,
                            RefId = RefId,
                        });

                        jivdb.SaveChanges();

                        jivdb.RecriptCuscashes.Add(new RecriptCuscash() { 
                            Id = Guid.NewGuid(),
                            Recriptid = ReceiptId,
                            Cashtype = RecriptData.CashType.ToString("00"),
                            Creditno = RecriptData.CreditNo,
                            Cuscredit = RecriptData.CusCredit,
                            Cuscash = RecriptData.CusCash.Value,
                            Cuscashchang = RecriptData.CusChange.Value
                        });

                        jivdb.SaveChanges();

                        #endregion

                        jrn_transaction.Commit();
                        //return Ok(new { id = 0, msg = "SUCCESS" });
                        return Ok(new { id = 0, msg = ReceiptId });
                    }
                    catch 
                    {
                        jrn_transaction.Rollback();
                        throw;
                    }
                }
                
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetReceiptList")]
        public async Task<ActionResult> GetReceiptList(Guid StoreId,string? Atdate,string Code)
        {
            mdlGResultSet<mdlReceiptList> res = new mdlGResultSet<mdlReceiptList>();
            List<mdlReceiptList> result_data = new List<mdlReceiptList>();
            try
            {
                this.GetUser();
                using (var jivdb = new JaruernInvContext())
                {
                    List<ReceiptH> receiptHs = null;
                    if (string.IsNullOrEmpty(Atdate))
                    {
                        receiptHs = jivdb.ReceiptHs.Where(c => c.Stt != "X" &&
                                                                c.Storeid == StoreId &&
                                                                c.Receiptno.StartsWith(Code.ToUpper())
                                                                ).OrderByDescending(o => o.CreateDate)
                                                                .ToList();
                    }
                    else
                    {
                        DateTime atdate = ServiceText.APIParamToDate(Atdate).Value;
                        receiptHs = jivdb.ReceiptHs.Where(c => c.Stt != "X" &&
                                                                c.Storeid == StoreId &&
                                                                c.Atdate.Date == atdate &&
                                                                c.Receiptno.StartsWith(Code.ToUpper())
                                                                ).OrderByDescending(o => o.CreateDate)
                                                                .ToList();
                    }

                    foreach(var rh in receiptHs)
                    {
                        bool isRef = false;
                        int? pie = null;
                        decimal? cash = rh.Cash;
                        decimal? dist = rh.Discount;

                        if (cash == 0)
                        {
                            if (rh.RefId.HasValue)
                            {
                                var receiptHRef = jivdb.ReceiptHs.Where(c => c.Id == rh.RefId).FirstOrDefault();
                                if (receiptHRef != null)
                                {
                                    cash = receiptHRef.Cash;
                                    dist = receiptHRef.Discount;
                                }
                            }
                            else
                            {
                                cash = rh.Deposit;
                                dist = rh.Discount;
                            }
                        }

                        var receiptGoods = jivdb.Recripts.Where(c => c.Recriptid == rh.Id && c.Active == true).ToList();
                        if(receiptGoods.Count > 0)
                            pie = receiptGoods.Select(s => s.Piece).Sum();

                        if (rh.ReReceiptid.HasValue)
                            isRef = true;


                        result_data.Add(new mdlReceiptList() { 
                            Id = rh.Id,
                            Cash = cash,
                            ReceiptNo = rh.Receiptno,
                            Piece = pie,
                            Dis = dist,
                            isRefund = isRef,
                        });
                    }


                    res.Code = HttpStatusCode.OK.ToString();
                    res.Message = "SUCCESS";
                    res.Count = result_data.Count;
                    res.Results = result_data;
                }
            }
            catch(Exception ex)
            {
                res.Code = HttpStatusCode.NotFound.ToString();
                res.Message = ex.Message;
            }

            return Ok(res);
        }

        [HttpGet("GetReceiptListForRet")]
        public async Task<ActionResult> GetReceiptListForRet(Guid StoreId,int load_index,string? findValue)
        {
            mdlGResultSet<mdlReceiptList> res = new mdlGResultSet<mdlReceiptList>();
            List<mdlReceiptList> result_data = new List<mdlReceiptList>();
            try
            {
                this.GetUser();
                using (var jivdb = new JaruernInvContext())
                {
                    List<ReceiptH> receiptHs = null;
                    if (String.IsNullOrEmpty(findValue))
                    {
                        receiptHs = jivdb.ReceiptHs.Where(c => c.Stt != "X" &&
                                                                c.Storeid == StoreId &&
                                                                c.Receiptno.StartsWith("RPT") &&
                                                                c.ReReceiptid == null)
                                                                .OrderByDescending(o => o.CreateDate)
                                                                .ToList();
                    }
                    else
                    {
                        receiptHs = jivdb.ReceiptHs.Where(c => c.Stt != "X" &&
                                                                c.Storeid == StoreId &&
                                                                c.Receiptno.StartsWith("RPT") &&
                                                                c.ReReceiptid == null &&
                                                                c.Receiptno.Contains(findValue.ToUpper())
                                                                )
                                                                .OrderByDescending(o => o.CreateDate)
                                                                .ToList();
                    }

                    int per_load = 50;
                    if (load_index == 0)
                        receiptHs = receiptHs.Take(per_load).ToList();
                    else
                    {
                        int skip = load_index * per_load;
                        int take = skip + load_index;
                        receiptHs = receiptHs.Skip(skip).Take(take).ToList();
                    }

                    foreach (var rh in receiptHs)
                    {
                        int? pie = null;
                        var receiptGoods = jivdb.Recripts.Where(c => c.Recriptid == rh.Id && c.Active == true).ToList();
                        if (receiptGoods.Count > 0)
                        {
                            pie = receiptGoods.Select(s => s.Piece).Sum();
                        }

                        result_data.Add(new mdlReceiptList()
                        {
                            Id = rh.Id,
                            Cash = rh.Cash,
                            ReceiptNo = rh.Receiptno,
                            Piece = pie,
                            Dis = rh.Discount,
                        });
                    }

                    res.Code = HttpStatusCode.OK.ToString();
                    res.Message = "SUCCESS";
                    res.Count = result_data.Count;
                    res.Results = result_data;
                }
            }
            catch (Exception ex)
            {
                res.Code = HttpStatusCode.NotFound.ToString();
                res.Message = ex.Message;
            }

            return Ok(res);
        }

        [HttpGet("GetReceipt")]
        public async Task<ActionResult> GetReceipt(Guid Id,string Culture)
        {
            mdlReceipt result_data = new mdlReceipt();
            try
            {
                this.GetUser();
                using (var jivdb = new JaruernInvContext())
                {
                    var receiptH = jivdb.ReceiptHs.Where(c => c.Id == Id).FirstOrDefault();
                    if(receiptH != null)
                    {
                        #region receipt Head
                        DateCulture culture = DateCulture.ctEng;
                        if (Culture.ToUpper() == "TH")
                            culture = DateCulture.ctThai;

                        string storeName = "";
                        using (var jmmdb = new JmmdatacenterContext())
                        {
                            var store = jmmdb.Stores.Where(c => c.Id == receiptH.Storeid).FirstOrDefault();
                            if (store != null)
                                storeName = store.Storename;
                        }

                        result_data.Id = receiptH.Id;
                        result_data.Atdate = ServiceDateTime.ToDateTimeString(receiptH.Atdate, "dd/MM/yyyy HH:mm", culture);
                        result_data.Storeid = receiptH.Storeid;
                        result_data.Remark = receiptH.Remark ?? "";
                        result_data.Vat = receiptH.Vat;
                        result_data.Discount = receiptH.Discount;
                        result_data.VatRate = receiptH.Vatrate;
                        result_data.TaxRate = receiptH.Taxrate;
                        result_data.Cash = receiptH.Cash;
                        result_data.ReceiptNo = receiptH.Receiptno;
                        result_data.CreateDate = receiptH.CreateDate.ToString("dd/MM/yyyy HH:mm",new CultureInfo("en-US"));
                        result_data.CreateBy = this.UserName;
                        result_data.MemberId = receiptH.Memberid ?? "";
                        result_data.StoreName = storeName;
                        result_data.Fullprice = receiptH.Fullprice;
                        result_data.Deposit = receiptH.Deposit;
                        result_data.RefId = receiptH.RefId;

                        var cusCash = jivdb.RecriptCuscashes.Where(c => c.Recriptid == receiptH.Id).FirstOrDefault();
                        if(cusCash!=null)
                        {
                            result_data.CashType = cusCash.Cashtype;
                            result_data.CusCash = cusCash.Cuscash;
                            result_data.CusChange = cusCash.Cuscashchang;
                            result_data.CreditNo = cusCash.Creditno;
                            result_data.CusCredit = cusCash.Cuscredit;
                        }

                        #endregion

                        String spText = "EXECUTE spGoodsInStock @p0 ";
                        var goods_stock = jivdb.spGoodsInStock.FromSqlRaw(spText, receiptH.Storeid).ToList();

                        var receipt = jivdb.Recripts.Where(c => 
                                                        c.Recriptid == Id && c.Active == true)
                                                        .OrderBy(o=>o.CreateDate).ToList();

                        if(receipt.Count > 0)
                        {
                            List<mdlReceriptGoods> recp = new List<mdlReceriptGoods>();
                            foreach (var rec in receipt)
                            {
                                var goods = goods_stock.Where(c => c.GoodId == rec.Goodsid).FirstOrDefault();
                                if(goods!=null)
                                {
                                    recp.Add(new mdlReceriptGoods()
                                    {
                                        Cash = rec.Cash,
                                        CashType = rec.Cashtype,
                                        Barcode = goods.SkuBarcode,
                                        Goodsid = goods.GoodId,
                                        GoodsName = goods.Skuname,
                                        Piece = rec.Piece,
                                        QrCode = goods.SkuQRcode,
                                        SalePrice = rec.Saleprice,
                                        Size= goods.Skusize,
                                        Id = rec.Id,
                                    });
                                }
                            }

                            result_data.ReceriptGoods = recp;
                        }

                        #region prepare refund data
                        if (receiptH.ReReceiptid.HasValue)
                        {
                            var reReceipt = jivdb.ReceiptHs.Where(c =>
                                                                c.Id == receiptH.ReReceiptid.Value &&
                                                                c.Stt == "X").FirstOrDefault();
                            if (reReceipt != null)
                            {
                                var refType = jivdb.Refundtypes.Where(c =>
                                                                c.Code.ToUpper() == receiptH.ReReftype.ToUpper()
                                                                ).FirstOrDefault();

                                result_data.XReceiptNo = reReceipt.Receiptno;
                                result_data.XReceiptCash = reReceipt.Cash;
                                result_data.Refund = receiptH.ReRefund;
                                result_data.RefundType = refType.Name+"("+refType.Code+")";

                                var XReceipts = jivdb.Recripts.Where(c => 
                                                                    c.Active == false && 
                                                                    c.Recriptid == reReceipt.Id &&
                                                                    c.Tag.Contains("#return")
                                                                    ).ToList();

                                var retType = jivdb.Goodsreturntypes.ToList();

                                List<mdlReceriptGoods> recp = new List<mdlReceriptGoods>();
                                foreach (var XReceipt in XReceipts) {
                                    var goods = goods_stock.Where(c => c.GoodId == XReceipt.Goodsid).FirstOrDefault();
                                    if (goods != null)
                                    {
                                        int goodsRet = Convert.ToInt32(XReceipt.ReCode);
                                        var reT = retType.Where(c => c.Id == goodsRet).FirstOrDefault();

                                        recp.Add(new mdlReceriptGoods()
                                        {
                                            Cash = XReceipt.Cash,
                                            CashType = XReceipt.Cashtype,
                                            Barcode = goods.SkuBarcode,
                                            Goodsid = goods.GoodId,
                                            GoodsName = goods.Skuname,
                                            Piece = XReceipt.Piece,
                                            QrCode = goods.SkuQRcode,
                                            SalePrice = XReceipt.Saleprice,
                                            Size = goods.Skusize,
                                            Id = XReceipt.Id,
                                            Recode = reT.Name+"("+reT.Id.ToString()+")",
                                            Rereason = XReceipt.ReReason ?? ""
                                        });
                                    }
                                }

                                result_data.XReceriptGoods = recp;
                            }
                        }


                        #endregion
                    }
                }

                return Ok(new { id = 0, msg = "SUCCESS",data = result_data });
            }
            catch(Exception ex)
            {
                return Ok(new { id = 1, msg = ex.Message ,data = result_data });
            }
        }

        [HttpPost("RenewReceipt")]
        public async Task<ActionResult> RenewReceipt(mdlRenewReceipt Values)
        {
            try
            {
                this.GetUser();
                Guid newReceiptId = Guid.NewGuid();
                using (var jivdb = new JaruernInvContext())
                {
                    var receiptH = jivdb.ReceiptHs.Where(c => c.Id == Values.Id).FirstOrDefault();
                    if (receiptH != null)
                    {
                        Guid[] dropGoods = Values.XGoodsReason.Select(s=>s.ReceiptItemId).ToArray();

                        string typeCode = receiptH.Receiptno.Substring(0, 3);
                        string ReceiptNo = new serviceSale(Values.StoreId).newReceiptNo(DateTime.Now, typeCode, Values.Culture);

                        var jrn_transaction = jivdb.Database.BeginTransaction();
                        {
                            try
                            {
                                var goodsReceipt = jivdb.Recripts.Where(c => c.Recriptid == receiptH.Id &&
                                                            c.Active == true 
                                                            ).ToList();

                                #region add new goods receipt
                                var receipt = goodsReceipt.Where(c => !dropGoods.Contains(c.Id)).ToList();

                                decimal cash = 0;
                                decimal discount = 0;
                                foreach (var re in receipt)
                                {
                                    jivdb.Recripts.Add(new Recript() { 
                                        Id = Guid.NewGuid(),
                                        Active = true,
                                        Cash = re.Cash,
                                        Cashtype = re.Cashtype,
                                        CreateDate = DateTime.Now,
                                        Goodsid = re.Goodsid,
                                        Piece = re.Piece,
                                        Recriptid = newReceiptId,
                                        Remark = re.Remark,
                                        Saleprice = re.Saleprice,
                                        Tag = null,
                                        UpdateDate = null,
                                    });
                                    jivdb.SaveChanges();

                                    cash += re.Cash.Value;
                                    discount += re.Saleprice.Value - re.Cash.Value;
                                }
                                #endregion

                                #region drop old goods receipt
                                foreach(var goodsRec in goodsReceipt)
                                {
                                    goodsRec.Active = false;
                                    
                                    var goodsDrop = Values.XGoodsReason.Where(c => c.ReceiptItemId == goodsRec.Id).FirstOrDefault();
                                    if (goodsDrop != null)
                                    {
                                        goodsRec.Tag += "#return";
                                        goodsRec.ReCode = goodsDrop.ReasonCode;
                                        goodsRec.ReReason = goodsDrop.ReasonText;
                                    }

                                    jivdb.SaveChanges();
                                }

                                #endregion

                                decimal refund = receiptH.Cash.Value - cash;
                                decimal vat = (cash / 100) * 7;

                                jivdb.ReceiptHs.Add(new ReceiptH()
                                {
                                    Atdate = DateTime.Now,
                                    Cash = cash,
                                    CreateBy = this.UserId.Value,
                                    CreateDate = DateTime.Now,
                                    Discount = discount,
                                    Id = newReceiptId,
                                    Memberid = receiptH.Memberid,
                                    Receiptno = ReceiptNo,
                                    Remark = Values.Remark,
                                    ReReceiptid = Values.Id,
                                    ReRefund = refund,
                                    ReReftype = Values.RefundType,
                                    Storeid = Values.StoreId,
                                    Stt = "A",
                                    Tag = receiptH.Tag,
                                    Taxrate = receiptH.Taxrate.Value,
                                    Vat = vat,
                                    Vatrate = receiptH.Vatrate.Value,
                                });
                                jivdb.SaveChanges();

                                receiptH.UpdateDate = DateTime.Now;
                                receiptH.UpdateBy = this.UserId.Value;
                                receiptH.Stt = "X";
                                receiptH.Tag += "#refund";
                                jivdb.SaveChanges();

                                jrn_transaction.Commit();
                            }
                            catch (Exception ex)
                            {
                                jrn_transaction.Rollback();
                                throw;
                            }
                        }

                        
                    }
                }

                return Ok(new { id = 0, msg = "SUCCESS",receiptid = newReceiptId });
            }
            catch(Exception ex)
            {
                return Ok(new { id = 1, msg = ex.Message, receiptid = ""});
            }
        }

        [HttpPost("DeleteReceipt")]
        public async Task<ActionResult> DeleteReceipt(mdlDelReceipt Values)
        {
            try
            {
                this.GetUser();
                using (var jivdb = new JaruernInvContext())
                {
                    var receipt = jivdb.ReceiptHs.Where(c => c.Id == Values.RecriptId && c.Stt!="X").FirstOrDefault();
                    if(receipt!=null)
                    {
                        var jrn_transaction = jivdb.Database.BeginTransaction();
                        try
                        {
                            var goods = jivdb.Recripts.Where(c => c.Recriptid == receipt.Id && c.Active == true).ToList();
                            foreach(var good in goods)
                            {
                                good.Active = false;
                                good.UpdateDate = DateTime.Now;
                                jivdb.SaveChanges();
                            }

                            jivdb.ReceiptXes.Add(new ReceiptX() { 
                                Stt = "A",
                                CreateDate = DateTime.Now,
                                Id = Guid.NewGuid(),
                                Receiptid = receipt.Id,
                                Reasonno = Values.ReasonNo,
                                Reasontxt = Values.ReasonTxt
                            });
                            jivdb.SaveChanges();

                            receipt.Stt = "X";
                            receipt.UpdateDate = DateTime.Now;
                            receipt.UpdateBy = this.UserId;
                            jivdb.SaveChanges();

                            jrn_transaction.Commit();
                            return Ok(new { id = 0, msg = "SUCCESS" });
                        }
                        catch
                        {
                            jrn_transaction.Rollback();
                            throw;
                        }
                    }
                    else
                    {
                        return Ok(new { id = 0, msg = "SUCCESS" });
                    }
                }
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetReceiptQRBarcode")]
        public async Task<ActionResult> GetReceiptQRBarcode(string Barcode,Guid StoreId, Guid ReceiptId,int BType)
        {
            try
            {
                this.GetUser();

                string wwwRootPath = _hostingEnvironment.WebRootPath;
                string contentRootPath = _hostingEnvironment.ContentRootPath;
                var uploadsDirectory = contentRootPath + "\\StoresAssets\\" + StoreId.ToString() + "\\ReceiptBarcode\\";

                if (!Directory.Exists(uploadsDirectory))
                {
                    Directory.CreateDirectory(uploadsDirectory);
                }

                string vurl = serviceCfg.GetImageVirtualUrl("storesassets"); //url
                string fileName = "";
                if (BType == 1)
                {
                    fileName = "BCRPT_" + ReceiptId.ToString().ToLower() + ".png";

                    if (!System.IO.File.Exists(uploadsDirectory + "\\" + fileName))
                        new serviceBarcode().CreateBarcode(Barcode, uploadsDirectory, fileName, 270, 100);
                }
                else if (BType == 2)
                {
                    fileName = "QRRPT_" + ReceiptId.ToString().ToLower() + ".png";

                    if (!System.IO.File.Exists(uploadsDirectory + "\\" + fileName))
                        new serviceBarcode().CreateQRcode(Barcode, uploadsDirectory, fileName);
                }

                return Ok(new { id = 0, msg = "SUCCESS", url = vurl + StoreId.ToString() + "/ReceiptBarcode/" + fileName });
            }
            catch (Exception ex)
            {
                return Ok(new { id = 1, msg = ex.Message, url = "" });
            }
        }

        [HttpGet("GetGoodsReturnType")]
        public async Task<ActionResult> GetGoodsReturnType()
        {
            List<mdlGValue> result_data = new List<mdlGValue>();

            try
            {
                using (var jivdb = new JaruernInvContext())
                {
                    var rets = jivdb.Goodsreturntypes.Where(c => c.Active).OrderBy(o=>o.Id).ToList();
                    foreach(var ret in rets)
                    {
                        result_data.Add(new mdlGValue() { 
                            Key = ret.Id,
                            Value = ret.Name
                        });
                    }
                }

                return Ok(new { id = 0, msg = "SUCCESS", data = result_data });
            }
            catch(Exception ex) {
                return Ok(new { id = 1, msg = ex.Message, data = result_data });
            }
        }

        [HttpGet("GetRefundType")]
        public async Task<ActionResult> GetRefundType()
        {
            List<mdlGValue> result_data = new List<mdlGValue>();

            try
            {
                using (var jivdb = new JaruernInvContext())
                {
                    var refs = jivdb.Refundtypes.Where(c => c.Active).OrderBy(o => o.Seq).ToList();
                    foreach (var reF in refs)
                    {
                        result_data.Add(new mdlGValue()
                        {
                            Key = reF.Code,
                            Value = reF.Name
                        });
                    }
                }

                return Ok(new { id = 0, msg = "SUCCESS", data = result_data });
            }
            catch (Exception ex)
            {
                return Ok(new { id = 1, msg = ex.Message, data = result_data });
            }
        }

        [HttpGet("GetReceiptId")]
        public async Task<ActionResult> GetReceiptId(string ReceiptNo, Guid StoreId)
        {
            try
            {
                //this.GetUser();
                using (var jivdb = new JaruernInvContext())
                {
                    var isReceipt = jivdb.ReceiptHs.Where(c => c.Stt != "X"
                                                            && c.Receiptno.ToUpper() == ReceiptNo.ToUpper()
                                                            && c.Storeid == StoreId
                                                            ).FirstOrDefault();

                    if(isReceipt==null)
                    {
                        return Ok(new { id = 2, msg = "Receipt is not exist" });
                    }
                    else
                    {
                        return Ok(new { id = 0, msg = isReceipt.Id.ToString() });
                    }
                }
            }
            catch(Exception ex)
            {
                return Ok(new { id = 1, msg = ex.Message });
            }
        }

    }
}
