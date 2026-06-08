using System.ComponentModel.DataAnnotations;

namespace CalculadoraIMC.Models
{
    public class ImcModel
    {
        [Required]
        [Range(1, 500)]
        public double Peso { get; set; }

        [Required]
        [Range(0.5, 3.0)]
        public double Altura { get; set; }

        public double Resultado { get; set; }

        public string Classificacao { get; set; }
    }
}