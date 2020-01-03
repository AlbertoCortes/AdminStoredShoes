using Entities;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace Data
{
   public class DataSrc
    {
        static DataProductsEntities model = new DataProductsEntities();

        public static List<Productos> GetProductos()
        {
            var result = from mod in model.Products select mod ;
            return SerializeJson<IEnumerable<Products>, List<Productos>>(result);
        }

        public static List<Imagen> GetImagen(int id)
        {
            var result = from mod in model.ImagesProduct where mod.IdImage == id select mod;
            return SerializeJson<IEnumerable<ImagesProduct>, List<Imagen>>(result);
        }


        public static Out SerializeJson<In, Out>(In obj)
        {
            string output = JsonConvert.SerializeObject(obj);
            return JsonConvert.DeserializeObject<Out>(output);
        }


        

    }
}
