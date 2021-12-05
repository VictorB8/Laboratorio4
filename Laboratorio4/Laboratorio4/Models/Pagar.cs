using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Laboratorio4.Models
{
    public class Pagar
    {
        public int id { get; set; }

        [Required(ErrorMessage = "Es necesario que indique el nombre")]
        [Display(Name = "Ingrese el nombre del dueño de la tarjeta")]
        public string nombreDelDueño { get; set; }

        [Required(ErrorMessage = "Es necesario que indique el numero de la tajeta")]
        [Display(Name = "Ingrese el numero de tarjeta")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Debe ingresar numeros")]
        public string Numero{ get; set; }

        [Required(ErrorMessage = "Es necesario que indique CCV")]
        [Display(Name = "CCV")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Debe ingresar numeros")]
        public string CCV { get; set; }

        [Required(ErrorMessage = "Es necesario que indique la fecha de vencimiento")]
        [Display(Name = "Fecha de vencimiento")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Debe ingresar numeros")]
        public int fechaVencimiento { get; set; }

    }
}