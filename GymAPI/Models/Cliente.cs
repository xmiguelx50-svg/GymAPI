using System.ComponentModel.DataAnnotations;

namespace GymAPI.Models
{
    // Entidad de negocio: Cliente del gimnasio
    public class Cliente
    {
        // Clave primaria
        [Key]
        public int IdCliente { get; set; }

        // Atributo tipo TEXTO
        [Required]
        [MaxLength(100)]
        public string Nombre { get; set; } = string.Empty;

        // Atributo tipo ENTERO
        [Range(1, 120)]
        public int Edad { get; set; }

        // Atributo tipo FECHA
        public DateTime FechaInscripcion { get; set; }

        // Atributo tipo DECIMAL
        [Range(0, 10000)]
        public decimal CuotaMensual { get; set; }
    }
}
