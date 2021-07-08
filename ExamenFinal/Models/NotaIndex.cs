using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenFinal.Models
{
    public class NotaIndex
    {
        public NotaIndex()
        {
            Notas = new List<Nota>();
        }
       public string BuscarTexto { get; set; }
       public int? TagId { get; set; }
       public bool Compartida { get; set; }

       public List<Nota> Notas { get; set; }
    }
}
