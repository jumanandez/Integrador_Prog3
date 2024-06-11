using Microsoft.AspNetCore.Mvc;
using Proyecto.Core.Data;
using Proyecto.Core.Entities;
using Proyecto.Core.Helpers;
using WebApp.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApp.Models.ViewModels;

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
                    ModelState.AddModelError("", "Username already exists");
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
                        // FALTA LOGICA DE INICIO DE SESION Y ESTABLECER SESION
                        return RedirectToAction("Index", "Home");
                    }
                }

                ModelState.AddModelError("", "Invalid username or password");
            }
            return View(model);
        }
    }
}