using listar_guardar.Models;
using System.Data;
using System.Data.SqlClient;

namespace listar_guardar.Datos
{
    public class equipos
    {
        public List<Equipo> ListarEquipos()
        {
            var olista = new List<Equipo>();
            var con = new conexion();
            using (var conexion = new SqlConnection(con.getCadenaSql()))
            {
                conexion.Open();

                using (var cmd = new SqlCommand("sp_VerEstudiantesCursos", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            olista.Add(new Equipo
                            {
                                Computadoras = dr["Computadoras"].ToString(),
                                Sillas = dr["sillas"].ToString(),
                                Herramientas = dr["Herramientas"].ToString(),
                                Cables = dr["Cables"].ToString(),
                                Nombres = dr["Nombres"].ToString(),
                                Grupo = dr["Grupo"].ToString(),
                                Matricula_Alum = Convert.ToInt32(dr["Matricula_Alum"])
                            });
                        }
                    }
                }
            }

            return olista;
        }
    }
}