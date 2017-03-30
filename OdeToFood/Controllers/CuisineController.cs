using OdeToFood.Filters;
using System.Web.Mvc;

namespace OdeToFood.Controllers
{
    [Log]
    public class CuisineController : Controller
    {
        public ActionResult Search(string name = "french")
        {
            throw new System.Exception("Something terrible happened");
            
            return Content(Server.HtmlEncode(name));
        }
    }
}