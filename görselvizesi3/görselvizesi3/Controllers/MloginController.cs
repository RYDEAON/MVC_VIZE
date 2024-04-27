using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace görselvizesi3.Controllers
{
	public class MloginController : Controller
	{
		public ActionResult Index()
		{
			// Kullanıcı girişi kontrolü
			if (Session["Yetki"] != null)
			{
				return View();
			}
			else
			{
				return RedirectToAction("Giris");
			}
		}

		   public ActionResult Giris()
            {
                return View();
            }

            [HttpPost]
            public ActionResult Giris(FormCollection fc)
            {
                string kullaniciAdi = fc["kullaniciAdi"];
                string sifre = fc["sifre"];

                // Örnek kullanıcı adı ve şifre kontrolü
                if (kullaniciAdi == "User" && sifre == "Pass")
                {
                    Session["Yetki"] = kullaniciAdi;
                    return RedirectToAction("Index", "Yetkili");
                }
                else
                {
                    ViewBag.ErrorMessage = "Geçersiz kullanıcı adı veya şifre!";
                    return View();
                }
            }
	}
}