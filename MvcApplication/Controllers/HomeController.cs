using System.Security.Claims;
using System.Web.Mvc;

namespace MvcApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                var roles = ((ClaimsIdentity)User.Identity).FindFirst("roles");
                ViewData["roles"] = roles.Value;
            }
            return View();
        }
    }
}