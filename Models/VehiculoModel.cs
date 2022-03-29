using System.ComponentModel.DataAnnotations;

namespace prueba_back_end.Models
{
    public class VehiculoModel
    {
        [Required(ErrorMessage = "La Capacidad del Vehiculo es requerida.")]
        public decimal capacidad { get; set; }
        [Required(ErrorMessage = "El Consumo de Combustible del Vehiculo es requerida.")]
        public decimal consumo_combustible { get; set; }

        [Required(ErrorMessage = "El Costo De Depreciacion del Vehiculo es requerida.")]
        public decimal costo_depreciacion { get; set; }

        [Required(ErrorMessage = "El tipo de carga del Vehiculo es requerida.")]
        public int tipo_carga { get; set; }

        [Required(ErrorMessage = "La Placa del Vehiculo es requerida.")]
        public string placa { get; set; }


#nullable enable
        public int? id { get; set; }
    }
}
