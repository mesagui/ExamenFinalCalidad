using ExamenFinal.Models;
using ExamenFinal.Repository;
using ExamenFinal.Services;
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


    
    public class NotaController : Controller
    {


        private INotaRepository repository;
        private IUserRepository userRepository;
        private ITagRepository tagRepository;

        public NotaController(INotaRepository repository,
            IUserRepository userRepository,
            ITagRepository tagRepository
            )
        {
            this.repository = repository;
            this.userRepository = userRepository;
            this.tagRepository = tagRepository;
        }

        public IActionResult Index(NotaIndex index)
        {
            var notas = index .Compartida? repository.NotasCompartidas(GetCurrentUser().Id):repository.NotasDeUsuario(GetCurrentUser().Id);
            if (index.TagId.HasValue)
                notas = notas.Where(x => x.Tags.Any(x => x.TagId == index.TagId)).ToList();
            if (!string.IsNullOrEmpty(index.BuscarTexto))
            {

                notas = notas.Where(x =>
                    x.Titulo.ToLower().Contains(index.BuscarTexto.Trim().ToLower()) ||
                    x.Contenido.ToLower().Contains(index.BuscarTexto.Trim().ToLower()) || 
                    x.Tags.Any(y => y.Tag.Nombre.ToLower().Contains(index.BuscarTexto.Trim().ToLower()))).ToList();
            }

            ViewBag.Tags = tagRepository.GetAll();
            index.Notas = notas;
            return View(index);
        }

        public IActionResult Crear()
        {
            ViewBag.Tags = tagRepository.GetAll();
            return View();
        }


        [HttpPost]
        public IActionResult Crear(NotaDatos nota)
        {
            nota.Fecha = DateTime.Now;
            nota.IdUsuario = GetCurrentUser().Id;
            repository.Create(nota);
            return RedirectToAction("Index");
        }

        public IActionResult Editar(int id)
        {
            var nota = repository.GetById(id);
            var tagsRelacionados = tagRepository.GetByNotaId(id);
            
            ViewBag.Tags = tagRepository.GetAll();
            var notaDatos = new NotaDatos
            {
                NotaId = nota.NotaId,
                Contenido = nota.Contenido,
                IdUsuario = nota.IdUsuario,
                Titulo = nota.Titulo,
                Fecha = nota.Fecha,
                FechaModificacion = DateTime.Now,
                TagsIds = string.Join(',', tagsRelacionados.Select(x => x.TagId).ToList()),
                Tags= string.Join(',', tagsRelacionados.Select(x => x.Nombre).ToList())
            };
            return View(notaDatos);
        }

        [HttpPost]
        public IActionResult Editar(NotaDatos nota)
        {
            nota.FechaModificacion = DateTime.Now;
            repository.Modificar(nota);
            return RedirectToAction("Index");
        }

        public IActionResult Compartir(int id)
        {
            var nota = repository.GetById(id);
            ViewBag.Usuarios = userRepository.GetAll().Where(x => x.Id != GetCurrentUser().Id).ToList();
            return View(nota);
        }

        [HttpPost]
        public IActionResult Compartir(int NotaId, int UserId)
        {
            
            var resultado = repository.Compartir(NotaId, UserId);
            if (!resultado)
            {
                ModelState.AddModelError("UserId", "La Nota ya esta compartida con el usuario");
                var nota = repository.GetById(NotaId);
                ViewBag.Usuarios = userRepository.GetAll().Where(x => x.Id != GetCurrentUser().Id).ToList();
                return View(nota);
            }

            return RedirectToAction("Index");
        }


        public IActionResult Eliminar(int id)
        {
            repository.Eliminar(id);
            return RedirectToAction("Index");
        }

        private Usuario GetCurrentUser()
        {
            var claim = HttpContext.User.Claims.FirstOrDefault();
            return userRepository.FindByUsername(claim.Value);
        }
        

    }
}
