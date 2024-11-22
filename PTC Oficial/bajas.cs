using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Security.Policy;
using System.Globalization;

namespace PTC_Oficial
{
    internal class bajas
    {
        Conexion c = new Conexion();
        public int idBajas;
        public int empleados;
        public int vacaciones;
        public int estatus;
        public string Fecha;
        public string Justificacion;
        public bool Agregar()
        {
            MySqlConnection conex = c.Conectar();
            try
            {
                string comando = "INSERT INTO Gestiondebajaslaborales (idGestionVacaciones, fecha, id_empleado, justificacion, idEstatus) VALUES (@gv,@fecha,@emp,@jus,@est);";
                MySqlCommand cmd = new MySqlCommand(comando, conex);
                cmd.Parameters.AddWithValue("@gv", vacaciones);
                cmd.Parameters.AddWithValue("@fecha", Fecha);
                cmd.Parameters.AddWithValue("@emp", empleados);
                cmd.Parameters.AddWithValue("@jus", Justificacion);
                cmd.Parameters.AddWithValue("@est", estatus);


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
                string comando = "UPDATE Gestiondebajaslaborales SET idGestionVacaciones=@gv, fecha=@fecha, id_empleado=@emp, justificacion=@jus, idEstatus=@est WHERE idGestiondebajaslaborales=@ID;";
                MySqlCommand cmd = new MySqlCommand(comando, con);
                cmd.Parameters.AddWithValue("@ID", idBajas);
                cmd.Parameters.AddWithValue("@gv", vacaciones);
                cmd.Parameters.AddWithValue("@fecha", Fecha);
                cmd.Parameters.AddWithValue("@emp", empleados);
                cmd.Parameters.AddWithValue("@jus", Justificacion);
                cmd.Parameters.AddWithValue("@est", estatus);
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
                string comando = "DELETE FROM Gestiondebajaslaborales WHERE idGestiondebajaslaborales=@ID;";
                MySqlCommand command = new MySqlCommand(comando, con);
                command.Parameters.AddWithValue("@ID", idBajas);
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
        public DataTable MostrarBajas()
        {
            string comando = "SELECT idGestiondebajaslaborales AS 'id', Fecha_Inicio AS 'Fecha de inicio de vacación', Fecha_Final AS 'Fecha final de vacaciones', fecha AS 'Fecha', nombres_y_apellidosUsuario AS 'Nombre completo', justificacion AS 'Justificación', estatu AS 'Estatu de la baja laboral' FROM Gestiondebajaslaborales AS g INNER JOIN Gestiondediasdevacaciones AS v ON v.idGestionVacaciones = g.idGestionVacaciones INNER JOIN empleados AS e ON e.id_empleado = g.id_empleado INNER JOIN estatus AS st ON st.idEstatus = g.idEstatus;";
            MySqlConnection cnx = c.Conectar();
            DataTable dt = new DataTable();

            MySqlDataAdapter adaptador = new MySqlDataAdapter(comando, cnx);
            adaptador.Fill(dt);

            return dt;
        }
        public DataTable Vacaciones()
        {
            MySqlConnection CON = c.Conectar();
            try
            {

                string comando = "SELECT * FROM Gestiondediasdevacaciones;";
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
        public DataTable Estatus()
        {
            MySqlConnection CON = c.Conectar();
            try
            {

                string comando = "SELECT * FROM Estatus";
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
