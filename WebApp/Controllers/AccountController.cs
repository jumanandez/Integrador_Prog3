using Microsoft.AspNetCore.Mvc;
using Proyecto.Core.Data;
using Proyecto.Core.Entities;
using Proyecto.Core.Helpers;
using WebApp.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApp.Models.ViewModels;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Proyecto.Core.Business.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace WebApp.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUsuarioBusiness _usuarioBusiness;

        public AccountController(IUsuarioBusiness usuarioBusiness)
        {
            _usuarioBusiness = usuarioBusiness;
        }

        [HttpGet]
        public IActionResult Register()
        {
            if (User.Identity!.IsAuthenticated) return RedirectToAction("Index", "Home");
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (!_usuarioBusiness.CreateUsuario(model.Username, model.Password))
                {
                    ViewData["ExistUser"] = "El usuario ya existe";
                    return View(model);
                }

                return RedirectToAction("Login", "Account");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Login()
        {
            if (User.Identity!.IsAuthenticated) return RedirectToAction("Index", "Home");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = _usuarioBusiness.ObtainUsuario(model.Username);
                if (user != null)
                {
                    byte[] hashPassword = CryptoHelper.HashPassword(model.Password, user.Salt);
                    if (user.HashPassword.SequenceEqual(hashPassword))
                    {
                        List<Claim> claims = new List<Claim>()
                        {
                            new Claim(ClaimTypes.Name, user.Nombre),
                            new Claim(ClaimTypes.NameIdentifier, user.UsuarioId.ToString())
                        };

                        ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                        AuthenticationProperties properties = new AuthenticationProperties()
                        {
                            AllowRefresh = true,
                        };

                        await HttpContext.SignInAsync(
                            CookieAuthenticationDefaults.AuthenticationScheme,
                            new ClaimsPrincipal(claimsIdentity),
                            properties
                            );

                        return RedirectToAction("Index", "Home");
                    }
                }

                ViewData["LoginError"] = "Usuario o contraseña incorrecta";
            }
            return View(model);
        }
        //[HttpPost]
        //public async Task<IActionResult> SignOut()
        //{
        //    await LoginViewModel.SignOutAsync();
        //    return RedirectToAction("Index", "Home");
        //}
    }
}