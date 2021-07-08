
using ExamenFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenFinal.Repository
{
    public interface ITagRepository
    {

        List<Tag> GetAll();
        List<Tag> GetByNotaId(int notaId);
    }

    public class TagRepository : ITagRepository
    {
        private readonly IFinalContext context;

        public TagRepository(IFinalContext context)
        {
            this.context = context;
        }

        public List<Tag> GetAll()
        {
            return context.Tags.ToList();
        }

        public List<Tag> GetByNotaId(int notaId)
        {
            return context.NotaTags.Where(x => x.NotaId == notaId).Select(x => x.Tag).ToList();
        }
    }
}
