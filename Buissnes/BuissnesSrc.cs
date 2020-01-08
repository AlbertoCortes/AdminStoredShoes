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
        public static void DeleteProduct(int id)
        {
            DataSrc.DeleteProduct(id);
        }

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
        public static List<ProductoInfo> ProductInfo(int id, string name)
        {
            return DataSrc.ProductInfo(id, name);
        }


        public static void UpdateProduct(Producto prod)
        {
            DataSrc.UpdateProduct(prod);
        }

        public static void InserProduct(Producto prod)
        {
            DataSrc.InsertProduct(prod);
        }

        //Buissnes fill selectASP

        public static List<Tipo> SelectTipo()
        {
            return DataSrc.SelectTipo();
        }

        public static List<Color> SelectColor()
        {
            return DataSrc.SelectColor();
        }

        public static List<Marca> SelectMarca()
        {
            return DataSrc.SelectMarca();
        }

        public static List<Proveedor> SelectProveedor()
        {
            return DataSrc.SelectProveedor();
        }

        public static List<Catalago> SelectCatalago()
        {
            return DataSrc.SelectCatalago();
        }
    }
}   
