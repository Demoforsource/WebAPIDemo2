using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModels
{
    public class ProductsDataModel
    {
        public static IEnumerable<ProductEntity> GetProducts()
        {

            List<ProductEntity> products = new List<ProductEntity>();

            products.Add(new ProductEntity() { ProductId = 1001, ProductName = "Product 1" });
            products.Add(new ProductEntity() { ProductId = 1002, ProductName = "Product 2" });
            products.Add(new ProductEntity() { ProductId = 1003, ProductName = "Product 3" });
            return products;

        }
    }
}
