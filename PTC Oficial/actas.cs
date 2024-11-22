using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Security.Policy;

namespace PTC_Oficial
{
    internal class actas
    {
        Conexion c = new Conexion();
        public int idActas;
        public int empleados;
        public string Razon;
        public string Empresa;
        public string Ciudad;
        public string Fecha;
        public string Hechos;
        public string Acusador;
        public string Cargo;
        public string Falta;

        public bool Agregar()
        {
            MySqlConnection conex = c.Conectar();
            try
            {
                string comando = "INSERT INTO Actasadministrativas (RazondelActa, NombreEmpresa, Ciudad, FechaActa, DescripcionHechos, NombredelAcusador, CargoDelEmpleadoAcusado, NumeroDeFalta, id_empleado) VALUES (@ra,@ne,@ciu,@fa,@dh,@na,@car,@nf,@emp);";
                MySqlCommand cmd = new MySqlCommand(comando, conex);
                cmd.Parameters.AddWithValue("@ra", Razon);
                cmd.Parameters.AddWithValue("@ne", Empresa);
                cmd.Parameters.AddWithValue("@ciu", Ciudad);
                cmd.Parameters.AddWithValue("@fa", Fecha);
                cmd.Parameters.AddWithValue("@dh", Hechos);
                cmd.Parameters.AddWithValue("@na", Acusador);
                cmd.Parameters.AddWithValue("@car", Cargo);
                cmd.Parameters.AddWithValue("@nf", Falta);
                cmd.Parameters.AddWithValue("@emp", empleados);


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
                string comando = "UPDATE Actasadministrativas SET RazondelActa=@ra, NombreEmpresa=@ne, Ciudad=@ciu, FechaActa=@fa, DescripcionHechos=@dh, NombredelAcusador=@na, CargoDelEmpleadoAcusado=@car, NumeroDeFalta=@nf, id_empleado=@emp WHERE idActas=@ID;";
                MySqlCommand cmd = new MySqlCommand(comando, con);
                cmd.Parameters.AddWithValue("@ID", idActas);
                cmd.Parameters.AddWithValue("@ra", Razon);
                cmd.Parameters.AddWithValue("@ne", Empresa);
                cmd.Parameters.AddWithValue("@ciu", Ciudad);
                cmd.Parameters.AddWithValue("@fa", Fecha);
                cmd.Parameters.AddWithValue("@dh", Hechos);
                cmd.Parameters.AddWithValue("@na", Acusador);
                cmd.Parameters.AddWithValue("@car", Cargo);
                cmd.Parameters.AddWithValue("@nf", Falta);
                cmd.Parameters.AddWithValue("@emp", empleados);
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
                string comando = "DELETE FROM Actasadministrativas WHERE idActas=@ID;";
                MySqlCommand command = new MySqlCommand(comando, con);
                command.Parameters.AddWithValue("@ID", idActas);
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
        public DataTable MostrarActas()
        {
            string comando = "SELECT idActas AS 'ID', RazondelActa AS 'Razon del acta', NombreEmpresa AS 'Nombre de empresa', Ciudad, FechaActa AS 'Fecha de acta', DescripcionHechos AS 'Descripción de hechos', NombredelAcusador AS 'Nombre del acusador', CargoDelEmpleadoAcusado AS 'Cargo del empleado acusado', NumeroDeFalta AS 'Numero de falta', nombres_y_apellidosUsuario AS 'Nombre completo' FROM Actasadministrativas AS a INNER JOIN Empleados AS e ON e.id_empleado = a.id_empleado;";
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
