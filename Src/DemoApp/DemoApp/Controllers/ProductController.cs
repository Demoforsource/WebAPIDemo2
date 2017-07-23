using BusinessEntities;
using BusinessServices;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using System.Web.Script.Serialization;

namespace DemoApp.Controllers
{

    public class ProductController : ApiController
    {
        private readonly IProductServices _productServices;

        #region Public Constructor

        /// <summary>
        /// Public constructor to initialize product service instance
        /// </summary>
        public ProductController()
        {
            _productServices = new ProductServices();
        }

        #endregion


        public HttpResponseMessage Get()
        {
            var products = _productServices.GetAllProducts();
            if (products != null)
            {
                var customwrapper = new Wrapper();
                customwrapper.parameters = products;
                var json = JsonConvert.SerializeObject(customwrapper);

                var response = Request.CreateResponse(HttpStatusCode.OK);
                response.Content = new StringContent(json, Encoding.UTF8, "application/json");
                response.StatusCode = HttpStatusCode.OK;
                return response;
              
            }
            return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Products not found");
        }


        public HttpResponseMessage Get(int id)
        {
            var product = _productServices.GetProductById(id);
            if (product !=null && product.Count()>0)
            {
                var customwrapper = new Wrapper();
                customwrapper.parameters = product;
                var json = JsonConvert.SerializeObject(customwrapper);
                var response = Request.CreateResponse(HttpStatusCode.OK);
                response.Content = new StringContent(json, Encoding.UTF8, "application/json");
                response.StatusCode = HttpStatusCode.OK;
                return response;
            }
            return Request.CreateErrorResponse(HttpStatusCode.NotFound, "No product found for this id");
        }

        public HttpResponseMessage Post(ProductEntity productEntity)
        {
            var product = _productServices.CreateProduct(productEntity);
            if (product > 0)
            {
                var customwrapper = new Wrapper();
                customwrapper.parameters = product;
                var json = JsonConvert.SerializeObject(customwrapper);
                var response = Request.CreateResponse(HttpStatusCode.OK);
                response.Content = new StringContent(json, Encoding.UTF8, "application/json");
                response.StatusCode = HttpStatusCode.Created;
                return response;
            }
            return Request.CreateErrorResponse(HttpStatusCode.NotModified, "No product created for this id");

         
        }

        // PUT api/product/5
        public HttpResponseMessage Put(int id, ProductEntity productEntity)
        {
            bool product = _productServices.UpdateProduct(id, productEntity);
            if (product )
            {
                var customwrapper = new Wrapper();
                customwrapper.parameters = product;
                var json = JsonConvert.SerializeObject(customwrapper);
                var response = Request.CreateResponse(HttpStatusCode.OK);
                response.Content = new StringContent(json, Encoding.UTF8, "application/json");
                response.StatusCode = HttpStatusCode.Moved;
                return response;
            }
            return Request.CreateErrorResponse(HttpStatusCode.NotModified, "Procut not updated");
            
        }

        public HttpResponseMessage Delete(int id)
        {
            if (id > 0)
            {
                bool product = _productServices.DeleteProduct(id);
                if (product)
                {
                    var customwrapper = new Wrapper();
                    customwrapper.parameters = product;
                    var json = JsonConvert.SerializeObject(customwrapper);
                    var response = Request.CreateResponse(HttpStatusCode.OK);
                    response.Content = new StringContent(json, Encoding.UTF8, "application/json");
                    response.StatusCode = HttpStatusCode.OK;
                    return response;
                }
            }
            return Request.CreateErrorResponse(HttpStatusCode.NotModified, "Product not found");
           
        }
    }
}

