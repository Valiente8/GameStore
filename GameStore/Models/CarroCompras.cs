using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameStore.Models
{
    public class Carrocompras
    {
        public int Id { get; set; }
        

        public virtual ICollection<Videojuego> Videojuegos { get; set; }

    }
}