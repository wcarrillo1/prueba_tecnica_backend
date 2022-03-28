using System.ComponentModel.DataAnnotations;

namespace prueba_back_end.Models
{
    public class VehiculoModel
    {
        [Required(ErrorMessage = "La Capacidad del Vehiculo es requerida.")]
        public string capacidad { get; set; }
        [Required(ErrorMessage = "El Consumo de Combustible del Vehiculo es requerida.")]
        public string consumo_combustible { get; set; }

        [Required(ErrorMessage = "El Costo De Depreciacion del Vehiculo es requerida.")]
        public string costo_depreciacion { get; set; }

        [Required(ErrorMessage = "El tipo de carga del Vehiculo es requerida.")]
        public string tipo_carga { get; set; }


#nullable enable
        public int? id { get; set; }
    }
}
