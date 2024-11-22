using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace PTC_Oficial
{
    internal class Tarde
    {
        Conexion c = new Conexion();
        public int idLlegadasTarde;
        public int Empleado;
        public string Fecha;
        public string Hora;
        public string Texto;
        public bool Agregar()
        {
            MySqlConnection conex = c.Conectar();
            try
            {
                string comando = "INSERT INTO llegadasTarde (Fecha, hora, Texto, id_empleado) VALUES (@Fecha,@hora,@Texto,@empleado);";
                MySqlCommand cmd = new MySqlCommand(comando, conex);
                cmd.Parameters.AddWithValue("@Fecha", Fecha);
                cmd.Parameters.AddWithValue("@hora", Hora);
                cmd.Parameters.AddWithValue("@Texto", Texto);
                cmd.Parameters.AddWithValue("@empleado", Empleado);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "Alerta", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                conex.Close();
            }
        }
        public bool Eliminar()
        {
            MySqlConnection con = c.Conectar();
            try
            {
                string comando = "DELETE FROM llegadasTarde WHERE idLlegadatarde=@idLlegadasTarde;";
                MySqlCommand command = new MySqlCommand(comando, con);
                command.Parameters.AddWithValue("@idLlegadasTarde", idLlegadasTarde);
                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
                return false;
            }
            finally
            {
                con.Close();
            }
        }
        public DataTable MostrarLlegadasTarde()
        {
            string comando = "SELECT idLlegadatarde AS 'id', Fecha, hora AS 'Hora', Texto, nombres_y_apellidosUsuario AS 'Nombre del empleado' FROM llegadastarde AS lt INNER JOIN Empleados AS e ON e.id_empleado = lt.id_empleado;";
            MySqlConnection cnx = c.Conectar();
            DataTable dt = new DataTable();

            MySqlDataAdapter adaptador = new MySqlDataAdapter(comando, cnx);
            adaptador.Fill(dt);

            return dt;
        }
        public DataTable Empleados()
        {
            MySqlConnection CON = c.Conectar();
            try
            {

                string comando = "SELECT * FROM Empleados";
                MySqlDataAdapter adapter = new MySqlDataAdapter(comando, CON);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
                return null;
            }
            finally
            {
                CON.Close();
            }
        }
        public DataTable LeerLlegadasTarde()
        {
            MySqlConnection conex = c.Conectar();
            string comando = "SELECT idLlegadatarde AS 'id', Fecha, hora AS 'Hora', Texto, nombres_y_apellidosUsuario AS 'Nombre_del_empleado' FROM llegadastarde AS lt INNER JOIN Empleados AS e ON e.id_empleado = lt.id_empleado;";
            MySqlDataAdapter ad = new MySqlDataAdapter(comando, conex);
            DataTable dt = new DataTable();
            try
            {
                ad.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                conex.Close();
            }
        }
    }
}
