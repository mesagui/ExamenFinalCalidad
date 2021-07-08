using ExamenFinal.Models;
using ExamenFinal.Repository;
using ExamenFinal.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal.Controllers
{
    public class UserController : Controller
    {

        private IConfiguration configuration;
        private ICookieAuthService cookieAuthService;
        private IUserRepository repository;

        public UserController(IUserRepository repository, ICookieAuthService cookieAuthService, IConfiguration configuration)
        {
            this.configuration = configuration;
            this.repository = repository;
            this.cookieAuthService = cookieAuthService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CrearUsuario(Usuario user)
        {
 

            if (repository.FindByUsername(user.UserName) != null)
            {
                ModelState.AddModelError("Username", "Usuario Ya existe");
            }

            if (ModelState.IsValid)
            {
                user.Password = CreateHash(user.Password);
                repository.Create(user);
                return RedirectToAction("Login");
            }
            else
            {
                return View();
            }
        }


        private string CreateHash(string input)
        {
            var sha = SHA256.Create();
            input += configuration.GetValue<string>("Token");
            var hash = sha.ComputeHash(Encoding.Default.GetBytes(input));

            return Convert.ToBase64String(hash);
        }


        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Login(string UserName, string Password)
        {
            /* validar si el usuario existe en la base de datos y 
             * verificar que el password sea correcto*/

            var user = repository.FindUser(UserName, CreateHash(Password));

            if (user != null)
            {
                // Autenticaremos
                var claims = new List<Claim> {
                    new Claim(ClaimTypes.Name, UserName)
                };

                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);

                // cree la cookie y permita la autenticación
                cookieAuthService.SetHttpContext(HttpContext);
                cookieAuthService.Login(claimsPrincipal);

                return RedirectToAction("Index", "Nota");
            }

            ModelState.AddModelError("Login", "Usuario o contraseña incorrectos.");
            return View();
        }


        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.SignOutAsync();
            return RedirectToAction("Login");
        }

    }
}
