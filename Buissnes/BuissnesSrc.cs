using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Data;

namespace Buissnes
{
    public class BuissnesSrc
    {
        public static List<Producto> GetProductos()
        {
            return DataSrc.GetProductos();
        }

        public static List<Imagen> GetImagenes(int id)
        {
            return DataSrc.GetImagen(id);
        }

         public static List<Producto> SearchProd(int id, string name)
        {
            return DataSrc.SearchProducts(id, name);
        }
    }
}   
