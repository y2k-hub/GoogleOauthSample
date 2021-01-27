using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace GoogleOAuth.Controllers {

	public class AccountController : Controller {

        public IActionResult Login() {
            return this.Challenge(new AuthenticationProperties{
                RedirectUri = "/"
            });
        }

        public IActionResult Logout() {
            return this.SignOut(new AuthenticationProperties {
                RedirectUri = "/"
            });
        }
    }
}
