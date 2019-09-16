using System.Web.Mvc;
namespace SIS_Ga2.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        public AccountController()
        {
        }

        public ActionResult Index()
        {
            if (!Request.IsAuthenticated)
            {
                //HttpContext.GetOwinContext().Authentication.Challenge(new AuthenticationProperties { RedirectUri = "/" }, OpenIdConnectAuthenticationDefaults.AuthenticationType);
            }
            //else return RedirectToAction("Empresa", "Tablero");

            return View();
        }

        public void SignIn()
        {

        }

        public void SignOut()
        {
            //HttpContext.GetOwinContext().Authentication.SignOut(
            //        OpenIdConnectAuthenticationDefaults.AuthenticationType,
            //        CookieAuthenticationDefaults.AuthenticationType);
        }
    }
}