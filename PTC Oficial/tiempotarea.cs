using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace PTC_Oficial
{
    internal class tiempotarea
    {
        Conexion c = new Conexion();
        public int idTiempo;
        public string Fecha;
        public string Horainicio;
        public string Horafinal;
        public string descripcion;
        public string tarea;
        public string subtarea;
        
        public bool Agregar()
        {
            MySqlConnection conex = c.Conectar();
            try
            {
                string comando = "INSERT INTO Tiempo_tarea (tarea, desc_tarea, subtarea, fecha_inicio, hora_inicio, hora_finalizacion) VALUES (@tar,@desc,@sub,@fecha,@ini,@fin);";
                MySqlCommand cmd = new MySqlCommand(comando, conex);
                cmd.Parameters.AddWithValue("@tar", tarea);
                cmd.Parameters.AddWithValue("@desc", descripcion);
                cmd.Parameters.AddWithValue("@sub", subtarea);
                cmd.Parameters.AddWithValue("@fecha", Fecha);
                cmd.Parameters.AddWithValue("@ini", Horainicio);
                cmd.Parameters.AddWithValue("@fin", Horafinal);
               
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
        public bool Update()
        {
            MySqlConnection con = c.Conectar();
            try
            {
                string comando = "UPDATE Tiempo_tarea SET tarea=@tar, desc_tarea=@desc, subtarea=@sub, fecha_inicio=@fecha, hora_inicio=@ini, hora_finalizacion=@fin WHERE id_tiempotarea=@ID;";
                MySqlCommand cmd = new MySqlCommand(comando, con);
                cmd.Parameters.AddWithValue("@ID", idTiempo);
                cmd.Parameters.AddWithValue("@tar", tarea);
                cmd.Parameters.AddWithValue("@desc", descripcion);
                cmd.Parameters.AddWithValue("@sub", subtarea);
                cmd.Parameters.AddWithValue("@fecha", Fecha);
                cmd.Parameters.AddWithValue("@ini", Horainicio);
                cmd.Parameters.AddWithValue("@fin", Horafinal);
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
        public bool Eliminar()
        {
            MySqlConnection con = c.Conectar();
            try
            {
                string comando = "DELETE FROM Tiempo_tarea WHERE id_tiempotarea=@ID;";
                MySqlCommand command = new MySqlCommand(comando, con);
                command.Parameters.AddWithValue("@ID", idTiempo);
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
        public DataTable MostrarTiempoTarea()
        {
            string comando = "SELECT id_tiempotarea AS 'ID', tarea AS 'Tarea', desc_tarea AS 'Descripción de la tarea', subtarea AS 'SubTarea', fecha_inicio AS 'Fecha de inicio', hora_inicio AS 'Hora de inicio', hora_finalizacion AS 'Hora de finalización' FROM tiempo_tarea;";
            MySqlConnection cnx = c.Conectar();
            DataTable dt = new DataTable();

            MySqlDataAdapter adaptador = new MySqlDataAdapter(comando, cnx);
            adaptador.Fill(dt);

            return dt;
        }
    }

}
