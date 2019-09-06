using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace task1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult MainPage()
        {
            string imgPath = Server.MapPath("~/Content/Image/mobile.jpg");
            byte[] byteData = System.IO.File.ReadAllBytes(imgPath);
            string imgBase64Data = Convert.ToBase64String(byteData);
            string imgDataURL = string.Format("data:image/jpg;base64,{0}", imgBase64Data);
            ViewBag.ImageData = imgDataURL;
            return View();
        }
    }
}