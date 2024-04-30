using Genesyst.Models;
using GeoCoordinatePortable;
using jaruernCore.localLib;
using jaruernCore.Models;
using jaruernCore.Models.dbs_jmmdatacenter;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Net.NetworkInformation;

namespace jaruernCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoreController : BaseController
    {
        private readonly ILogger<WeatherForecastController> _logger;

        public StoreController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;

        }

        [HttpGet("StoreList")]
        public async Task<ActionResult> StoreList(int load_index,string? storegroup,string? storetype, 
                                string? filter,string? location)
        {
            List<mdlStoreList> store_list = new List<mdlStoreList>();
            using (var jmmdb = new JmmdatacenterContext())
            {
                if (!string.IsNullOrEmpty(location))
                {

                }

                #region
                List<Store> stores = new List<Store>();
                if (!string.IsNullOrEmpty(storegroup))
                {
                    stores = jmmdb.Stores.Where(c => 
                                            c.Storegroupid == new Guid(storegroup) && c.Stt != "X")
                                            .ToList();
                }
                if (!string.IsNullOrEmpty(storetype))
                {
                    stores = jmmdb.Stores.Where(c => 
                                            c.Storetypeid == new Guid(storetype) && c.Stt != "X")
                                            .ToList();
                }
                if (!string.IsNullOrEmpty(filter))
                {
                    string filVal = filter.Trim();
                    stores = jmmdb.Stores.Where(c => c.Stt != "X" && 
                                                (c.Storedisplay.Contains(filVal) ||
                                                c.Storename.Contains(filVal) ||
                                                c.Storecode.ToUpper().Contains(filVal.ToUpper()))
                                                ).ToList();
                }
                else
                {
                    stores = jmmdb.Stores.Where(c => c.Stt != "X" ).ToList();
                }

                #endregion

                int per_load = 50;
                if (load_index == 0)
                    stores = stores.Take(per_load).ToList();
                else
                {
                    int skip = load_index * per_load;
                    int take = skip + load_index;
                    stores = stores.Skip(skip).Take(take).ToList();
                }

                foreach(var store in stores.OrderByDescending(o => o.CreateDate).ToList())
                {
                    var isDupp = store_list.Where(c => 
                                                    c.StoreDisplayName.ToUpper() == store.Storedisplay.ToUpper()
                                                    ).FirstOrDefault();
                    if (isDupp == null)
                    {
                        store_list.Add(new mdlStoreList()
                        {
                            Id = store.Id,
                            StoreDisplayName = store.Storedisplay
                        });
                    }
                }

            }


            return Ok(store_list);
        }


        [HttpPost("NewStore")]
        public async Task<ActionResult> NewStore(mdlGValue Values)
        {
            mdlGValue res = new mdlGValue();
            try
            {
                using (var jmmdb = new JmmdatacenterContext())
                {
                    string store_code = Values.Key.ToString().ToUpper();
                    string store_name = Values.Value.ToString();
                    var isStore = jmmdb.Stores.Where(c=>c.Stt!="X" && 
                                                (c.Storecode.ToUpper()== store_code ||
                                                c.Storename.ToUpper()== store_name.ToUpper())
                                                ).FirstOrDefault();
                    if(isStore==null)
                    {
                        Guid StoreId = Guid.NewGuid();
                        Guid TeamId = serviceCfg.GetExternalTeamId();

                        var jmmdb_transaction = jmmdb.Database.BeginTransaction();
                        try
                        {
                            jmmdb.Stores.Add(new Store()
                            {
                                Areaid = null,
                                Branchcode = null,
                                Branchname = null,
                                CreateBy = serviceCfg.GetAdminId(),
                                CreateDate = DateTime.Now,
                                Desp = null,
                                Id = StoreId,
                                Priority = 0,
                                Storecode = store_code,
                                Storedisplay = store_name,
                                Storegroupid = null,
                                Storename = store_name,
                                Storetypeid = null,
                                Stt = "A",
                                Tag = null,
                                Teamid = TeamId.ToString() + ";",
                                UpdateBy = null,
                                UpdateDate = null,
                            });

                            jmmdb.SaveChanges();
                            jmmdb_transaction.Commit();

                            res.Key = 0;
                            res.Value = StoreId;
                        }
                        catch 
                        {
                            jmmdb_transaction.Rollback();
                            throw;
                        }
                    }
                    else
                    {
                        res.Key = 2;
                        res.Value = "Store dupplicate";
                    }
                }
            }
            catch(Exception ex) {
                res.Key = 1;
                res.Value = ex.Message;
            }

            return Ok(res);
        }


        [HttpGet("MyStore")]
        public async Task<ActionResult> MyStore(double lat, double lng)
        {
            mdlGResultSet<mdlMyStore> Res = new mdlGResultSet<mdlMyStore>();
            List<mdlMyStore> myStores = new List<mdlMyStore>();
            try
            {
                if(this.GetUser())
                {
                    using (var jmmdb = new JmmdatacenterContext())
                    {
                        List<Store> stores = null;
                        if(this.isExternalUser)
                        {
                            stores = jmmdb.Stores.Where(c => c.Stt != "X").ToList();
                        }
                        else
                        {
                            stores = jmmdb.Stores.Where(c => c.Stt != "X" &&
                                                    c.Teamid.Contains(this.TeamId.ToString())).ToList();
                        }
                        
                        var staffStores = jmmdb.Storestaffs.Where(c => 
                                                    c.Staffid == this.UserId).ToList();

                        List<mdlMyStore> temp_myStoresMet = new List<mdlMyStore>();
                        List<mdlMyStore> temp_myStores = new List<mdlMyStore>();
                        foreach (var staffStore in staffStores)
                        {
                            var store = stores.Where(c => c.Id == staffStore.Storeid).FirstOrDefault();
                            if(store!=null)
                            {
                                string nearKM = "";
                                double? mater = null;
                                var storeLocation = jmmdb.StoreLocations.Where(c =>
                                                        c.Storeid == store.Id && c.Stt!="X").FirstOrDefault();
                                if (storeLocation != null)
                                {
                                    if (!string.IsNullOrEmpty(storeLocation.Gps))
                                    {
                                        string[] gpss = storeLocation.Gps.Split(',');
                                        double store_lat = double.Parse(gpss[0].Trim());
                                        double store_lng = double.Parse(gpss[1].Trim());
                                        GeoCoordinate store_gps = new GeoCoordinate(store_lat, store_lng);
                                        GeoCoordinate my_gps = new GeoCoordinate(lat, lng);

                                        double distanceBetween = store_gps.GetDistanceTo(my_gps);

                                        mater = distanceBetween;
                                        nearKM = mater.Value.ToString("#,##0.00") + "M";
                                        if (mater > 1000)
                                        {
                                            mater = mater / 1000;
                                            nearKM = mater.Value.ToString("#,##0.00")+"Km";
                                        }
                                    }
                                }

                                if(!string.IsNullOrEmpty(nearKM))
                                {
                                    temp_myStoresMet.Add(new mdlMyStore()
                                    {
                                        Id = store.Id,
                                        StoreCode = store.Storecode,
                                        StoreName = store.Storename,
                                        NearKM = nearKM,
                                        Mater = mater
                                    });
                                }
                                else
                                {
                                    temp_myStores.Add(new mdlMyStore()
                                    {
                                        Id = store.Id,
                                        StoreCode = store.Storecode,
                                        StoreName = store.Storename,
                                        NearKM = nearKM,
                                        Mater = mater
                                    });
                                }
                            }
                        }

                        #region prepare sort data result
                        if (temp_myStoresMet.Count > 0)
                        {
                            foreach (var smet in temp_myStoresMet.OrderBy(o => o.Mater))
                            {
                                myStores.Add(new mdlMyStore()
                                {
                                    Id = smet.Id,
                                    StoreCode = smet.StoreCode,
                                    StoreName = smet.StoreName,
                                    NearKM = smet.NearKM,
                                    Mater = smet.Mater
                                });
                            }
                        }

                        if (temp_myStores.Count > 0)
                        {
                            foreach (var tm_s in temp_myStores.OrderBy(o => o.StoreName))
                            {
                                myStores.Add(new mdlMyStore()
                                {
                                    Id = tm_s.Id,
                                    StoreCode = tm_s.StoreCode,
                                    StoreName = tm_s.StoreName,
                                    NearKM = tm_s.NearKM,
                                    Mater = tm_s.Mater
                                });
                            }
                        }

                        #endregion
                    }
                }

                Res.Results = myStores;
                Res.Message = "SUCCESS";
                Res.Count = myStores.Count;
                Res.Code = HttpStatusCode.OK.ToString();
            }
            catch(Exception ex)
            {
                Res.Code = HttpStatusCode.NotFound.ToString();
                Res.Message = ex.Message;
            }

            return Ok(Res);
        }

    }
}
