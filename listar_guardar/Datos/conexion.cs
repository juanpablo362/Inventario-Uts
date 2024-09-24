namespace listar_guardar.Datos
{
    public class conexion
    {
        private string CadenaSql = string.Empty;

        public conexion()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();

            CadenaSql = builder.GetSection("ConnectionStrings:Cadena").Value;
        }

        public string getCadenaSql()
        {
            return CadenaSql;
        }
    }
}
