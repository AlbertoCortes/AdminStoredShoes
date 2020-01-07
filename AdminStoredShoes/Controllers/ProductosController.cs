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

    
        public ActionResult _viewProduct(int id)
        {
            ProductoInfo prod = BuissnesSrc.ProductInfo(id, "%%").FirstOrDefault();
            List<Imagen> imagenes = BuissnesSrc.GetImagenes(id);
            var data = new Tuple<ProductoInfo, List<Imagen>>(prod, imagenes); 
            return View(data);
        }

        public ActionResult _editProduct(int id)
        {
            Producto prod = BuissnesSrc.SearchProd(id,"%%").FirstOrDefault();
            return View(prod);
        }
       

    }

}