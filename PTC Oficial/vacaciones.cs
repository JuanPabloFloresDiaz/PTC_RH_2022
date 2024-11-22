using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace PTC_Oficial
{
    internal class vacaciones
    {
        Conexion c = new Conexion();
        public int idGestionVacaciones;
        public int empleados;
        public string Fecha_Inicio;
        public string Fecha_Final;

        public bool Agregar()
        {
            MySqlConnection conex = c.Conectar();
            try
            {
                string comando = "INSERT INTO Gestiondediasdevacaciones (Fecha_Inicio, Fecha_Final, id_empleado) VALUES (@Inicio,@Final,@empleado);";
                MySqlCommand cmd = new MySqlCommand(comando, conex);
                cmd.Parameters.AddWithValue("@Inicio", Fecha_Inicio);
                cmd.Parameters.AddWithValue("@Final", Fecha_Final);
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
                string comando = "DELETE FROM Gestiondediasdevacaciones WHERE idGestionVacaciones=@ID;";
                MySqlCommand command = new MySqlCommand(comando, con);
                command.Parameters.AddWithValue("@ID", idGestionVacaciones);
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
                string comando = "UPDATE Gestiondediasdevacaciones SET Fecha_Inicio=@Inicio, Fecha_Final=@Final, id_empleado=@empleado WHERE idGestionVacaciones=@ID;";
                MySqlCommand cmd = new MySqlCommand(comando, con);
                cmd.Parameters.AddWithValue("@ID", idGestionVacaciones);
                cmd.Parameters.AddWithValue("@Inicio", Fecha_Inicio);
                cmd.Parameters.AddWithValue("@Final", Fecha_Final);
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

        public DataTable MostrarVacaciones()
        {
            string comando = "SELECT idGestionVacaciones AS 'id', Fecha_Inicio AS 'Fecha Inicio', Fecha_Final AS 'Fecha Final', nombres_y_apellidosUsuario AS 'Nombre completo' FROM Gestiondediasdevacaciones AS g INNER JOIN Empleados AS e ON e.id_empleado = g.id_empleado;";
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
