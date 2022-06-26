using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tp8.WebAPI.Controllers
{
    public class MiauController : Controller
    {
        // GET: Miau
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Cat()
        {
            return Redirect("https://cataas.com/cat");
        }
        public ActionResult CatSaysHi()
        {
            return Redirect("https://cataas.com/cat/says/Holi?size=:size&");
        }
        public ActionResult CatGif()
        {
            return Redirect("https://cataas.com/cat/gif");
        }
        public ActionResult CatGifSaysHi()
        {
            return Redirect("https://cataas.com/c/gif/s/Holis?fi=sepia&c=orange&s=40&t=or");
        }

    }
}