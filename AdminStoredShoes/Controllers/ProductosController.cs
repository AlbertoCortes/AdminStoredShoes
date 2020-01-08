using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Entities;
using Buissnes;
using AdminStoredShoes.Models;

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
            ProductFULL producto = new ProductFULL {
             prod = BuissnesSrc.SearchProd(id,null).FirstOrDefault(),
             tipo = BuissnesSrc.SelectTipo(),
             color = BuissnesSrc.SelectColor(),
             marca = BuissnesSrc.SelectMarca(),
             proveedor = BuissnesSrc.SelectProveedor(),
             catalago = BuissnesSrc.SelectCatalago()
        };
            return View(producto);
        }

        public ActionResult _uploadProduct( FormCollection formCollection)
        {
            bool status = ProductFULL.UpdateProductoModel(formCollection);
            if (status)
            {
                TempData["SuccessUpdate"] = "true";
            }
            else
            {
                TempData["SuccessUpdate"] = "false";
            }
            return RedirectToAction("Index");
        }

        public ActionResult _insertProduct()
        {
            ProductFULL producto = new ProductFULL
            {
                tipo = BuissnesSrc.SelectTipo(),
                color = BuissnesSrc.SelectColor(),
                marca = BuissnesSrc.SelectMarca(),
                proveedor = BuissnesSrc.SelectProveedor(),
                catalago = BuissnesSrc.SelectCatalago()
            };
            return View(producto);
        }




        public ActionResult _insertProductAction(FormCollection formCollection)
        {
            bool status = ProductFULL.InsertProductoModel(formCollection);
            if (status)
            {
                TempData["SuccessInsert"] = "true";
            }
            else
            {
                TempData["SuccessInsert"] = "false";
            }
            return RedirectToAction("Index");
        }

        public ActionResult _searchProduct(FormCollection formCollection)
        {
            int nuid;
            try
            {
                nuid = Int32.Parse(formCollection["buscar"]);
            }
            catch
            {
                nuid = 0;
            }
            
            string buscar = formCollection["buscar"];
            int i = 0;
            List<Producto> prod = BuissnesSrc.SearchProd(nuid, "%"+buscar+"%");
            return View("Index",prod);
        }


        public ActionResult _deleteProduct(int id)
        {
            BuissnesSrc.DeleteProduct(id);
            return RedirectToAction("Index");
        }

    }

}