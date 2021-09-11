using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Crud1.Models
{
    public class Ninio
    {
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage ="Campo requerido")]
        [StringLength(30,ErrorMessage ="No puede ingresar nombres mayores a 30")]
        public string nombres { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        public string apellidos { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [Display(Name ="Fecha de Nacimiento")]
        [DataType(DataType.Date)]
        public DateTime fechanac { get; set; }
        public int idtutor { get; set; }

    }
}
