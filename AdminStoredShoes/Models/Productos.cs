using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Buissnes;
using Entities;
namespace AdminStoredShoes.Models
{
    public class Productos
    {
        public int Id { get; set; }
        public int IdType { get; set; }
        public int IdProvider { get; set; }
        public int IdCatalog { get; set; }
        public string Title { get; set; }
        public string Nombre { get; set; }
        public string Description { get; set; }
        public string Observations { get; set; }
        public decimal PriceDistributor { get; set; }
        public decimal PriceClient { get; set; }
        public decimal PriceMember { get; set; }
        public bool IsEnabled { get; set; }
        public string Keywords { get; set; }
        public DateTime DateUpdate { get; set; }
    }

   // static List<Producto> product = BuissnesSrc.GetProductos();
}