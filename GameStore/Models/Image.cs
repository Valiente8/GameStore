using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GameStore.Models
{
    public class Image
    {
        public int ImageId { get; set; }

        [StringLength(255)]
        public string ImageName { get; set; }
        public Filetype Filetype { get; set; }
        public int VideojuegoId { get; set; }
        public virtual Videojuego Videojuegos { get; set; }
    }
}