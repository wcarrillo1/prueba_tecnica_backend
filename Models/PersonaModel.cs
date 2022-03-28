using System.ComponentModel.DataAnnotations;

namespace prueba_back_end.Models
{
    public class PersonaModel
    {
        [Required(ErrorMessage = "El nombre es requerido.")]
        public string nombres { get; set; }

        [Required(ErrorMessage = "El apellido es requerido.")]
        public string apellidos { get; set; }

        [Required(ErrorMessage = "El nit es requerido.")]
        public int nit { get; set; }

        [Required(ErrorMessage = "El municipio es requerido.")]
        public string municipio { get; set; }

        [Required(ErrorMessage = "El direccion es requerido.")]
        public  string direccion { get; set; }

        [Required(ErrorMessage = "El tipo de persona es requerido.")]
        public int tipo_persona { get; set; }



#nullable enable
        public int? id { get; set; }
    }
}
