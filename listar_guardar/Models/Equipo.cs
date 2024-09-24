using System.ComponentModel.DataAnnotations;

namespace listar_guardar.Models
{
    public class Equipo
    {
        [Required]
        public string? Computadoras { get; set; }
        [Required]
        public string? Sillas { get; set; }
        public string? Herramientas { get; set; }
        public string? Cables { get; set; }
        public string? Nombres { get; set; }
        public int Matricula_Alum { get; set; }
        public string Grupo { get; set; }
        public conexcion conexcion { get; set; }
        public int? LaboratorioId { get; set; }
        public LaboratorioModel Laboratorio { get; set; }
    }
}
