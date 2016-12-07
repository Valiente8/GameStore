using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GameStore.Models
{
    public class Genero
    {
        public int Id { get; set; }
        
        [DisplayName("Nombre del género")]
        [Required(ErrorMessage = "Es requerido ingresar el nombre del género")]
        [StringLength(50, MinimumLength = 4, ErrorMessage = "El nombre del género debe tener al menos 3 caracteres")]
        public string Nombre { get; set; }

        public ICollection<Videojuego> Videojuegos { get; set; }

    }
}