using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace PTC_Oficial
{
    internal class sancion
    {
        Conexion c = new Conexion();
        public int id;
        public int gravedad;
        public int empleados;
        public string descripcion;
        public bool Agregar()
        {
            MySqlConnection conex = c.Conectar();
            try
            {
                string comando = "INSERT INTO sanciones (idTipoSancion, id_empleado, sancionadoPor) VALUES (@gra,@empleado,@san);";
                MySqlCommand cmd = new MySqlCommand(comando, conex);
                cmd.Parameters.AddWithValue("@gra", gravedad);
                cmd.Parameters.AddWithValue("@empleado", empleados);
                cmd.Parameters.AddWithValue("@san", descripcion);
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
                string comando = "DELETE FROM sanciones WHERE idSanciones=@ID;";
                MySqlCommand command = new MySqlCommand(comando, con);
                command.Parameters.AddWithValue("@ID", id);
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

        public bool Update()
        {
            MySqlConnection con = c.Conectar();
            try
            {
                string comando = "UPDATE sanciones SET idTipoSancion=@gra, id_empleado=@empleado, sancionadoPor=@san WHERE idSanciones=@ID;";
                MySqlCommand cmd = new MySqlCommand(comando, con);
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.Parameters.AddWithValue("@gra", gravedad);
                cmd.Parameters.AddWithValue("@empleado", empleados);
                cmd.Parameters.AddWithValue("@san", descripcion);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public DataTable MostrarSanciones()
        {
            string comando = "SELECT idSanciones AS 'ID', gravedaddeSancion AS 'Gravedad de sanción', nombres_y_apellidosUsuario AS 'Nombre completo', sancionadoPor AS 'Sancionado por' FROM sanciones AS s INNER JOIN gravedadsanciones AS g ON g.idTipoSancion = s.idTipoSancion INNER JOIN Empleados AS e ON e.id_empleado = s.id_empleado;";
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
        public DataTable Gravedad()
        {
            MySqlConnection CON = c.Conectar();
            try
            {

                string comando = "SELECT * FROM GravedadSanciones";
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
    }
}
