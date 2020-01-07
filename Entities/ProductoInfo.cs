using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ProductoInfo
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public string Color { get; set; }
        public string Marca { get; set; }
        public string Proveedor { get; set; }
        public string Catalago { get; set; }
        public string Title { get; set; }
        public string Nombre { get; set; }
        public string Description { get; set; }
        public string Observations { get; set; }
        public decimal? PriceDistributor { get; set; }
        public decimal PriceClient { get; set; }
        public decimal PriceMember { get; set; }
        public bool IsEnabled { get; set; }
        public System.DateTime DateUpdate { get; set; }
    }
}
