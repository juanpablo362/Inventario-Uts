using Microsoft.Build.Framework;

namespace listar_guardar.Models
{
    public class reportes
    {
        [Required]
        public string? texto { get; set; }

        [Required]
        public int? Matricula_alum { get; set; }
    }
}
