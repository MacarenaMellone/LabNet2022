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
            List<Categories> categories = logic.GetAll();

            List<CategoriesView> categoriesViews = categories.Select(s => new CategoriesView {
                Id = s.CategoryID,
                Name = s.CategoryName,
                Description = s.Description
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
                var categories = new Categories
                {
                    CategoryName = categoriesView.Name,
                    Description = categoriesView.Description
                };

                logic.Add(categories);

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
        public ActionResult Edit(int id)
        {
            Categories categories = logic.GetId(id);
            CategoriesView categoriesView = new CategoriesView{
                Id = categories.CategoryID,
                Name = categories.CategoryName,
                Description= categories.Description
            };
            return View(categoriesView);

        }

        [HttpPost]
        public ActionResult Edit(CategoriesView categoriesView)
        {
            try
            {
                var categories = new Categories
                {
                    CategoryID = categoriesView.Id,
                    CategoryName = categoriesView.Name,
                    Description = categoriesView.Description
                };
                logic.Update(categories);
                return RedirectToAction("Index");

            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Error");
            }
        }


    }
}