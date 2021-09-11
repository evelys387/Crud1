using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Crud1.Models
{
    public class Tutor
    {
        [Key]
        public int IdTutor { get; set; }
        
        [Required(ErrorMessage ="Este campo es obligatorio")]
        [Display(Name ="Nombre del Tutor")]
        [StringLength(30, ErrorMessage ="Este campo requiere menos de 30 caracteres")]
        public string nombreT { get; set; }

        public string apellidoT { get; set; }

        [DataType(DataType.Date)]
        public DateTime fechanacT { get; set; }
    }
}
