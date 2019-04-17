using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using store.Models;
using store.Models.ViewModel;

namespace store.Controllers
{
    public class BackendController : Controller
    {
        // GET: Backend
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login( LoginViewModel login)
        {
            using (FullonHotelEntities db = new FullonHotelEntities())
            {
                var v = db.Employees.Where(e => e.Account == login.Account).FirstOrDefault();
                if (v != null )
                {
                    if (string.Compare(Crypto.Hash(login.Password), v.password) == 0)
                    {
                        Session["customer"] = login.Account;
                        return RedirectToAction("Index", "Backend");
                    }
                   
                       
                      
                    
                }
            }
            return View();
        }


    }
}