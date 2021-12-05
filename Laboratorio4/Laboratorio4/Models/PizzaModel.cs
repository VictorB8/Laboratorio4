using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Laboratorio4.Models
{
    public class PizzaModel
    {
        public int id { get; set; }

        [Required(ErrorMessage = "Es necesario que indique el tipo de la pizza")]
        [Display(Name = "Ingrese el tipo de pizza deseado")]
        public string tipoPizza { get; set; }

        [Required(ErrorMessage = "Es necesario que indique el tamaño de la pizza")]
        [Display(Name = "Seleccione el tamaño de la pizza")]
        public string tamano { get; set; }

        [Required(ErrorMessage = "Es necesario que indique si quiere queso")]
        [Display(Name = "Quiere queso?")]
        public string queso { get; set; }

        
        [Display(Name = "Quiere carne?")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Debe ingresar numeros")]
        public int carne { get; set; }

       
        [Display(Name = "Quiere pollo?")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Debe ingresar numeros")]
        public int pollo { get; set; }

        
        [Display(Name = "Quiere hongos?")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Debe ingresar numeros")]
        public int hongos { get; set; }

      
        [Display(Name = "Quiere chile?")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Debe ingresar numeros")]
        public int chile { get; set; }

      
        [Display(Name = "Quiere algun extra?")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Debe ingresar numeros")]
        public int otros { get; set; }
    }
}