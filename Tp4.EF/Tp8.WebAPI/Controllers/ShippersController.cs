using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;
using Tp4.EF.Entities;
using Tp4.EF.Logic;
using Tp8.WebAPI.Models;

namespace Tp8.WebAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ShippersController : ApiController
    {
        // GET: Shippers
        ShippersLogic logic = new ShippersLogic();

        public IHttpActionResult GetAll()
        {
            List<Shippers> shippers = logic.GetAll();
            List<ShippersView> shippersViews = shippers.Select(s => new ShippersView{
                id = s.ShipperID,
                name = s.CompanyName,
                phone = s.Phone
            }).ToList();
            if (shippersViews.Count == 0){
                return NotFound();
            }
            return Ok(shippersViews);
        }
        public IHttpActionResult GetId(int id)
        {
            Shippers shippers = logic.GetId(id);
            if (shippers == null){
                return NotFound();
            }
            ShippersView shippersView = new ShippersView{
                id = shippers.ShipperID,
                name = shippers.CompanyName,
                phone = shippers.Phone
            };
            return Ok(shippersView);
        }
        public IHttpActionResult PostInsert(ShippersView shippersView)
        {
            if (!ModelState.IsValid){
                return BadRequest("No se pudo insertar");
            }
            Shippers shippers = new Shippers{
                CompanyName = shippersView.name,
                Phone = shippersView.phone
            };
            logic.Add(shippers);
            return Ok("Se ha agregado exitosamente");
        }
        public IHttpActionResult Edit(ShippersView shippersView)
        {
            if (!ModelState.IsValid){
                return BadRequest("No se pudo editar");
            }
            Shippers shippers = new Shippers{
                ShipperID = shippersView.id,
                CompanyName = shippersView.name,
                Phone = shippersView.phone
            };
            logic.Update(shippers);
            return Ok("Se ha editado exitosamente");
        }
        public IHttpActionResult PostDelete(int id)
        {
            if (id <= 0){
                return BadRequest("Id incorrecto");
            }
            if (!ModelState.IsValid){
                return BadRequest("Ha ocurrido un error");
            }
            logic.Delete(id);
            return Ok("Eliminado exitosamente");
        }
    }
}