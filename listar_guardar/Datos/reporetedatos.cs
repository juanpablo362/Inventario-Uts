using listar_guardar.Models;
using System.Data;
using System.Data.SqlClient;

namespace listar_guardar.Datos
{
    public class reporetedatos
    {
        public List<reportevista> Listar()
        {
            var olista = new List<reportevista>();

            var cn = new conexion();


            using (var conexion = new SqlConnection(cn.getCadenaSql()))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_ListarVista", conexion);

                cmd.CommandType = CommandType.StoredProcedure;
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        olista.Add(new reportevista
                        {
                            Nombres = dr["Nombres"].ToString(),
                            Apellidos = dr["Apellidos"].ToString(),
                            texto = dr["texto"].ToString(),
                            Grupo = dr["Grupo"].ToString(),
                        });
                    }
                }
            }
            return olista;
        }

        public bool Guardar(reportes oreporte)
        {
            bool gb;
            try
            {
                var oreportes = new reportes();
                var cn = new conexion();
                using (var Conexion = new SqlConnection(cn.getCadenaSql()))
                {
                    Conexion.Open();
                    SqlCommand cmd = new SqlCommand("sp_ingresarreporte", Conexion);
                    cmd.Parameters.AddWithValue("texto", oreporte.texto);
                    cmd.Parameters.AddWithValue("Matricula_alum", oreporte.Matricula_alum);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.ExecuteNonQuery();
                }
                gb = true;
            }
            catch (Exception e)
            {
                string error = e.Message;
                gb = false;
            }
            return gb;
        }

    }
}

