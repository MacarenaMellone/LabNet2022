using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Tp4.EF.Entities;
using Tp4.EF.Logic;
using Tp7.EF.MVC.Models;

namespace Tp7.EF.MVC.Controllers
{
    public class CategoriesController : Controller
    {
        CategoriesLogic logic = new CategoriesLogic();
        // GET: Categories
        public ActionResult Index()
        {
            List<Tp4.EF.Entities.Categories> categories = logic.GetAll();

            List<CategoriesView> categoriesViews = categories.Select(s => new CategoriesView {
                Id = s.CategoryID,
                Name = s.CategoryName
            }).ToList();
            return View(categoriesViews);
        }
        public ActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public ActionResult insert(CategoriesView categoriesView)
        {
            try
            {
                var categoriesEntity = new Categories { CategoryName = categoriesView.Name };

                logic.Add(categoriesEntity);

                return RedirectToAction("Index");    

            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Error");
            }
        }


        public ActionResult Delete(int id)
        {
            try
            {
                logic.Delete(id);
                return RedirectToAction("Index");

            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Error");
            }
            

        }
    }
}