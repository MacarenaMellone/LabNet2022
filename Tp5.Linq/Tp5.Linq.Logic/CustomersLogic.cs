using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp5.Linq.Data;
using Tp5.Linq.Entities;

namespace Tp5.Linq.Logic
{
    public class CustomersLogic : BaseLogic
    {
        public List<Customers> GetAll()
        {
            return context.Customers.ToList();
        }
        //1
        public Customers CoustomerObjects(string country)
        {
            var query = context.Customers.Where(c => c.Country == country); 

            return query.FirstOrDefault();  
        }
        //4
        public List<Customers> CustomerRegion()
        {
            var query = from c in context.Customers
                        where c.Region == "WA"
                        select c;

            return query.ToList();
        }
        //6
        public List<Customers> CustomerNombre()
        {
            var query = from c in context.Customers
                        orderby c.CustomerID
                        select c;
            return query.ToList();
        }
        //7
        public List<Customers> CustomerOrder()
        {
            DateTime fechaOrden = Convert.ToDateTime("1/1/1997");
            var query = from c in context.Customers
                        join o in context.Orders
                        on c.CustomerID equals o.CustomerID
                        where c.Region == "WA" && o.OrderDate > fechaOrden
                        orderby c.CustomerID
                        select new Customers
                        { CustomerID = c.CustomerID,
                        Region = c.Region};

            return query.ToList();
        }
        //8
        public IEnumerable<Customers> CustomerRegion3()
        {
            var query = context.Customers.Where(c => c.Region == "WA").Take(3);
            return query.ToList();
        }
        //13

    }

}
