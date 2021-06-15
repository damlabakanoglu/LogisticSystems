using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TerminalApp.Controllers
{
    public class LoginPageController : Controller
    {
        // GET: LoginPage
        public ActionResult LoginIndex(string message)
        {
            ViewBag.Error = message;
            return View();
        }
        Models.Entities.LogisticDataBaseEntities1 db = new Models.Entities.LogisticDataBaseEntities1();
       

        [HttpPost]
        public ActionResult WorkChoosePage(int userCode)
        {
            string message = "";
            try
            {               
                
                
                var userCheck = db.Users.Where(x => x.UserCode == userCode).FirstOrDefault();
                if (userCheck != null && userCheck.TerminalCode!=0)
                {
                    Models.DataTakenFromClient.UserCode = userCheck.UserCode;
                    Models.DataTakenFromClient.TerminalCode = userCheck.TerminalCode.Value;
                    ViewBag.User = userCheck.Name;
                    return View(userCheck);
                }
                else
                {
                    message = "Kullanıcı Bulunamadı Ya Da Yetkisi Yok !";
                    return RedirectToAction("LoginIndex", new { message });
                }

            }
            catch (Exception )
            {


               message= "Kullanıcı Kodu Hatalı";
                return RedirectToAction("LoginIndex",new { message });

            }

            return RedirectToAction("LoginIndex");
        }
    }
}