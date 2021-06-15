using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TerminalApp.Controllers
{
    public class InboundController : Controller
    { 
        Models.Entities.LogisticDataBaseEntities1 db =new Models.Entities.LogisticDataBaseEntities1();
       
        // GET: Inbound
        public ActionResult InboundIndex(string message)
        {
            ViewBag.Error = message;
            return View();
        }
        [HttpPost]
        public ActionResult ConteynerIdCheck(int InboundConteynerId,string message)
        {
           
            try
            {
                var ConteynerIdCheck = db.Inbound.Where(x => x.InboundConteynerId == InboundConteynerId).FirstOrDefault();
                if(ConteynerIdCheck!=null)
                {
                    Models.DataTakenFromClient.ConteynerId = InboundConteynerId;
                    ViewBag.ConteynerList = ConteynerIdCheck;
                    ViewBag.Error = message;
                    return View();
                }
                else
                {
                    message = "Geçersiz Conteyner Kodu !";
                    return RedirectToAction("InboundIndex", new { message });
                }
            }
            catch (Exception)
            {
                message = "Hata Oluştu !";
                return RedirectToAction("InboundIndex",new { message});
            }
            ViewBag.Error = message;
            return View();
        }

        [HttpPost]
        public ActionResult PlaceToPozition(string pozitionName)
        {
            string message = "";
            try
            {
                Models.DataTakenFromClient.PozitionName = pozitionName;
                var PozitionCheck = db.Pozition.Where(x => x.PozitionName == pozitionName).FirstOrDefault();
                if(PozitionCheck!=null && PozitionCheck.Availability=="True")
                {
                  return View();
                }
                else
                {
                    message = "Geçersiz Pozisyon ya da Pozisyon Dolu!";
                    return RedirectToAction("InboundIndex", new { message });
                }
            }
            catch (Exception)
            {
                message = "Hata Oluştu";
                return RedirectToAction("InboundIndex", new {message});
            }
           
        }

        [HttpPost]
        public ActionResult PlaceSku(int Sku1,int SkuPiece)
        {
            string message = "";
            try
            {

                Models.CommonJobs commonJobs = new Models.CommonJobs();
                var skuList = db.Sku.Where(x => x.Sku1 == Sku1).FirstOrDefault();
                var skuCheck = db.Inbound.Where(x => x.SkuId == skuList.Id).FirstOrDefault();
                if (skuCheck != null && skuCheck.SkuPiece>=SkuPiece)
                {
                    var pozitionUpdate = db.Pozition.Where(x => x.PozitionName == Models.DataTakenFromClient.PozitionName).FirstOrDefault();
                    pozitionUpdate.Availability = "False";
                    pozitionUpdate.SkuId = skuCheck.SkuId;
                    pozitionUpdate.SkuPiece = SkuPiece;
                    var ınbound = db.Inbound.Where(x => x.InboundConteynerId == Models.DataTakenFromClient.ConteynerId).FirstOrDefault();
                    ınbound.SkuPiece = ınbound.SkuPiece - SkuPiece;
                    skuList.SkuPiece = skuList.SkuPiece + SkuPiece;
                    commonJobs.WorkAdd(skuCheck.Sku.Sku1, Models.DataTakenFromClient.PozitionName, "Inbound", "InboundPlace", "Quadrant Yok", Models.DataTakenFromClient.UserCode, Models.DataTakenFromClient.TerminalCode);
                    if (ınbound.SkuPiece == 0) db.Inbound.Remove(ınbound);
                    db.SaveChanges();
                    message = "Sku Pozisyona Yerleştirildi.";
                    return RedirectToAction("InboundIndex", new { message });
                }
                else
                {
                    message = "Geçersiz Sku ya da Conteyner içinde bulunandan fazla ürün girmeye çalıştınız !";
                    return RedirectToAction("InboundIndex", new { message });
                }

            }
            catch (Exception )
            {
                message = "Hata Oluştu !";
                return RedirectToAction("InboundIndex",new { message });
            }
            return RedirectToAction("InboundIndex",new {message});
        }
    }
}