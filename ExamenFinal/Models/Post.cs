using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenFinal.Models
{
    public class Post
    {
        public int Id { get; set; }

        public string Titulo { get; set; }


        public DateTime Fecha { get; set; }


        public string Contenido { get; set; }


        public List<DetallePostTags> DetallePostTags { get; set; }


    }
}
