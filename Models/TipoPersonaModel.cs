using System.ComponentModel.DataAnnotations;

namespace prueba_back_end.Models
{
    public class TipoPersonaModel
    {
        [Required(ErrorMessage = "El nombre es requerido.")]
        public string nombre { get; set; }


#nullable enable
        public int? id { get; set; }
    }
}
