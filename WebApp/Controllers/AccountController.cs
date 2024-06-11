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

namespace WebApp.Controllers
{
    public class AccountController : Controller
    {
        private readonly IntegradorProg3Context _context;

        public AccountController(IntegradorProg3Context context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (_context.Usuarios.Any(u => u.Nombre == model.Username))
                {
                    ViewData["ExistUser"] = "El usuario ya existe";
                    return View(model);
                }

                byte[] salt = CryptoHelper.GenerateSalt();
                byte[] hashPassword = CryptoHelper.HashPassword(model.Password, salt);

                var user = new Usuario
                {
                    Nombre = model.Username,
                    HashPassword = hashPassword,
                    Salt = salt
                };

                _context.Usuarios.Add(user);
                await _context.SaveChangesAsync();

                return RedirectToAction("Login", "Account");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await _context.Usuarios.FirstOrDefaultAsync(u => u.Nombre == model.Username);
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
    }
}