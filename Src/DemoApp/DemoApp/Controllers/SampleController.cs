using BusinessServices;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;

namespace DemoApp.Controllers
{
   
    public class SampleController : ApiController
    {
       
        public HttpResponseMessage Get()
        {
            string message= "Hello World";

            var customwrapper = new Wrapper();
            customwrapper.parameters = message;
            var json = JsonConvert.SerializeObject(customwrapper);
            var response = Request.CreateResponse(HttpStatusCode.OK);
            response.Content = new StringContent(json, Encoding.UTF8, "application/json");
            response.StatusCode = HttpStatusCode.OK;

            return response;

        }
    }
}
