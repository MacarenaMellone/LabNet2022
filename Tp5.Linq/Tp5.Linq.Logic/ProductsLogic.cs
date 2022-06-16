using System.Collections.Generic;
using System.Linq;
using Tp5.Linq.Entities;

namespace Tp5.Linq.Logic
{
    public class ProductsLogic : BaseLogic
    {
        public List<Products> GetAll()
        {
            return context.Products.ToList();
        }

        //2
        public IEnumerable<Products> ProductsStock(){

            var query = context.Products.Where(p => p.UnitsInStock == 0);
            return query.ToList();

        }
        //3
        public List<Products> ProdStockPrice(){

            var query = from p in context.Products
                        where p.UnitsInStock > 0 && p.UnitPrice > 3
                        select p;

            return query.ToList();
        }
        //5
        public Products FirstOrNullProds(){

            var query = context.Products.Where(p => p.ProductID == 789);

            return query.FirstOrDefault();

        }
        //9
        public List<Products> ProductsList(){

            var query = from p in context.Products
                        orderby p.ProductName ascending 
                        select p;

            return query.ToList();
        }
        //10
        public List<Products> ProdsListStock(){

            var query = from p in context.Products
                        orderby p.UnitsInStock descending
                        select p;

            return query.ToList();
        }
        //12
        public Products FirstProduct(){

            var query = from p in context.Products
                        select p;

            return query.First();

        }
    }
}
