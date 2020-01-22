using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyVet.Web.Data.Entities
{
    public class TBL_PROPIETARIOAVJ
    {
        [Key]
        public int PRO_ID { get; set; }

        [Display(Name = "CEDULA")]
        // [Required(ErrorMessage = "El campo {0} es obligatorio."), Range(01, 99, ErrorMessage = "El Campo {0} debe ser un numero entre 01 y {2}")]
        [MaxLength(13, ErrorMessage = "El campo {0} no debe exceder de {1} caracteres.")]
        //[DataType(DataType.Currency)]
        public string PRO_CEDULA { get; set; }

        [Display(Name = "NOMBRE")]
        [MaxLength(50, ErrorMessage = "El campo {0} no debe exceder de {1} caracteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [RegularExpression("^[A-ZÑÁÉÍÓÚ]+$", ErrorMessage = "El campo {0} solo letras mayúsculas")]
        public string PRO_NOMBRE { get; set; }

        [Display(Name = "APELLIDOS")]
        [RegularExpression("^[A-ZÑÁÉÍÓÚ]+$", ErrorMessage = "El campo {0} solo letras mayúsculas")]
        [MaxLength(50, ErrorMessage = "El campo {0} no debe exceder de {1} caracteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string PRO_APELLIDO { get; set; }

        [Display(Name = "TELEFONO")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [MaxLength(13, ErrorMessage = "El campo {0} no debe exceder de {1} caracteres.")]
        public string FixedPhone { get; set; }

        [Display(Name = "CELULAR")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "El campo {0} admite solo numeros")]
        //[DataType(DataType.Currency)]
        public string PRO_CELULAR { get; set; }

        [Display(Name = "DIRECCION")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$", ErrorMessage = "El campo {0} solo letras mayúsculas")]
        [MaxLength(100, ErrorMessage = "El campo {0} no debe exceder de {1} caracteres.")]
        public string PRO_DIRECCION { get; set; }

        [Display(Name = "SECTOR")]
        [RegularExpression("^[A-ZÑÁÉÍÓÚ]+$", ErrorMessage = "El campo {0} solo letras mayúsculas")]
        [MaxLength(100, ErrorMessage = "El campo {0} no debe exceder de {1} caracteres.")]
        public string PRO_SECTOR { get; set; }

        public string FullName => $"{PRO_NOMBRE} {PRO_APELLIDO}";

        public string FullNameWithDocument => $"{PRO_NOMBRE} {PRO_APELLIDO} - {PRO_CEDULA}";

        //public ICollection<TBL_MASCOTAS_AVJ> TBL_MASCOTAS_AVJs { get; set; }

        //public ICollection<TBL_AGENDA_AVJ> TBL_AGENDA_AVJs { get; set; }

    }
}
