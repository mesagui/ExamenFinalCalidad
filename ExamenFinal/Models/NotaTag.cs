using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenFinal.Models
{
    public class NotaTag
    {

        public int TagId { get; set; }
        public int NotaId { get; set; }

        public Tag Tag { get; set; }
        public Nota Nota { get; set; }
    }
}
