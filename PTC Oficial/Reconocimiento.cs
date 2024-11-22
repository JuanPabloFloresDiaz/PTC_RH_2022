using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace PTC_Oficial
{
    internal class Reconocimiento
    {
        Conexion c = new Conexion();
        public int idReconocimientos;
        public int empleado;
        public string Texto_Reconocimiento;
        public string FechadeReconocimiento;

        public bool Agregar()
        {
            Conexion c = new Conexion();
            MySqlConnection conex = c.Conectar();
            try
            {
                string comando = "insert into Historialdereconocimientos (Texto_Reconocimiento," +
                    "FechadeReconocimiento, id_empleado) values (@Reconocimiento,@Fecha,@empleado);";
                MySqlCommand cmd = new MySqlCommand(comando, conex);


                cmd.Parameters.AddWithValue("@Reconocimiento", Texto_Reconocimiento);
                cmd.Parameters.AddWithValue("@Fecha", FechadeReconocimiento);
                cmd.Parameters.AddWithValue("@empleado", empleado);

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {

                System.Windows.Forms.MessageBox.Show(e.Message);
                return false;
            }
            finally
            {

                conex.Close();

            }
        }
        public bool Update()
        {
            Conexion c = new Conexion();
            MySqlConnection conex = c.Conectar();
            try
            {
                string comando = "UPDATE Historialdereconocimientos SET Texto_Reconocimiento=@Reconocimiento, FechadeReconocimiento=@Fecha, id_empleado=@empleado WHERE idReconocimientos=@Id;";
                MySqlCommand command = new MySqlCommand(comando, conex);
                command.Parameters.AddWithValue("@Reconocimiento", Texto_Reconocimiento);
                command.Parameters.AddWithValue("@Fecha", FechadeReconocimiento);
                command.Parameters.AddWithValue("@empleado", empleado);
                command.Parameters.AddWithValue("@Id", idReconocimientos);
                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                conex.Close();
            }
        }
        public bool Eliminar()
        {
            Conexion c = new Conexion();
            MySqlConnection conex = c.Conectar();
            try
            {
                string comando = "DELETE FROM Historialdereconocimientos WHERE idReconocimientos=@ID;";
                MySqlCommand command = new MySqlCommand(comando, conex);
                command.Parameters.AddWithValue("@ID", idReconocimientos);
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
                conex.Close();
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
    }
}
