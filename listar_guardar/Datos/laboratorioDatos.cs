using listar_guardar.Models;
using System.Data;
using System.Data.SqlClient;

namespace listar_guardar.Datos
{
    public class laboratorioDatos
    {
        public List<conexcion> Listar()
        {
            var olista = new List<conexcion>();

            var cn = new conexion();

            using (var conecion = new SqlConnection(cn.getCadenaSql()))
            {
                conecion.Open();
                SqlCommand cmd = new SqlCommand("sp_listar", conecion);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        olista.Add(new conexcion()
                        {
                            idEquipo = Convert.ToInt32(dr["idEquipo"]),
                            Computadoras = dr["Computadoras"].ToString(),
                            Sillas = dr["Sillas"].ToString(),
                            Herramientas = dr["Herramientas"].ToString(),
                            Cables = dr["Cables"].ToString(),
                            Matricula_Alum = Convert.ToInt32(dr["Matricula_Alum"])
                        });
                    }
                }

            }
            return olista;
        }
        public conexcion obtener(int idEquipo)
        {
            var oalumno = new conexcion();

            var cn = new conexion();

            using (var conecion = new SqlConnection(cn.getCadenaSql()))
            {
                conecion.Open();
                SqlCommand cmd = new SqlCommand("sp_ConsultarInmoviliaria", conecion);
                cmd.Parameters.AddWithValue("idEquipo", idEquipo);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oalumno.idEquipo = Convert.ToInt32(dr["idEquipo"]);
                        oalumno.Computadoras = dr["Computadoras"].ToString();
                        oalumno.Sillas = dr["Sillas"].ToString();
                        oalumno.Herramientas = dr["Herramientas"].ToString();
                        oalumno.Cables = dr["Cables"].ToString();
                        oalumno.Matricula_Alum = Convert.ToInt32(dr["Matricula_Alum"]);
                    }
                }

            }
            return oalumno;
        }
        public bool Guardar(conexcion oalumno)
        {
            bool resp;

            try
            {

                var cn = new conexion();

                using (var conecion = new SqlConnection(cn.getCadenaSql()))
                {
                    conecion.Open();
                    SqlCommand cmd = new SqlCommand("sp_InsertarInmoviliaria", conecion);
                    cmd.Parameters.AddWithValue("Computadoras", oalumno.Computadoras);
                    cmd.Parameters.AddWithValue("Sillas", oalumno.Sillas);
                    cmd.Parameters.AddWithValue("Herramientas", oalumno.Herramientas);
                    cmd.Parameters.AddWithValue("Cables", oalumno.Cables);
                    cmd.Parameters.AddWithValue("Matricula_alum", oalumno.Matricula_Alum);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.ExecuteNonQuery();

                }
                resp = true;
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                resp = false;
            }

            return resp;
        }
        public bool Editar(conexcion oalumno)
        {
            bool rpta;

            try
            {
                var cn = new conexion();
                using (var conecion = new SqlConnection(cn.getCadenaSql()))
                {
                    conecion.Open();
                    SqlCommand cmd = new SqlCommand("sp_ModificarInmoviliaria", conecion);
                    cmd.Parameters.AddWithValue("idEquipo", oalumno.idEquipo);
                    cmd.Parameters.AddWithValue("Computadoras", oalumno.Computadoras);
                    cmd.Parameters.AddWithValue("Sillas", oalumno.Sillas);
                    cmd.Parameters.AddWithValue("Herramientas", oalumno.Herramientas);
                    cmd.Parameters.AddWithValue("Cables", oalumno.Cables);
                    cmd.Parameters.AddWithValue("Matricula_alum", oalumno.Matricula_Alum);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                }
                rpta = true;
            }
            catch (Exception e)
            {
                string error = e.Message;
                rpta = false;
            }
            return rpta;
        }

        public bool Eliminar(int idEquipo)
        {
            bool rpta;

            try
            {
                var cn = new conexion();
                using (var conecion = new SqlConnection(cn.getCadenaSql()))
                {
                    conecion.Open();
                    SqlCommand cmd = new SqlCommand("sp_EliminarInmoviliarla", conecion);
                    cmd.Parameters.AddWithValue("idEquipo", idEquipo);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                }
                rpta = true;
            }
            catch (Exception e)
            {
                string error = e.Message;
                rpta = false;
            }
            return rpta;
        }
    }
}