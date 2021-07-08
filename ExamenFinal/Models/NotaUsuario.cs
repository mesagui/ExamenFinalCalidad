using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenFinal.Models
{
    public class NotaUsuario
    {
        public int NotaId { get; set; }
        public int UserId { get; set; }

        public Nota Nota { get; set; }

     }
}
