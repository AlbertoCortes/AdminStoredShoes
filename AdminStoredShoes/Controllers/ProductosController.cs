using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Entities;
using Buissnes;

namespace AdminStoredShoes.Controllers
{
    public class ProductosController : Controller
    {
        // GET: Productos
        public ActionResult Index()
        {
            List<Producto> prod = BuissnesSrc.SearchProd(0, "%%");
            return View(prod);
        }
        
    }
}