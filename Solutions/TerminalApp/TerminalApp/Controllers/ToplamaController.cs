using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TerminalApp.Controllers
{
    public class ToplamaController : Controller
    {
        Models.Entities.LogisticDataBaseEntities1 db = new Models.Entities.LogisticDataBaseEntities1();
        
        // GET: Toplama
        public ActionResult PickingChoosePage()
        {
           
            return View();
        }
       

        public ActionResult QuadrantCheckPage(string message)
        {
            ViewBag.Error = message;
            return View();
        }

        [HttpPost]
        public ActionResult QuadrantPage(string Quadrant,string message)
        {
                    
            try
            {

                Models.DataTakenFromClient.Quadrant = Quadrant;

                var QuadrantList1 = db.Order.Where(x => x.Quadrant == Quadrant).ToList();
                var QuadrantList = QuadrantList1.Where(x => x.OrderStatus == "Picking").ToList();
                var orderSkuTypeClothes = QuadrantList.Where(x => x.Sku.SkuType == "Kıyafet").ToList();
                var clothesCount = orderSkuTypeClothes.Count();
                var orderSkuTypeShoes = QuadrantList.Where(x => x.Sku.SkuType == "Ayakkabı").ToList();
                var shoesCount = orderSkuTypeShoes.Count();
                var orderSkuTypeJewelry = QuadrantList.Where(x => x.Sku.SkuType == "Takı").ToList();
                var jewelryCount = orderSkuTypeJewelry.Count();
                if (QuadrantList != null)
                {
                    if (QuadrantList.Count == 0)
                    {
                        message = "Quadrant Tamamlandı";
                        return RedirectToAction("QuadrantCheckPage", new { message });
                    }
                    else
                    {
                        Models.DataTakenFromClient.ListByQuadrant = QuadrantList.ToList();
                        Models.DataTakenFromClient.ClothesOrderByQuadrant = orderSkuTypeClothes;
                        Models.DataTakenFromClient.ShoesOrderByQuadrant = orderSkuTypeShoes;
                        Models.DataTakenFromClient.JeweleriesOrderByQuadrant = orderSkuTypeJewelry;
                        ViewBag.ClothesCount = clothesCount;
                        ViewBag.ShoesCount = shoesCount;
                        ViewBag.JewelryCount = jewelryCount;
                        ViewBag.QuadrantList = QuadrantList;
                        ViewBag.Error = message;
                        return View();
                    }
                }
                
                else message = "Quadrant Bulunamadı !";

            }
            catch (Exception)
            {
                message = "Hata Oluştu !";
                return RedirectToAction("QuadrantCheckPage",new { message});
            }
            return RedirectToAction("QuadrantCheckPage",new {message });
        }

        public ActionResult Clothes(string message)
        {
            ViewBag.Error = message;
            try
            {
                if (Models.DataTakenFromClient.ClothesOrderByQuadrant.Count == 0)
                {
                    message = "Bu Sku Türünde Sipariş Bulunamadı !";
                    return RedirectToAction("QuadrantCheckPage", new { message });
                }
                foreach (var item in Models.DataTakenFromClient.ClothesOrderByQuadrant)
                {
                    var pozition = db.Pozition.Where(x => x.SkuId == item.SkuId).FirstOrDefault();
                    
                    if (pozition != null)
                    {
                       
                        var pozitionList = new List<Models.PozitionByQuadrant>();
                        var pozitionListItem = new Models.PozitionByQuadrant()
                        { PozitionNameByQuadrant = pozition.PozitionName,
                            SkuIdByQuadrant = pozition.SkuId.Value,
                            Availability = pozition.Availability                   
                        };
                            pozitionList.Add(pozitionListItem);
                        Models.DataTakenFromClient.PozitionByQuadrantList = pozitionList;
                        ViewBag.Pozition = pozitionListItem.PozitionNameByQuadrant;
                       
                    }
                    

                }
                
            }
            catch (Exception)
            {

                return View();
            }
          
           

            return View();
        }
        public ActionResult Shoes(string message)
        {
            ViewBag.Error = message;
            try
            {
                if (Models.DataTakenFromClient.ShoesOrderByQuadrant.Count == 0)
                {
                    message = "Bu Sku Türünde Sipariş Bulunamadı !";
                    return RedirectToAction("QuadrantCheckPage", new { message });
                }
                foreach (var item in Models.DataTakenFromClient.ShoesOrderByQuadrant)
                {
                    var pozition = db.Pozition.Where(x => x.SkuId == item.SkuId).FirstOrDefault();

                    if (pozition != null)
                    {
                        var pozitionList = new List<Models.PozitionByQuadrant>();
                        var pozitionListItem = new Models.PozitionByQuadrant()
                        {
                            PozitionNameByQuadrant = pozition.PozitionName,
                            SkuIdByQuadrant = pozition.SkuId.Value,
                            Availability = pozition.Availability
                        };
                        pozitionList.Add(pozitionListItem);
                        Models.DataTakenFromClient.PozitionByQuadrantList = pozitionList;
                        ViewBag.Pozition = pozitionListItem.PozitionNameByQuadrant;

                    }
                    else
                    {
                        message = "Sku Bulunamadı !";
                        return RedirectToAction("QuadrantPage", new { message });
                    }
                }
            }
            catch (Exception)
            {

                return View();
            }



            return View();
        }
        public ActionResult Jeweleries(string message)
        {
            ViewBag.Error = message;
            try
            {
                if (Models.DataTakenFromClient.JeweleriesOrderByQuadrant.Count == 0)
                {
                    message = "Bu Sku Türünde Sipariş Bulunamadı !";
                    return RedirectToAction("QuadrantCheckPage",new {message });
                }
                foreach (var item in Models.DataTakenFromClient.JeweleriesOrderByQuadrant)
                {
                    var pozition = db.Pozition.Where(x => x.SkuId == item.SkuId).FirstOrDefault();

                    if (pozition != null)
                    {
                        var pozitionList = new List<Models.PozitionByQuadrant>();
                        var pozitionListItem = new Models.PozitionByQuadrant()
                        {
                            PozitionNameByQuadrant = pozition.PozitionName,
                            SkuIdByQuadrant = pozition.SkuId.Value,
                            Availability = pozition.Availability
                        };
                        pozitionList.Add(pozitionListItem);
                        Models.DataTakenFromClient.PozitionByQuadrantList = pozitionList;
                        ViewBag.Pozition = pozitionListItem.PozitionNameByQuadrant;

                    }
                   
                }
            }
            catch (Exception)
            {

                return View();
            }



            return View();
        }

        [HttpPost]
        public ActionResult PickByQuadrantPozition(string PozitionName)
        {
            string PageName = "";
            string message = "";

            try
            {
                var pozitionSearch = db.Pozition.Where(x => x.PozitionName == PozitionName).FirstOrDefault();
                if (pozitionSearch != null)
                {
                    int skuType = pozitionSearch.SkuType1.Id;
                    if (skuType == 1) { PageName = "Shoes"; Models.DataTakenFromClient.SkuTypeId = 1; }
                    else if (skuType == 2) { PageName = "Clothes"; Models.DataTakenFromClient.SkuTypeId = 2; }
                    else { PageName = "Jeweleries"; Models.DataTakenFromClient.SkuTypeId = 3; }
                    var checkPozitionInQuadrantList = Models.DataTakenFromClient.PozitionByQuadrantList.Where(x => x.PozitionNameByQuadrant == pozitionSearch.PozitionName).FirstOrDefault();
                        if (checkPozitionInQuadrantList != null && checkPozitionInQuadrantList.Availability != "True")
                    {
                        string pozitionName = checkPozitionInQuadrantList.PozitionNameByQuadrant;
                        var sku = db.Sku.Where(x => x.Id == checkPozitionInQuadrantList.SkuIdByQuadrant).FirstOrDefault();
                        ViewBag.Sku = sku.Sku1;
                        return View();
                    }
                }
                
            }
            catch (Exception)
            {
                message = "Hata Oluştu !";
                return RedirectToAction(PageName,new { message });
            }
            return RedirectToAction(PageName, new { message });
        }


        [HttpPost]
        public ActionResult PickSku(int OrderSku,string PozitionName)
        {
            string message = "";
            try
            {
                var skuExistCheck = db.Order.Where(x => x.OrderSku == OrderSku).FirstOrDefault();
                
                if (Models.DataTakenFromClient.SkuTypeId == 2)
                {
                    skuExistCheck = Models.DataTakenFromClient.ClothesOrderByQuadrant.Where(x => x.OrderSku == OrderSku).FirstOrDefault();
                }
                else if (Models.DataTakenFromClient.SkuTypeId == 1)
                {
                    skuExistCheck = Models.DataTakenFromClient.ShoesOrderByQuadrant.Where(x => x.OrderSku == OrderSku).FirstOrDefault();
                }
                else
                {
                    skuExistCheck = Models.DataTakenFromClient.JeweleriesOrderByQuadrant.Where(x => x.OrderSku == OrderSku).FirstOrDefault();
                }
                var orderStatusChange = db.Order.Where(x => x.OrderSku == skuExistCheck.OrderSku).FirstOrDefault();
                if (skuExistCheck != null)
                {
                    Models.CommonJobs commonJobs = new Models.CommonJobs();
                    var pozition = Models.DataTakenFromClient.PozitionByQuadrantList.Where(x => x.SkuIdByQuadrant == skuExistCheck.SkuId).FirstOrDefault();

                    commonJobs.PickingJob(OrderSku);
                    commonJobs.WorkAdd(OrderSku, pozition.PozitionNameByQuadrant, "Picking", "GuideByQuadrant", Models.DataTakenFromClient.Quadrant, Models.DataTakenFromClient.UserCode, Models.DataTakenFromClient.TerminalCode);
                    Models.DataTakenFromClient.PozitionByQuadrantList.Remove(pozition);
                    orderStatusChange.OrderStatus = "Packing";
                    db.SaveChanges();
                }
                message = "Sku Toplandı";
                return RedirectToAction("QuadrantCheckPage", new { message});

            }
            catch (Exception)
            {

                return RedirectToAction("PickByQuadrantPozition");
            }
           
        }

        public ActionResult FreePickPage(string message)
        {
            ViewBag.Error = message;
            return View();
        }
        [HttpPost]
        public ActionResult PozitionCheck(string PozitionName,string message)
        {
            
            try
            {
                var pozitionCheck = db.Pozition.Where(x => x.PozitionName == PozitionName).FirstOrDefault();
                if (pozitionCheck != null)
                {
                    Models.DataTakenFromClient.PozitionName = pozitionCheck.PozitionName;
                   return View();
                }
                else
                {
                    message = "Geçersiz Pozisyon !";
                    return RedirectToAction("FreePickPage", new { message });
                }

            }
            catch (Exception)
            {
                message = "Hata Oluştu";
                return RedirectToAction("FreePickPage",new {message });
            }
           
        }
        [HttpPost]
        public ActionResult SkuCheckPage(int Sku1)
        {
            string message = "";
            
            try
            {
                Models.CommonJobs commonJobs = new Models.CommonJobs();
                commonJobs.PickingJob(Sku1);
                commonJobs.WorkAdd(Sku1, Models.DataTakenFromClient.PozitionName, "Picking", "FreePick", "Quadrant Yok", Models.DataTakenFromClient.UserCode, Models.DataTakenFromClient.TerminalCode);
                if (commonJobs.message != null)
                   message = commonJobs.message;
                else  message = "Sku Toplandı";
                return RedirectToAction("FreePickPage",new {message });
            }
            catch (Exception)
            {
                message = "Hata oluştu !";
                return RedirectToAction("PozitionCheck",new {message });
            }
           
        }
        
    }
}