using System;
using System.Collections.Generic;
using System.Linq;
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
        public List<Tuple<Customers, Orders>> CustomerOrder()
        {
            DateTime fechaOrden = Convert.ToDateTime("1/1/1997");
            var query = from c in context.Customers
                        join o in context.Orders
                        on c.CustomerID equals o.CustomerID
                        where c.Region == "WA" && o.OrderDate > fechaOrden
                        orderby c.CustomerID
                        select new {c,o};

            return query.AsEnumerable().Select(t => new Tuple<Customers, Orders>(t.c,t.o)).ToList();
        }
        //8
        public IEnumerable<Customers> CustomerRegion3()
        {
            var query = context.Customers.Where(c => c.Region == "WA").Take(3);
            return query.ToList();
        }
        //13
        public List<Tuple<Customers, int>> CustomerOrdersA()
        {
            var query = from c in context.Customers
                        join o in context.Orders
                        on c.CustomerID equals o.CustomerID
                        group c by c.CustomerID into co
                        select new {
                            Customer = co.FirstOrDefault(),
                            Cant = co.Count()};

            return query.AsEnumerable().Select(t => new Tuple<Customers, int>(t.Customer, t.Cant)).ToList();
        }
    }
}
