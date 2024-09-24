using System.ComponentModel.DataAnnotations;

namespace listar_guardar.Models
{
    public class LaboratorioModel
    {
        [Required]
        public int? idSalon { get; set; }
        public string? Edificio { get; set; }
        public string? Tipo_DeEquipo { get; set; }
        public int? Grupo_Equipo { get; set; }
        public string Nombre { get; set; }
        public ICollection<Equipo> Equipos { get; set; }
    }
}
