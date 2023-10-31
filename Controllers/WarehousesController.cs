using Microsoft.AspNetCore.Mvc;
using RestfulAPI.Models;
using RestfulAPI.Utils;

namespace WebApplication3.Controllers
{
    public class WarehousesController : Controller
    {
        [Route("/warehouses")]
        [HttpGet]
        public ActionResult<List<Warehouse>> list1()
        {
            return Database.Context.Warehouses.ToList();
        }
    }
}
