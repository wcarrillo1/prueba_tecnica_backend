using System.ComponentModel.DataAnnotations;

namespace prueba_back_end.Models
{
    public class MunicipioModel
    {
        [Required(ErrorMessage = "El nombre es requerido.")]
        public string nombre { get; set; }

        [Required(ErrorMessage = "El nombre es requerido.")]
        public int departamento { get; set; }



#nullable enable
        public int? id { get; set; }
    }
}
