using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TerminalApp.Controllers
{
    public class AuditController : Controller
    {
        Models.Entities.LogisticDataBaseEntities1 db = new Models.Entities.LogisticDataBaseEntities1();
        // GET: Audit
        public ActionResult AuditIndex(string message)
        {
            ViewBag.Error = message;
            return View();
        }

        [HttpPost]
        public ActionResult AuditPozitionCheck(string PozitionName)
        {
            string message = "";
            try
            {
                var pozitionCheck = db.Pozition.Where(x => x.PozitionName == PozitionName).FirstOrDefault();
                
                if (pozitionCheck != null)
                {
                    Models.DataTakenFromClient.PozitionName = PozitionName;
                    var sku = db.Sku.Where(x => x.Id == pozitionCheck.SkuId).FirstOrDefault();
                    ViewBag.Sku = sku.Sku1;
                    ViewBag.SkuPiece = pozitionCheck.SkuPiece;
                    ViewBag.SkuType = pozitionCheck.SkuType;
                    
                    return View();
                }

            }
            catch (Exception)
            {
                message = "Hata Oluştu";
                return RedirectToAction("AuditIndex", new { message });
            }
            return RedirectToAction("AuiditIndex");
        }

        public ActionResult PozitionAuditPage(string message)
        {
            
            try
            {                            
                var pozitioncheck = db.Pozition.Where(x => x.PozitionName == Models.DataTakenFromClient.PozitionName).FirstOrDefault();
                pozitioncheck.SkuId = null;
                pozitioncheck.SkuPiece = null;
                pozitioncheck.Availability = "True";
                db.SaveChanges();
                ViewBag.Error = message;
                return View();
            }
            catch (Exception)
            {
                message = "Hata Oluştu";
                return RedirectToAction("AuditIndex", new { message });
            }
        }
        [HttpPost]
        public ActionResult PozitionAudit(int Sku1,int SkuPiece)
        {
            string message = "";
            try
            {
                Models.CommonJobs commonJobs = new Models.CommonJobs();
                var sku = db.Sku.Where(x => x.Sku1 == Sku1).FirstOrDefault();
                var pozition = db.Pozition.Where(x => x.PozitionName == Models.DataTakenFromClient.PozitionName).FirstOrDefault();
                pozition.SkuId = sku.Id;
                pozition.Availability = "False";

                if (SkuPiece > sku.SkuPiece)
                {
                    message = "Depoda Bulunandan Fazla Ürün Giremezsiniz!";
                    return RedirectToAction("PozitionAuditPage", new { message });
                }
                else
                {
                    pozition.SkuPiece = SkuPiece;
                    message = "Audit Tamamlandı.";

                    commonJobs.WorkAdd(Sku1, Models.DataTakenFromClient.PozitionName, "Audit", "GeneralAudit", "Quadrant Yok", Models.DataTakenFromClient.UserCode, Models.DataTakenFromClient.TerminalCode);
                    db.SaveChanges();
                }

                return RedirectToAction("AuditIndex", new { message });
            }
            catch (Exception)
            {
                message = "Hata Oluştu!";
                return RedirectToAction("AuditIndex", new { message });
            }
        }
    }
}


