using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using store.Models;

namespace store.Controllers
{
    
    public class MemberController : Controller
    {
        // GET: Member
        public ActionResult Memb()
        {
            FullonHotelEntities db = new FullonHotelEntities();
            var result = from a in db.Members select a;

            return View(result);
        }
        [HttpPost]
        public ActionResult Memb(string myText)
        {
            HttpUtility.HtmlDecode(myText);
            return View();
        }

        public ActionResult Data(FormCollection fs)
        {
            using (FullonHotelEntities db = new FullonHotelEntities())
            {
                //if (fs != null)
                //{
                //    var q = from s in db.Members
                //            join u in db.Cities
                //            on new {c = s.County}
                //            equals new {c = u.Name}
                             
                //            select new {
                //                s.County = u.Name
                                
                //    };
                //}

               
            }

                
            return View();
        }

        public ActionResult Serach(string Midno_Q)
        {
             //儲存查詢出來的UserId
            string Midno = null;
            using (Models.FullonHotelEntities db = new Models.FullonHotelEntities())
            {   //查詢目前網站使用者暱稱符合Username的UserId
                Midno = (from s in db.Members
                                where s.Midno == Midno_Q
                                select s.ToString()).FirstOrDefault();
}
            //如果有存在UserId
            if (!String.IsNullOrEmpty(Midno))
            {   //則將此UserId的所有訂單找出
                using (Models.FullonHotelEntities db = new Models.FullonHotelEntities())
                {
                    var c = (from s in db.Members
                                
                                  select s).ToList();

                    //回傳 結果 至Index()的View
                    return View("Data", c);
                }
            }
            else
            {   //回傳 空結果 至Index()的View
                return View("Index", new List<Models.Order>());
            }
             
        }



    }
}