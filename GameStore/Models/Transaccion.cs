using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GameStore.Models
{
    public class Transaccion
    {
        public int Id { get; set; }

        [DisplayName("Nombre del cliente")]
        [Required(ErrorMessage = "Es requerido ingresar el nombre del cliente")]
        public string Nombre { get; set; }

        [DataType(DataType.MultilineText)]
        [StringLength(200, MinimumLength = 10, ErrorMessage = "La dirección debe tener entre 10 y 200 caracteres")]
        public string Direccion { get; set; }


        [Required(ErrorMessage = "Es requerido ingresar el correo")]
        public string Correo { get; set; }

        [DataType(DataType.CreditCard)]
        [Required(ErrorMessage = "Es requerido ingresar una tarjeta de crédito válida")]
        public string TarjetaCredito { get; set; }


        public string FechaExpiracion { get; set; }



    }
}