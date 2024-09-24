using Microsoft.Build.Framework;
namespace listar_guardar.Models
{
    public class reportevista
    {
        [Required]
        public string? Nombres { get; set; }

        [Required]
        public string? Apellidos { get; set; }

        [Required]
        public string? Grupo { get; set; }
        [Required]
        public string? texto { get; set; }

    }
}
