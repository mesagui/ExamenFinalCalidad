using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenFinal.Models
{
    public class NotaDatos
    {
        public int NotaId { get; set; }
        public string Titulo { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime FechaModificacion { get; set; }
        public string Contenido { get; set; }
        public int IdUsuario { get; set; }

        public string TagsIds { get; set; }
        public string Tags { get; set; }
    }
}
