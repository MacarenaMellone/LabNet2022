using System;
using System.Collections.Generic;
using System.Linq;
using Tp5.Linq.Entities;

namespace Tp5.Linq.Logic
{
    public class CategoriesLogic : BaseLogic
    {
        public List<Categories> GetAll()
        {
            return context.Categories.ToList();
        }
        
        public List<Categories> CategoriesProd(){
             
            var query = context.Categories
                .Join(context.Products,
                      c => c.CategoryID,
                      p => p.CategoryID,
                      (c, p) => c);

            return query.ToList();  
        }
    }
}
