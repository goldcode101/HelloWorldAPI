using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Hello.Models;
using System.Runtime.Serialization;
using System.Web.Script.Serialization;

namespace Hello.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //call the web api
            string baseUrl = Request.Url.Scheme + "://" + Request.Url.Authority + Request.ApplicationPath.TrimEnd('/') + "/";
            string apiUrl = baseUrl + "Home/get";

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = client.GetAsync(apiUrl).Result;
                if (response.IsSuccessStatusCode)
                {
                    string message = response.Content.ReadAsStringAsync().Result;
                    var j = new JavaScriptSerializer().Deserialize<Data>(message);
                    ViewBag.Message = j.Message;
                }
            }

            return View();
        }

        public JsonResult Get()
        {
            Data data = new Data();

            JsonResult result = Json(data, JsonRequestBehavior.AllowGet);
            return result;
        }
    }
}