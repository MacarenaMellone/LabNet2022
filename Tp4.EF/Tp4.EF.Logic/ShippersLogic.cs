using System.Collections.Generic;
using System.Linq;
using Tp4.EF.Entities;

namespace Tp4.EF.Logic
{
    public class ShippersLogic : BaseLogic, ILogic<Shippers>
    {
        public List<Shippers> GetAll(){ 
            return context.Shippers.ToList();
        }
        public void Add(Shippers newShipper){ 
            context.Shippers.Add(newShipper);
            context.SaveChanges();
        }
        public void Delete(int id){
            var shipperAEliminar = context.Shippers.Find(id);
            if (shipperAEliminar != null){
                context.Shippers.Remove(shipperAEliminar);
                context.SaveChanges();
            }
        }
        public void Update(Shippers shippers){
            var shippersUpdate = context.Shippers.Find(shippers.ShipperID);
            shippersUpdate.CompanyName = shippers.CompanyName;
            shippersUpdate.Phone = shippers.Phone;
            context.SaveChanges();
        }
        public Shippers GetId(int id)
        {
            return context.Shippers.Find(id);
        }
    }
}
