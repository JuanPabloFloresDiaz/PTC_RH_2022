using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
namespace PTC_Oficial
{
    internal class nominas
    {
        Conexion c = new Conexion();
        public int idnominas;
        public int empleados;
        public int salario;
        public string aguinaldo;

        public bool Agregar()
        {
            MySqlConnection conex = c.Conectar();
            try
            {
                string comando = "INSERT INTO Nominas (id_empleado, Aguinaldo, id_salario) VALUES (@emp,@agu,@sal);";
                MySqlCommand cmd = new MySqlCommand(comando, conex);
                cmd.Parameters.AddWithValue("@emp", empleados);
                cmd.Parameters.AddWithValue("@agu", aguinaldo);
                cmd.Parameters.AddWithValue("@sal", salario);
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
                string comando = "DELETE FROM Nominas WHERE idNomina=@ID;";
                MySqlCommand command = new MySqlCommand(comando, con);
                command.Parameters.AddWithValue("@ID", idnominas);
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
                string comando = "UPDATE Nominas SET id_empleado=@emp, Aguinaldo=@agu, id_salario=@sal WHERE idGestionVacaciones=@ID;";
                MySqlCommand cmd = new MySqlCommand(comando, con);
                cmd.Parameters.AddWithValue("@ID", idnominas);
                cmd.Parameters.AddWithValue("@emp", empleados);
                cmd.Parameters.AddWithValue("@agu", aguinaldo);
                cmd.Parameters.AddWithValue("@sal", salario);
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

        public DataTable MostrarNomina()
        {
            string comando = "SELECT idNomina AS 'id', nombres_y_apellidosUsuario AS 'Nombre completo', Aguinaldo, salario_bruto AS 'Salario bruto', salario_neto AS 'Salario neto' FROM Nominas AS n INNER JOIN Empleados AS e ON e.id_empleado = n.id_empleado INNER JOIN Salarios AS s ON s.id_salario = n.id_salario;";
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
        public DataTable Salarios()
        {
            MySqlConnection CON = c.Conectar();
            try
            {

                string comando = "SELECT * FROM Salarios";
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
