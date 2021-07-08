using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenFinal.Models
{
    public class DetallePostTags
    {

        public int Id { get; set; }
        public int IdPost { get; set; }
        public int IdTags { get; set; }
        public Tag Tag { get; set; }
        public Post Post { get; set; }

        public DetallePostTags(int idPost, int idTags)
        {
            this.IdPost = idPost;
            this.IdTags = idTags;
        }

    }
}
