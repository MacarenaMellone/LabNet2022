using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tp4.EF.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp4.EF.Entities;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Moq;

namespace Tp4.EF.UI.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        public class NorthwindContext : DbContext
        {
            public virtual DbSet<Categories> Categories { get; set; }
            public virtual DbSet<Shippers> Shippers { get; set; }
        }
        public class Categories
        {
            public int Id { get; set; } 
            public string CategoryName { get; set; }  
            public string Description { get; set; }

            public virtual List<Categories> Categories { get; set; }
        }

        [TestMethod()]
        public void AddCategoriesTest()
        {
            var data = new List<Categories>
            {
                new Categories { Id = 1, CategoryName = "Alguna", Description = "Alguna Cosa"},
                new Categories { Id = 2, CategoryName = "Algo", Description = "Algo Largo"},
            }.AsQueryable();

            var mockSet = new Mock<DbSet<Categories>>();
            mockSet.As<IDbAsyncEnumerable<Categories>>()
                .Setup(m => m.GetAsyncEnumerator())
                .Returns(new TestDbAsyncEnumerator<Categories>(data.GetEnumerator()));
            Assert.Fail();
        }
    }
}