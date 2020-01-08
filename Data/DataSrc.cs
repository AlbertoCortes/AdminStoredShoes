using Entities;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace Data
{
   public class DataSrc
    {
        static DataProductsEntities model = new DataProductsEntities();
        public static void DeleteProduct(int id)
        {
            model.ACOB_Delete(id);
        }

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


        public static void UpdateProduct(Producto prod)
        {
            model.ACOB_UpdateProduct(
                prod.Id,
                prod.IdType,
                prod.IdColor,
                prod.IdBrand,
                prod.IdProvider,
                prod.IdCatalog,
                prod.Title,
                prod.Nombre,
                prod.Description,
                prod.Observations,
                prod.PriceDistributor,
                prod.PriceClient,
                prod.PriceMember,
                prod.IsEnabled,
                prod.Keywords,
                prod.DateUpdate
                );
        }

        public static void InsertProduct(Producto prod)
        {
            model.ACOB_InsertProduct(
                prod.IdType,
                prod.IdColor,
                prod.IdBrand,
                prod.IdProvider,
                prod.IdCatalog,
                prod.Title,
                prod.Nombre,
                prod.Description,
                prod.Observations,
                prod.PriceDistributor,
                prod.PriceClient,
                prod.PriceMember,
                prod.IsEnabled,
                prod.Keywords,
                prod.DateUpdate
                );
        }


        //select data to fill selectASP


        public static List<Tipo> SelectTipo()
        {
            var result = model.ACOB_SelectType();
            return SerializeJson<IEnumerable<ACOB_SelectType_Result>, List<Tipo>>(result);
        }

        public static List<Color> SelectColor()
        {
            var result = model.ACOB_SelectColor();
            return SerializeJson<IEnumerable<ACOB_SelectColor_Result>, List<Color>>(result);
        }

        public static List<Marca> SelectMarca()
        {
            var result = model.ACOB_SelectBrand();
            return SerializeJson<IEnumerable<ACOB_SelectBrand_Result>, List<Marca>>(result);
        }
        public static List<Proveedor> SelectProveedor()
        {
            var result = model.ACOB_SelectProvider();
            return SerializeJson<IEnumerable<ACOB_SelectProvider_Result>, List<Proveedor>>(result);
        }
        public static List<Catalago> SelectCatalago()
        {
            var result = model.ACOB_SelectCatalog();
            return SerializeJson<IEnumerable<ACOB_SelectCatalog_Result>, List<Catalago>>(result);
        }
        

    }
}
