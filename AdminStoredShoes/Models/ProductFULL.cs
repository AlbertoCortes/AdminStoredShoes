using System;
using System.Collections.Generic;
using System.Linq;
using Entities;
using System.Web;
using System.Web.Mvc;
using Buissnes;

namespace AdminStoredShoes.Models
{
    public class ProductFULL
    {
        public Producto prod { get; set; }
        public List<Tipo> tipo { get; set; }
        public List<Color> color { get; set; }
        public List<Marca> marca { get; set; }
        public List<Proveedor> proveedor { get; set; }
        public List<Catalago> catalago { get; set; }
    
        public static Boolean InsertProductoModel(FormCollection formCollection)
        {
            try
            {
                Producto p = new Producto
                {
                    IdType = Int32.Parse(formCollection["IdType"]),
                    IdColor = Int32.Parse(formCollection["IdColor"]),
                    IdBrand = Int32.Parse(formCollection["IdBrand"]),
                    IdProvider = Int32.Parse(formCollection["IdProvider"]),
                    IdCatalog = Int32.Parse(formCollection["IdCatalog"]),
                    Title = formCollection["Title"],
                    Nombre = formCollection["Nombre"],
                    Description = formCollection["Description"],
                    Observations = formCollection["Observations"],
                    PriceDistributor = decimal.Parse(formCollection["PriceDistribuitor"]),
                    PriceClient = decimal.Parse(formCollection["PriceClient"]),
                    PriceMember = decimal.Parse(formCollection["PriceMember"]),
                    IsEnabled = true,
                    Keywords = formCollection["keywords"],
                    DateUpdate = DateTime.Now.Date
                };
                BuissnesSrc.InserProduct(p);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public static Boolean UpdateProductoModel(FormCollection formCollection)
        {
            try
            {
                Producto p = new Producto
                {
                    Id = Int32.Parse(formCollection["Id"]),
                    IdType = Int32.Parse(formCollection["IdType"]),
                    IdColor = Int32.Parse(formCollection["IdColor"]),
                    IdBrand = Int32.Parse(formCollection["IdBrand"]),
                    IdProvider = Int32.Parse(formCollection["IdProvider"]),
                    IdCatalog = Int32.Parse(formCollection["IdCatalog"]),
                    Title = formCollection["Title"],
                    Nombre = formCollection["Nombre"],
                    Description = formCollection["Description"],
                    Observations = formCollection["Observations"],
                    PriceDistributor = decimal.Parse(formCollection["PriceDistribuitor"]),
                    PriceClient = decimal.Parse(formCollection["PriceClient"]),
                    PriceMember = decimal.Parse(formCollection["PriceMember"]),
                    IsEnabled = true,
                    Keywords = formCollection["keywords"],
                    DateUpdate = DateTime.Now.Date
                };
                BuissnesSrc.UpdateProduct(p);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
    



}