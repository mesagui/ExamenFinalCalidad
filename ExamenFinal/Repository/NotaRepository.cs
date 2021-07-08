
using ExamenFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ExamenFinal.Repository
{
    public interface INotaRepository
    {
        void Create(NotaDatos notaDatos);
        void Modificar(NotaDatos notaDatos);
        List<Nota> NotasDeUsuario(int idUsuario);
        List<Nota> NotasCompartidas(int idUsuario);
        Nota GetById(int id);
        void Eliminar(int id);
        bool Compartir(int notaId, int userId);
    }

    public class NotaRepository : INotaRepository
    {
        private readonly IFinalContext context;

        public NotaRepository(IFinalContext context)
        {
            this.context = context;
        }

        public Nota GetById(int id)
        {
            return context.Notas.Find(id);
        }
        public void Eliminar(int id)
        {
            var nota = context.Notas.Find(id);
            context.Notas.Remove(nota);
            context.SaveChanges();
        }

        public bool Compartir(int notaId, int userId)
        {
            var nota = context.NotaUsuario.FirstOrDefault(x => x.NotaId == notaId && x.UserId == userId);
            if (nota != null) return false;
            context.NotaUsuario.Add(new NotaUsuario
            {
                NotaId = notaId,
                UserId = userId
            });
            context.SaveChanges();
            return true;
        }
        public void Create(NotaDatos notaDatos)
        {
            var nota = new Nota
            {
                Contenido = notaDatos.Contenido,
                IdUsuario = notaDatos.IdUsuario,
                Titulo = notaDatos.Titulo,
                Fecha = notaDatos.Fecha,
            };
            context.Add(nota);
            context.SaveChanges();

            if (!string.IsNullOrEmpty(notaDatos.TagsIds))
            {
                var notasTags = notaDatos.TagsIds.Split(",").ToList();
                foreach (var tagId in notasTags)
                {
                    context.NotaTags.Add(new NotaTag
                    {
                        TagId = int.Parse(tagId),
                        NotaId = nota.NotaId
                    });
                }
                context.SaveChanges();
            }
        }
        public void Modificar(NotaDatos notaDatos)
        {
            var nota = new Nota
            {
                NotaId = notaDatos.NotaId,
                Contenido = notaDatos.Contenido,
                IdUsuario = notaDatos.IdUsuario,
                Titulo = notaDatos.Titulo,
                Fecha = notaDatos.Fecha,
                FechaModificacion = DateTime.Now
            };
            context.Update(nota);
            context.SaveChanges();
            if (!string.IsNullOrEmpty(notaDatos.TagsIds))
            {
                var tagsExistentes = context.NotaTags.Where(x => x.NotaId == nota.NotaId).ToList();
                foreach (var existente in tagsExistentes)
                {
                    context.NotaTags.Remove(existente);
                }
                var notasTags = notaDatos.TagsIds.Split(",").ToList();
                foreach (var tagId in notasTags)
                {
                    context.NotaTags.Add(new NotaTag
                    {
                        TagId = int.Parse(tagId),
                        NotaId = nota.NotaId
                    });
                }
                context.SaveChanges();
            }
        }
        public List<Nota> NotasDeUsuario(int idUsuario)
        {
            return context.Notas.Where(x => x.IdUsuario == idUsuario).Include(x => x.Tags).ThenInclude(x => x.Tag).ToList();
        }
        public List<Nota> NotasCompartidas(int idUsuario)
        {
            //return context.NotaUsuario.Where(x => x.UserId == idUsuario).Select(x => x.Nota).Include(x => x.Tags).ThenInclude(x => x.Tag).ToList();
            return context.NotaUsuario.Where(x => x.UserId == idUsuario)
                                      .Include(x => x.Nota)
                                      .ThenInclude(x => x.Tags)
                                      .ThenInclude(x => x.Tag).ToList()
                                      .Select(x => x.Nota).ToList();
        }
    }
}
