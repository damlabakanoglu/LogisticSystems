using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TerminalApp.Controllers
{
    public class TransferController : Controller
    {
        Models.Entities.LogisticDataBaseEntities1 db = new Models.Entities.LogisticDataBaseEntities1();
              // GET: Transfer
        public ActionResult TransferTypeChoose()
        {
            
            ViewBag.UserCode = Models.DataTakenFromClient.UserCode;
            return View();
        }
        
        public ActionResult Regular(string message)
        {
            ViewBag.Error = message;
            return View();
        }
     
        [HttpPost]
        
        public ActionResult OrderIdCheck(int Id)
        {
            string message = "";
            var commonJobs = new Models.CommonJobs();
           
            try
            {
                var userCode = Models.DataTakenFromClient.UserCode;
                var user = db.Users.Where(x => x.UserCode == userCode).FirstOrDefault();
                Models.DataTakenFromClient.TerminalCode = user.TerminalCode.Value;
                Models.DataTakenFromClient.OrderId = Id;
                var orderIdCheck = db.Order.Where(x => x.Id == Id).FirstOrDefault();
                if(orderIdCheck != null)
                {
                    message = "Sipariş Kargo Aşamasına Aktarıldı";
                    var orderSku = orderIdCheck.OrderSku.Value;
                    orderIdCheck.OrderStatus = "Cargo";
                    db.SaveChanges();
                    commonJobs.WorkAdd(orderSku, "No Pozition", "Shipping", "WaitingForCargo","Quadrant Yok",userCode, Models.DataTakenFromClient.TerminalCode);
                  //  commonJobs.TransferAdd("Regular", DateTime.Now.Date, orderIdCheck.Id);
                    
                }
                else
                {
                    message = "Sipariş Bulunamadı !";
                   
                }
                return RedirectToAction("Regular", new { message });
            }
            catch (Exception)
            {
                message = "Hata Oluştu !";
                return RedirectToAction("Regular",new { message});
            }

           
        }
    }
}