using System;
using System.Collections.Generic;
using System.Linq;
using Tp4.EF.Common;
using Tp4.EF.Entities;

namespace Tp4.EF.Logic
{
    public class CategoriesLogic : BaseLogic, ILogic<Categories>
    {
        public List<Categories> GetAll(){
            return context.Categories.ToList();
        }
        public void Add(Categories newCategories){
            context.Categories.Add(newCategories);
            context.SaveChanges();
        }
        public void Delete(int id){
            var categoriesAEliminar = context.Categories.Find(id);
            context.Categories.Remove(categoriesAEliminar);
            context.SaveChanges();    
        }
        public void Update(Categories categories){
            var categoriesUpdate = context.Categories.Find(categories.CategoryID);
            categoriesUpdate.CategoryName = categories.CategoryName;
            categoriesUpdate.Description = categories.Description;
            context.SaveChanges();
        }
    }
}
