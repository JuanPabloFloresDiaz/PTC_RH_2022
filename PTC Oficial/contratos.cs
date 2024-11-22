using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;

namespace PTC_Oficial
{
    internal class contratos
    {
        Conexion c = new Conexion();
        public int idContratos;
        public int empleados;
        public int nacionalidad;
        public int salario;
        public string Fecha;
        public string Empresa;
        public string apartir;
        public string hasta;
        public string Clausulas;
        public bool Agregar()
        {
            MySqlConnection conex = c.Conectar();
            try
            {
                string comando = "INSERT INTO Contratodeempleados (FechadeFirma, nombreEmpresa, id_empleado, idNacionalidad, ContratoAPartirDe, ContratoHasta, id_salario, Clausulas) VALUES (@ff,@ne,@emp,@nac,@ade,@has,@sal,@clau);";
                MySqlCommand cmd = new MySqlCommand(comando, conex);
                cmd.Parameters.AddWithValue("@ff", Fecha);
                cmd.Parameters.AddWithValue("@ne", Empresa);
                cmd.Parameters.AddWithValue("@emp", empleados);
                cmd.Parameters.AddWithValue("@nac", nacionalidad);
                cmd.Parameters.AddWithValue("@ade", apartir);
                cmd.Parameters.AddWithValue("@has", hasta);
                cmd.Parameters.AddWithValue("@sal", salario);
                cmd.Parameters.AddWithValue("@clau", Clausulas);
                

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
                string comando = "UPDATE Contratodeempleados SET FechadeFirma=@ff, nombreEmpresa=@ne, id_empleado=@emp, idNacionalidad=@nac, ContratoAPartirDe=@ade, ContratoHasta=@has, id_salario=@sal, Clausulas=@clau WHERE idContrato=@ID;";
                MySqlCommand cmd = new MySqlCommand(comando, con);
                cmd.Parameters.AddWithValue("@ID", idContratos);
                cmd.Parameters.AddWithValue("@ff", Fecha);
                cmd.Parameters.AddWithValue("@ne", Empresa);
                cmd.Parameters.AddWithValue("@emp", empleados);
                cmd.Parameters.AddWithValue("@nac", nacionalidad);
                cmd.Parameters.AddWithValue("@ade", apartir);
                cmd.Parameters.AddWithValue("@has", hasta);
                cmd.Parameters.AddWithValue("@sal", salario);
                cmd.Parameters.AddWithValue("@clau", Clausulas);
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
                string comando = "DELETE FROM Contratodeempleados WHERE idContrato=@ID;";
                MySqlCommand command = new MySqlCommand(comando, con);
                command.Parameters.AddWithValue("@ID", idContratos);
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
        public DataTable MostrarContratos()
        {
            string comando = "SELECT idContrato AS 'ID', FechadeFirma AS 'Fecha de firma', nombreEmpresa AS 'Nombre de la empresa', nombres_y_apellidosUsuario AS 'Nombre completo', nacionalidad AS 'Nacionalidad', ContratoAPartirDe AS 'Contrato a partir de', ContratoHasta AS 'Contrato hasta', salario_neto AS 'Salario neto', Clausulas FROM Contratodeempleados AS c INNER JOIN Empleados AS e ON e.id_empleado = c.id_empleado INNER JOIN Nacionalidades AS n ON n.idNacionalidad = c.idNacionalidad INNER JOIN salarios AS s ON s.id_salario = c.id_salario;";
            MySqlConnection cnx = c.Conectar();
            DataTable dt = new DataTable();

            MySqlDataAdapter adaptador = new MySqlDataAdapter(comando, cnx);
            adaptador.Fill(dt);

            return dt;
        }
        public DataTable Nacionalidades()
        {
            MySqlConnection CON = c.Conectar();
            try
            {

                string comando = "SELECT * FROM Nacionalidades;";
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
        public DataTable Salario()
        {
            MySqlConnection CON = c.Conectar();
            try
            {

                string comando = "SELECT * FROM salarios";
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
