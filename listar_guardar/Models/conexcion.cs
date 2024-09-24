using System.ComponentModel.DataAnnotations;
namespace listar_guardar.Models
{
    public class conexcion
    {
        public int idEquipo { get; set; }
        [Required(ErrorMessage = "El tipo de computadoras es obligatorio")]
        public string? Computadoras { get; set; }
        [Required(ErrorMessage = "Se necesita cuantas sillas hay en el laboratorio")]
        public string? Sillas { get; set; }
        [Required(ErrorMessage = "Es necesario si el laboratorio tiene alguna herramienta")]
        public string? Herramientas { get; set; }
        [Required(ErrorMessage = "Se ocupa saber si faltan cables o no")]
        public string? Cables { get; set; }
        [Required(ErrorMessage = "Se ocupa saber a que alumno le pertenece la computadora")]
        public int? Matricula_Alum { get; set; }

    }
}