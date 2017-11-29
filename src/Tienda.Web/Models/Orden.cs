using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace Tienda.Web.Models
{
    public class Orden
    {
        [BindNever]
        public int Id { get; set; }

        public List<DetalleOrden> DetalleOrden { get; set; }

        [Required(ErrorMessage = "Por favor ingrese sus nombres")]
        [Display(Name = "Nombres")]
        [StringLength(50)]
        public string Nombres { get; set; }

        [Required(ErrorMessage = "Por favor ingrese sus apellidos")]
        [Display(Name = "Apellidos")]
        [StringLength(50)]
        public string Apellidos { get; set; }

        [Required(ErrorMessage = "Por favor ingrese su dirección")]
        [StringLength(100)]
        [Display(Name = "Dirección 1")]
        public string Direccion1 { get; set; }

        [Display(Name = "Dirección 2")]
        public string Direccion2 { get; set; }

        [Required(ErrorMessage = "Por favor ingrese su código postal")]
        [Display(Name = "Codigo Postal")]
        [StringLength(10, MinimumLength = 4)]
        public string CodigoPostal { get; set; }

        [StringLength(10)]
        public string Distrito { get; set; }

        [Required(ErrorMessage = "Por favor ingrese su Provincia")]
        [StringLength(50)]
        public string Provincia { get; set; }

        [Required(ErrorMessage = "Por favor ingrese su número telefónico")]
        [StringLength(25)]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Teléfono")]
        public string Telefono { get; set; }

        [Required]
        [StringLength(50)]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|""(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21\x23-\x5b\x5d-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])*"")@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\[(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?|[a-z0-9-]*[a-z0-9]:(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21-\x5a\x53-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])+)\])",
            ErrorMessage = "El correo ingresado no tiene el formato correcto")]
        public string Email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public decimal OrdenTotal { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime OrdenColocada { get; set; }
    }
}
