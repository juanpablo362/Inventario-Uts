namespace listar_guardar.Models
{
    public class Administrador
    {
        public int idNo_Administrador { get; set; }
        public string? Nombres { get; set; }
        public string? Apellidos { get; set; }
        public string? Correo { get; set; }
        public string? Contraseña { get; set; }


        public string? ConfirmarContra { get; set; }
    }
}
