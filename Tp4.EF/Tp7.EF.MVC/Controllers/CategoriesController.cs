using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tp4.EF.Logic;

namespace Tp7.EF.MVC.Controllers
{
    public class CategoriesController : Controller
    {
        // GET: Categories
        public ActionResult Index()
        {
            var logic = new CategoriesLogic();
            List<Tp4.EF.Entities.Categories> categories = logic.GetAll();
            return View(categories);
        }
    }
}