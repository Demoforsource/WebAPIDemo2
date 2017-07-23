using System.Collections.Generic;
using System.Linq;
using System.Transactions;
using AutoMapper;
using BusinessEntities;
using DataModels;

namespace BusinessServices
{
    /// <summary>
    /// Offers services for product specific CRUD operations
    /// </summary>
    public class ProductServices : IProductServices
    {
        List<ProductEntity> products;


        /// <summary>
        /// Public constructor.
        /// </summary>
        public ProductServices()
        {
            products = DataModels.ProductsDataModel.GetProducts().ToList();
        }
        public ProductServices(List<ProductEntity> repoProducts)
        {
            products = repoProducts;
        }
        /// <summary>
        /// Fetches product details by id
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        public IEnumerable<ProductEntity> GetProductById(int productId)
        {
            IEnumerable<ProductEntity> productbyid = products.Where(o => o.ProductId == productId);
            return productbyid;
        }

        /// <summary>
        /// Fetches all the products.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<ProductEntity> GetAllProducts()
        {
            return products;
        }

        /// <summary>
        /// Creates a product
        /// </summary>
        /// <param name="productEntity"></param>
        /// <returns></returns>
        public int CreateProduct(BusinessEntities.ProductEntity productEntity)
        {
            products.Add(productEntity);
            return products.Count();
        }

        /// <summary>
        /// Updates a product
        /// </summary>
        /// <param name="productId"></param>
        /// <param name="productEntity"></param>
        /// <returns></returns>
        public bool UpdateProduct(int productId, BusinessEntities.ProductEntity productEntity)
        {
            var success = false;

            products.Where(o => o.ProductId == productId).Select(o => o.ProductName = productEntity.ProductName);

            return success;
        }

        /// <summary>
        /// Deletes a particular product
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        public bool DeleteProduct(int productId)
        {
            var success = false;
            if (productId > 0)
            {
                IEnumerable<ProductEntity> product = products.Where(o => o.ProductId == productId);

                products.Remove(product.First());
            }
            return success;
        }
    }
}
