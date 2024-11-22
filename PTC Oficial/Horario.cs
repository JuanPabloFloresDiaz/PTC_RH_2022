using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
namespace PTC_Oficial
{
    internal class Horario
    {
        Conexion c = new Conexion();
        public int idHorario;
        public int dia;
        public int turno;
        public int empleados;
        public string Fecha;
        public string Horas;
        
        public bool Agregar()
        {
            MySqlConnection conex = c.Conectar();
            try
            {
                string comando = "INSERT INTO Horarios (hora, fecha, id_dia, id_turno, id_empleado) VALUES (@hora,@fecha,@dia,@turno,@empleado);";
                MySqlCommand cmd = new MySqlCommand(comando, conex);
                cmd.Parameters.AddWithValue("@hora", Horas);
                cmd.Parameters.AddWithValue("@fecha", Fecha);
                cmd.Parameters.AddWithValue("@dia", dia);
                cmd.Parameters.AddWithValue("@turno", turno);
                cmd.Parameters.AddWithValue("@empleado", empleados);
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
                string comando = "DELETE FROM Horarios WHERE id_horario=@ID;";
                MySqlCommand command = new MySqlCommand(comando, con);
                command.Parameters.AddWithValue("@ID", idHorario);
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
                string comando = "UPDATE Horarios SET hora=@hora, fecha=@fecha, id_dia=@dia, id_turno=@turno, id_empleado=@empleado WHERE id_horario=@ID;";
                MySqlCommand cmd = new MySqlCommand(comando, con);
                cmd.Parameters.AddWithValue("@ID", idHorario);
                cmd.Parameters.AddWithValue("@hora", Horas);
                cmd.Parameters.AddWithValue("@fecha", Fecha);
                cmd.Parameters.AddWithValue("@dia", dia);
                cmd.Parameters.AddWithValue("@turno", turno);
                cmd.Parameters.AddWithValue("@empleado", empleados);
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
        public DataTable MostrarHorario()
        {
            string comando = "SELECT id_horario AS 'id', hora AS 'Hora', fecha AS 'Fecha', dia AS 'Dia', Tipo_turno AS 'Turno', nombres_y_apellidosUsuario AS 'Nombre del empleado' FROM Horarios AS pv INNER JOIN Turnos AS p ON pv.id_turno = p.id_turno INNER JOIN Dias AS d ON pv.id_dia = d.id_dia INNER JOIN Empleados AS e ON pv.id_empleado = e.id_empleado;";
            MySqlConnection cnx = c.Conectar();
            DataTable dt = new DataTable();

            MySqlDataAdapter adaptador = new MySqlDataAdapter(comando, cnx);
            adaptador.Fill(dt);
            
            return dt;
        }
        public DataTable Dias()
        {
            MySqlConnection CON = c.Conectar();
            try
            {

                string comando = "SELECT * FROM Dias;";
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
        public DataTable Turnos()
        {
            MySqlConnection CON = c.Conectar();
            try
            {

                string comando = "SELECT * FROM Turnos";
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
