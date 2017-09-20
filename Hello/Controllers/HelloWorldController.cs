using Hello.Models;
using System.Web.Http;
using System.Web.Mvc;


namespace Hello.Controllers
{
    public abstract class HelloWorldController : Controller
    {
        // GET api/<controller>
        public JsonResult Get()
        {
            //return new string[] { "value1", "value2" };
            Data data = new Data();
            
            JsonResult result = Json(data, JsonRequestBehavior.AllowGet);
            return result;
        }

        // GET api/<controller>/5
        public abstract string Get(int id);


        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }

}