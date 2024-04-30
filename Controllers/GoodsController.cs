using Genesyst.Models;
using jaruernCore.localLib;
using jaruernCore.Models;
using jaruernCore.Models.dbs_jaruern_inv;
using jaruernCore.Models.dbs_jmmdatacenter;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting.Internal;
using ServiceLib;
using SixLabors.ImageSharp.Formats;
using SixLabors.ImageSharp.Formats.Jpeg;
using System.Collections;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using static System.Net.Mime.MediaTypeNames;
using Image = SixLabors.ImageSharp.Image;

namespace jaruernCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GoodsController : BaseController
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IWebHostEnvironment _hostingEnvironment;

        public GoodsController(ILogger<WeatherForecastController> logger, IWebHostEnvironment hostingEnvironment)
        {
            _logger = logger;
            _hostingEnvironment = hostingEnvironment;
        }

        [HttpGet("ProductType")]
        public async Task<ActionResult> ProductType()
        {
            try
            {
                this.GetUser();
                using (var jinvdb = new JaruernInvContext())
                {
                    var productTypes = jinvdb.Producttypes.Where(c => 
                                            c.Stt != "X" && c.Active == true)
                                            .OrderBy(o=>o.Producttypename).ToList();

                    if(this.TeamId!=serviceCfg.GetExternalTeamId())
                        productTypes = productTypes.Where(c=>c.Teamid == this.TeamId).ToList();

                    List<mdlProductType> result = new List<mdlProductType>();
                    foreach(var productType in productTypes)
                    {
                        result.Add(new mdlProductType() { 
                            Id = productType.Id,
                            Producttypecode = productType.Producttypecode,
                            Producttypename = productType.Producttypename,
                        });
                    }

                    return Ok(result);
                }

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("ProductGroup")]
        public async Task<ActionResult> ProductGroup()
        {
            try
            {
                this.GetUser();
                using (var jinvdb = new JaruernInvContext())
                {
                    var productGroups = jinvdb.Productgroups.Where(c =>
                                            c.Stt != "X" && c.Active == true)
                                            .OrderBy(o => o.Productgroupname).ToList();

                    if (this.TeamId != serviceCfg.GetExternalTeamId())
                        productGroups = productGroups.Where(c => c.Teamid == this.TeamId).ToList();

                    List<mdlProductGroup> result = new List<mdlProductGroup>();
                    foreach (var productGroup in productGroups)
                    {
                        result.Add(new mdlProductGroup()
                        {
                            Id = productGroup.Id,
                            Productgroupcode = productGroup.Productgroupcode,
                            Productgroupname = productGroup.Productgroupname,
                            Producttypeid = productGroup.Producttypeid
                        });
                    }

                    return Ok(result);
                }

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpPost("NewGoods")]
        public async Task<ActionResult> NewGoods(mdlNewGoods Values)
        {
            try
            {
                this.GetUser();

                using (var jinvdb = new JaruernInvContext())
                {
                    Guid GoodsId = Guid.NewGuid();

                    var isGoods = jinvdb.Goods.Where(c => c.Skubarcode == Values.Skubarcode
                                                        && c.Stt != "X"
                                                        && c.Teamid == this.TeamId
                                                        ).FirstOrDefault();

                    var jrn_transaction = jinvdb.Database.BeginTransaction();
                    try
                    {
                        if (isGoods == null)
                        {
                            jinvdb.Goods.Add(new Good()
                            {
                                Active = true,
                                CreateBy = this.UserId.Value,
                                CreateDate = DateTime.Now,
                                Desp = Values.Desp,
                                Id = GoodsId,
                                Productgroupid = Values.Productgroupid,
                                Producttypeid = Values.Producttypeid,
                                Productid = null,
                                Skubarcode = Values.Skubarcode,
                                Skucode = Values.Skucode,
                                Skudisplayname = Values.Skudisplayname,
                                Skuname = Values.Skuname,
                                Skuqrcode = Values.Skuqrcode,
                                Skusize = Values.Skusize,
                                Stt = "A",
                                Teamid = TeamId,
                                Tag = null,
                                UpdateBy = null,
                                UpdateDate = null,
                            });
                        }
                        else
                            GoodsId = isGoods.Id;


                        jinvdb.SaveChanges();
                        jrn_transaction.Commit();

                        return Ok(new { id = 0, msg = "SUCCESS" });
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
                return Ok(new { id = 1, msg = ex.Message });
            }
        }

        [HttpGet("GoodsList")]
        public async Task<ActionResult> GoodsList(int load_index,string? findvalue,
                                                    string? barcode,Guid? ptype,Guid? pgroup,bool Favorite)
        {
            mdlGResultSet<mdlGoodsItem> res = new mdlGResultSet<mdlGoodsItem>();
            List<mdlGoodsItem> items = new List<mdlGoodsItem>();
            try
            {
                this.GetUser();
                using (var jivdb = new JaruernInvContext())
                {
                    List<GoodsFavorite> goodsFav = new List<GoodsFavorite>();

                    if (Favorite)
                    {
                        goodsFav = jivdb.GoodsFavorites.Where(c =>
                                                        c.Userid == this.UserId).ToList();
                    }

                    List<Good> goods = new List<Good>();
                    if (!string.IsNullOrEmpty(barcode))
                    {
                        goods = jivdb.Goods.Where(c => c.Stt != "X" &&
                                                            c.Active == true &&
                                                            c.Teamid == this.TeamId &&
                                                            (c.Skubarcode == barcode ||
                                                             c.Skuqrcode == barcode)
                                                            ).ToList();
                    }
                    else
                    {
                        #region
                        goods = jivdb.Goods.Where(c => c.Stt != "X" &&
                                                            c.Active == true &&
                                                            c.Teamid == this.TeamId).ToList();
                        if (ptype.HasValue)
                            goods = goods.Where(c => c.Producttypeid == ptype).ToList();

                        if (pgroup.HasValue)
                            goods = goods.Where(c => c.Productgroupid == pgroup).ToList();

                        if (!string.IsNullOrEmpty(findvalue))
                        {
                            string fval = findvalue.ToUpper();
                            goods = goods.Where(c =>
                                                    c.Skucode.ToUpper() == fval ||
                                                    c.Skuname.Contains(fval) ||
                                                    c.Skudisplayname.Contains(fval)
                                                    ).ToList();
                        }

                        if(goodsFav.Count > 0)
                        {
                            Guid[] favids = goodsFav.Select(s=>s.Goodsid).ToArray();
                            goods = goods.Where(c => favids.Contains(c.Id)).ToList();
                        }

                        #endregion
                    }


                    int per_load = 50;
                    if (load_index == 0)
                        goods = goods.Take(per_load).ToList();
                    else
                    {
                        int skip = load_index * per_load;
                        int take = skip + load_index;
                        goods = goods.Skip(skip).Take(take).ToList();
                    }

                    foreach (var good in goods.OrderByDescending(o =>o.CreateDate).ToList())
                    {
                        items.Add(new mdlGoodsItem() { 
                            Id = good.Id,
                            Desp = good.Desp,
                            Productgroupid = good.Productgroupid,
                            Producttypeid = good.Producttypeid,
                            Skubarcode = good.Skubarcode,
                            Skucode = good.Skucode,
                            Skudisplayname = good.Skudisplayname,
                            Skuname = good.Skuname,
                            Skuqrcode = good.Skuqrcode,
                            Skusize = good.Skusize,
                        });
                    }

                    res.Results = items;
                    res.Code = HttpStatusCode.OK.ToString();
                    res.Count = items.Count;
                    res.Message = "SUCCESS";
                }

                return Ok(res);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetGoods")]
        public async Task<ActionResult> GetGoods(Guid id)
        {
            try
            {
                mdlGoods res = new mdlGoods();
                this.GetUser();
                using (var jivdb = new JaruernInvContext())
                {
                    var goods = jivdb.Goods.Where(c => c.Stt != "X" && c.Id == id).FirstOrDefault();
                    if(goods!=null)
                    {
                        string ptypename = "";
                        var ptype = jivdb.Producttypes.Where(c => c.Id == goods.Producttypeid).FirstOrDefault();
                        if (ptype != null)
                            ptypename = ptype.Producttypename;

                        string pgroupname = "";
                        if (goods.Productgroupid != null)
                        {
                            var pgrp = jivdb.Productgroups.Where(c => c.Id == goods.Productgroupid).FirstOrDefault();
                            if (pgrp != null)
                                pgroupname = pgrp.Productgroupname;
                        }

                        bool fav = false;
                        var isFav = jivdb.GoodsFavorites.Where(c => 
                                                                c.Userid == this.UserId && 
                                                                c.Goodsid == goods.Id).FirstOrDefault();
                        if (isFav != null)
                            fav = true;

                        res.Skucode = goods.Skucode;
                        res.Skudisplayname = goods.Skudisplayname;
                        res.Skuname = goods.Skuname;
                        res.Skubarcode = goods.Skubarcode;
                        res.Skuqrcode = goods.Skuqrcode;
                        res.Active = goods.Active;
                        res.CreateBy = goods.CreateBy;
                        res.CreateDate = goods.CreateDate;
                        res.UpdateDate = goods.UpdateDate;
                        res.UpdateBy = goods.UpdateBy;
                        res.Desp = goods.Desp;
                        res.Id = goods.Id;
                        res.Skusize = goods.Skusize;
                        res.Stt = goods.Stt;
                        res.Tag = goods.Tag;
                        res.Teamid = goods.Teamid;
                        res.Productid = goods.Productid;
                        res.Productgroupid = goods.Productgroupid;
                        res.Producttypeid = goods.Producttypeid;
                        res.Producttypename = ptypename;
                        res.Productgroupname = pgroupname;
                        res.Favorite = fav;
                    }
                }

                return Ok(res);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpGet("GetSetGoodsFavorite")]
        public async Task<ActionResult> GetSetGoodsFavorite(Guid goodsid)
        {
            try
            {
                this.GetUser();
                using (var jivdb = new JaruernInvContext())
                {
                    var goodsFav = jivdb.GoodsFavorites.Where(c => 
                                                        c.Goodsid == goodsid && 
                                                        c.Userid == this.UserId
                                                        ).FirstOrDefault();

                    var jrn_transaction = jivdb.Database.BeginTransaction();
                    try
                    {
                        if (goodsFav == null)
                        {
                            jivdb.GoodsFavorites.Add(new GoodsFavorite() { 
                                CreateDate = DateTime.Now,
                                Goodsid = goodsid,
                                Userid = this.UserId.Value,
                                Id = Guid.NewGuid()
                            });

                            jivdb.SaveChanges();
                        }
                        else
                        {
                            jivdb.GoodsFavorites.Remove(goodsFav);
                            jivdb.SaveChanges();
                        }

                        jrn_transaction.Commit();
                    }
                    catch
                    {
                        jrn_transaction.Rollback();
                        throw;
                    }
                }

                return Ok("SUCCESS");
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpGet("GetUnits")]
        public async Task<ActionResult> GetUnits(Guid? id,string culture)
        {
            try
            {
                List<mdlGValue> res = new List<mdlGValue>();
                using (var jivdb = new JaruernInvContext())
                {
                    var units = jivdb.Units.Where(c => c.Active == true).OrderBy(o=>o.Seq).ToList();

                    if(id.HasValue)
                        units = units.Where(c=>c.Id == id).ToList();

                    foreach (var unit in units)
                    {
                        if (culture.ToLower() == "en")
                        {
                            res.Add(new mdlGValue()
                            {
                                Key = unit.Id,
                                Value = unit.Uniten
                            });
                        }
                        else
                        {
                            res.Add(new mdlGValue()
                            {
                                Key = unit.Id,
                                Value = unit.Unitth
                            });
                        }
                    }
                }

                return Ok(res);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("SetGoodsImage")]
        [Consumes("multipart/form-data")]
        public async Task<ActionResult> SetGoodsImage([FromForm]  mdlGoodsFile Values)
        {

            if (Values.GFile == null || Values.GFile.Length == 0)
                return BadRequest(new { id = 1, msg = "File is not exist uploading" });

            //if (!ServiceImage.IsImage(Values.GFile.ContentType))
            //    return BadRequest(new { id = 2, msg = "File is not image type" });

            // Get the wwwroot folder path
            string wwwRootPath = _hostingEnvironment.WebRootPath;

            // Get the content root folder path
            string contentRootPath = _hostingEnvironment.ContentRootPath;

            var uploadsDirectory = contentRootPath + "\\Images\\Goods";
            //var uploadsDirectory = Path.Combine(Directory.GetCurrentDirectory(), "\\Images\\Goods");
            if (!Directory.Exists(uploadsDirectory))
            {
                Directory.CreateDirectory(uploadsDirectory);
            }

            this.GetUser();

            string fileName = "";
            string filePath = "";

            using (var jinvdb = new JaruernInvContext())
            {
                var isImage = jinvdb.GoodsImgs.Where(c =>
                                                        c.Storeid == Values.Storeid &&
                                                        c.Imgtype == Values.ImageType &&
                                                        c.Barcode.ToUpper() == Values.Barcode.ToUpper() &&
                                                        c.Stt == "A"
                                                        ).FirstOrDefault();

                var jrn_transaction = jinvdb.Database.BeginTransaction();
                try
                {
                    if (isImage != null)
                    {
                        isImage.Stt = "X";
                        jinvdb.SaveChanges();

                        fileName = isImage.Id.ToString() + ".jpg";
                        filePath = Path.Combine(uploadsDirectory, fileName);

                        try
                        {
                            if (System.IO.File.Exists(filePath))
                            {
                                System.IO.File.Delete(filePath);
                            }
                        }
                        catch (Exception ex)
                        {
                            return Ok(new { id = 4, msg = ex.Message });
                        }
                    }


                    Guid ImageId = Guid.NewGuid();
                    fileName = ImageId.ToString() + ".jpg";
                    filePath = Path.Combine(uploadsDirectory, fileName);

                    jinvdb.GoodsImgs.Add(new GoodsImg()
                    {
                        Barcode = Values.Barcode,
                        CreateBy = this.UserId,
                        CreateDate = DateTime.Now,
                        Id = ImageId,
                        Imgtype = Values.ImageType,
                        Storeid = Values.Storeid,
                        Stt = "A",
                        Tag = null
                    });

                    jinvdb.SaveChanges();

                    using (Stream fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        await Values.GFile.CopyToAsync(fileStream);
                    }

                    jrn_transaction.Commit();

                    return Ok(new { id = 0, msg = "SUCCESS" });
                }
                catch(Exception ex)
                {
                    jrn_transaction.Rollback();
                    return Ok(new { id = 3, msg = ex.Message });
                }
            }

            
        }


        [HttpGet("GetGoodsImage")]
        public async Task<ActionResult> GetGoodsImage(string Barcode,Guid StoreId,string ImgType)
        {
            string wwwRootPath = _hostingEnvironment.WebRootPath;
            string contentRootPath = _hostingEnvironment.ContentRootPath;

            var uploadsDirectory = contentRootPath + "\\Images\\Goods";

            using (var jinvdb = new JaruernInvContext())
            {
                var isImage = jinvdb.GoodsImgs.Where(c =>
                                                        c.Storeid == StoreId &&
                                                        c.Imgtype == ImgType &&
                                                        c.Barcode.ToUpper() == Barcode.ToUpper() &&
                                                        c.Stt == "A"
                                                        ).FirstOrDefault();

                if (isImage != null)
                {
                    string fileName = isImage.Id.ToString() + ".jpg";
                    string filePath = Path.Combine(uploadsDirectory, fileName);

                    if (System.IO.File.Exists(filePath))
                    {
                        string vurl = serviceCfg.GetImageVirtualUrl("goods");
                        return Ok(new { id = 0, msg = "SUCCESS", url = vurl+fileName });
                    }
                    else
                        return Ok(new { id = 0, msg = "Image Symbol", url = "" });
                }
                else
                    return Ok(new { id = 1, msg = "Image not exist", url = "" });
            }
        }

        [HttpGet("GetGoodsBarcode")]
        public async Task<ActionResult> GetGoodsBarcode(string Barcode)
        {
            try
            {
                this.GetUser();

                string wwwRootPath = _hostingEnvironment.WebRootPath;
                string contentRootPath = _hostingEnvironment.ContentRootPath;

                string vurl = serviceCfg.GetImageVirtualUrl("barcode"); //url

                string fileName = "BC-"+Barcode.ToLower() + ".png";
                var uploadsDirectory = contentRootPath + "\\Images\\Barcode\\"+this.TeamId.ToString();

                if (!Directory.Exists(uploadsDirectory))
                {
                    Directory.CreateDirectory(uploadsDirectory);
                }

                if (!System.IO.File.Exists(uploadsDirectory + "\\" + fileName))
                {
                    new serviceBarcode().CreateBarcode(Barcode, uploadsDirectory, fileName,250,120);
                }
                

                return Ok(new { id = 0, msg = "SUCCESS", url = vurl + this.TeamId.ToString() +"/"+ fileName });
            }
            catch(Exception ex)
            {
                return Ok(new { id = 1, msg = ex.Message, url = "" });
            }
        }

        [HttpGet("GetGoodsQRcode")]
        public async Task<ActionResult> GetGoodsQRcode(string Barcode,string DataTxt)
        {
            try
            {
                this.GetUser();

                string wwwRootPath = _hostingEnvironment.WebRootPath;
                string contentRootPath = _hostingEnvironment.ContentRootPath;

                string vurl = serviceCfg.GetImageVirtualUrl("qrcode"); //url

                string fileName = "QR-" + Barcode.ToLower() + ".png";
                var uploadsDirectory = contentRootPath + "\\Images\\Qrcode\\" + this.TeamId.ToString();

                if (!Directory.Exists(uploadsDirectory))
                {
                    Directory.CreateDirectory(uploadsDirectory);
                }

                if (!System.IO.File.Exists(uploadsDirectory + "\\" + fileName))
                {
                    new serviceBarcode().CreateQRcode(DataTxt, uploadsDirectory, fileName);
                }


                return Ok(new { id = 0, msg = "SUCCESS", url = vurl + this.TeamId.ToString() + "/" + fileName });
            }
            catch (Exception ex)
            {
                return Ok(new { id = 1, msg = ex.Message, url = "" });
            }
        }

    }
}
