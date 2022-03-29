using System.ComponentModel.DataAnnotations;

namespace prueba_back_end.Models
{
    public class AsignarPersonaModel
    {
        [Required(ErrorMessage = "La Persona es requerido.")]
        public int persona { get; set; }

        [Required(ErrorMessage = "El Vehiculo es requerido.")]
        public int vehiculo { get; set; }



#nullable enable
        public int? id { get; set; }
    }
}
