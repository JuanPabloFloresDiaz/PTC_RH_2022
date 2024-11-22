using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
namespace PTC_Oficial
{
    internal class cumplimiento
    {
        Conexion c = new Conexion();
        public int idCumplimiento;
        public int Empleado;
        public int Calidad;
        public int Eficiencia;
        public int Entornolaboral;
        public int Actitud;
        public int Esfuerzo;
        public int Trabajoenequipo;

        public bool Agregar()
        {
            MySqlConnection conex = c.Conectar();
            try
            {
                string comando = "INSERT INTO Cumplimiento_empleados (ProductividadYCalidad, Eficiencia, PresenciaenEntornoLaboral, Actitud, Esfuerzo, TrabajoenEquipo, id_empleado) VALUES (@pc,@efi,@pel,@act,@esf,@te,@emp);";
                MySqlCommand cmd = new MySqlCommand(comando, conex);
                cmd.Parameters.AddWithValue("@pc", Calidad);
                cmd.Parameters.AddWithValue("@efi", Eficiencia);
                cmd.Parameters.AddWithValue("@pel", Entornolaboral);
                cmd.Parameters.AddWithValue("@act", Actitud);
                cmd.Parameters.AddWithValue("@esf", Esfuerzo);
                cmd.Parameters.AddWithValue("@te", Trabajoenequipo);
                cmd.Parameters.AddWithValue("@emp", Empleado);
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
                string comando = "UPDATE Cumplimiento_empleados SET ProductividadYCalidad=@pc, Eficiencia=@efi, PresenciaenEntornoLaboral=@pel, Actitud=@act, Esfuerzo=@esf, TrabajoenEquipo=@te, id_empleado=@emp WHERE idCumplimiento=@idCumplimiento;";
                MySqlCommand cmd = new MySqlCommand(comando, con);
                cmd.Parameters.AddWithValue("@idCumplimiento", idCumplimiento);
                cmd.Parameters.AddWithValue("@pc", Calidad);
                cmd.Parameters.AddWithValue("@efi", Eficiencia);
                cmd.Parameters.AddWithValue("@pel", Entornolaboral);
                cmd.Parameters.AddWithValue("@act", Actitud);
                cmd.Parameters.AddWithValue("@esf", Esfuerzo);
                cmd.Parameters.AddWithValue("@te", Trabajoenequipo);
                cmd.Parameters.AddWithValue("@emp", Empleado);
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
                string comando = "DELETE FROM Cumplimiento_empleados WHERE idCumplimiento=@idCumplimiento;";
                MySqlCommand command = new MySqlCommand(comando, con);
                command.Parameters.AddWithValue("@idCumplimiento", idCumplimiento);
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
        public DataTable MostrarCumplimiento()
        {
            string comando = "SELECT idCumplimiento AS 'ID', ProductividadYCalidad AS 'Productividad y calidad', Eficiencia, PresenciaenEntornoLaboral AS 'Presencia en entorno laboral', Actitud, Esfuerzo, TrabajoenEquipo AS 'Trabajo en equipo', nombres_y_apellidosUsuario AS 'Nombre completo' FROM cumplimiento_empleados AS ce INNER JOIN empleados AS e ON e.id_empleado = ce.id_empleado;";
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
    }
}
