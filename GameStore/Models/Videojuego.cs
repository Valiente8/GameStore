using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GameStore.Models
{
    public class Videojuego
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El precio del videojuego es requerido")]
        [Range(0.99, 1000, ErrorMessage = "El precio debe estar entre 0.99 y 1000")]
        [DataType(DataType.Currency)]
        public float Precio { get; set; }

        [DataType(DataType.MultilineText)]
        [StringLength(200, MinimumLength = 10, ErrorMessage = "La descripción debe tener entre 10 y 200 caracteres")]
        public string Descripcion { get; set; }

        [DisplayName("Requerimientos Mínimos")]
        public string Requerimiento { get; set; }

        [DisplayName("Género")]
        public int GeneroId { get; set; }
        public virtual Genero Generos { get; set;}


        public ICollection<Image> Images { get; set; }

        public int? CarrocomprasId { get; set; }
        public virtual Carrocompras Carro { get; set; }


    }
}