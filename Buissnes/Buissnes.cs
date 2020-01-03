using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Data;

namespace Buissnes
{
    public class Buissnes
    {
        public static List<Productos> GetProductos()
        {
            return DataSrc.GetProductos();
        }

        public static List<Imagen> GetImagenes(int id)
        {
            return DataSrc.GetImagen(id);
        }

    }
}   
