using Entities;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace Data
{
   public class DataSrc
    {
        static DataProductsEntities model = new DataProductsEntities();

        public static List<Producto> GetProductos()
        {
            var result = from mod in model.Products select mod ;
            return SerializeJson<IEnumerable<Products>, List<Producto>>(result);
        }
        public static List<Producto> SearchProducts(int id, string name)
        {
            var result = model.ACOB_SearchByIdOrName(id, name);
            return SerializeJson<IEnumerable<ACOB_SearchByIdOrName_Result>, List<Producto>>(result);
        }
        public static List<ProductoInfo> ProductInfo(int id, string name)
        {
            var result = model.ACOB_Search_Inner(id, name);
            return SerializeJson<IEnumerable<ACOB_Search_Inner_Result>, List<ProductoInfo>>(result);
        }

        public static List<Imagen> GetImagen(int id)
        {
            var result = model.ACOB_SelectImages(id);
            return SerializeJson<IEnumerable<ImagesProduct>, List<Imagen>>(result);
        }


        public static Out SerializeJson<In, Out>(In obj)
        {
            string output = JsonConvert.SerializeObject(obj);
            return JsonConvert.DeserializeObject<Out>(output);
        }


      

        

    }
}
