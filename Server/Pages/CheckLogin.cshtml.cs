using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using Share.Models;
using Share.Models.ViewModels;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.DependencyInjection;


namespace Server.Pages
{
    [AllowAnonymous]
    public class CheckLoginModel : PageModel
    {
        [Inject]
        public Share.Interfaces.IUserSvc _userService { get; set; }
        public CheckLoginModel(Share.Interfaces.IUserSvc userSvc)
        {
            _userService = userSvc;
        }
        public string ReturnUrl { get; set; }
        public async Task<IActionResult> OnGetAsync(string paramUsername, string paramPassword)
        {
            string returnUrl = Url.Content("~/");
            try
            {
                await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            }
            catch (Exception) { }
            bool flagLogin = false;
            var viewLogin = new ViewLogin() { UserName = paramUsername, Password = paramPassword };
            User user = _userService.Login(viewLogin);
            if (user != null)
            {
                flagLogin = true;
            }
            if (flagLogin)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, paramUsername),
                    new Claim(ClaimTypes.Role, "Admin")
                };
                var claimIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var authProperties = new AuthenticationProperties
                {
                    IsPersistent = true,
                    RedirectUri = this.Request.Host.Value
                };
                try
                {
                    await HttpContext.SignInAsync(
                        CookieAuthenticationDefaults.AuthenticationScheme,
                        new ClaimsPrincipal(claimIdentity), authProperties);
                }
                catch (Exception e)
                {
                    string err = e.Message;
                }
            }
            else { }
            return LocalRedirect(returnUrl);
        }
    }
}
