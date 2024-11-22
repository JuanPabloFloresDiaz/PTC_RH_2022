using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace PTC_Oficial
{
    internal class control
    {
        Conexion c = new Conexion();
        public int idControl;
        public int dia;
        public int tiempotarea;
        public int empleados;
        public string entrada;
        public string salida;
        public string inicio;
        public string finalizacion;
        public string Fecha;
        public string horas;
        public string NIT;
        public bool Agregar()
        {
            MySqlConnection conex = c.Conectar();
            try
            {
                string comando = "INSERT INTO Controldehorario (id_dia, entrada, salida, descansode, decansoa, horas_trabajadas, NIT, Fecha, id_empleado, id_tiempotarea) VALUES (@dia,@ent,@sal,@de,@a,@horas,@NIT,@Fecha,@emp,@tiempo);";
                MySqlCommand cmd = new MySqlCommand(comando, conex);
                cmd.Parameters.AddWithValue("@dia", dia);
                cmd.Parameters.AddWithValue("@ent", entrada);
                cmd.Parameters.AddWithValue("@sal", salida);
                cmd.Parameters.AddWithValue("@de", inicio);
                cmd.Parameters.AddWithValue("@a", finalizacion);
                cmd.Parameters.AddWithValue("@horas", horas);
                cmd.Parameters.AddWithValue("@NIT", NIT);
                cmd.Parameters.AddWithValue("@Fecha", Fecha);
                cmd.Parameters.AddWithValue("@emp", empleados);
                cmd.Parameters.AddWithValue("@tiempo", tiempotarea);

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
                string comando = "UPDATE Controldehorario SET id_dia=@dia, entrada=@ent, salida=@sal, descansode=@de, decansoa=@a, horas_trabajadas=@horas, NIT=@NIT, Fecha=@Fecha, id_empleado=@emp, id_tiempotarea=@tiempo WHERE id_Controldehorario=@ID;";
                MySqlCommand cmd = new MySqlCommand(comando, con);
                cmd.Parameters.AddWithValue("@ID", idControl);
                cmd.Parameters.AddWithValue("@dia", dia);
                cmd.Parameters.AddWithValue("@ent", entrada);
                cmd.Parameters.AddWithValue("@sal", salida);
                cmd.Parameters.AddWithValue("@de", inicio);
                cmd.Parameters.AddWithValue("@a", finalizacion);
                cmd.Parameters.AddWithValue("@horas", horas);
                cmd.Parameters.AddWithValue("@NIT", NIT);
                cmd.Parameters.AddWithValue("@Fecha", Fecha);
                cmd.Parameters.AddWithValue("@emp", empleados);
                cmd.Parameters.AddWithValue("@tiempo", tiempotarea);
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
                string comando = "DELETE FROM Controldehorario WHERE id_Controldehorario=@ID;";
                MySqlCommand command = new MySqlCommand(comando, con);
                command.Parameters.AddWithValue("@ID", idControl);
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
        public DataTable MostrarControl()
        {
            string comando = "SELECT id_Controldehorario AS 'ID', dia AS 'Dia', entrada AS 'Entrada', salida AS 'Salida', descansode AS 'Descanso de', decansoa AS 'Descanso a', horas_trabajadas AS 'Horas trabajadas', NIT, Fecha, nombres_y_apellidosUsuario AS 'Nombre completo', tarea AS 'Tarea', desc_tarea AS 'Descripción de la tarea', subtarea AS 'SubTarea', fecha_inicio AS 'Fecha de inicio', hora_inicio AS 'Hora de inicio', hora_finalizacion AS 'Hora de finalización' FROM controldehorario AS ch INNER JOIN dias AS d ON d.id_dia = ch.id_dia INNER JOIN empleados AS e ON e.id_empleado = ch.id_empleado INNER JOIN tiempo_tarea AS tt ON tt.id_tiempotarea = ch.id_tiempotarea;";
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
        public DataTable Tiempoportarea()
        {
            MySqlConnection CON = c.Conectar();
            try
            {

                string comando = "SELECT * FROM Tiempo_tarea";
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
