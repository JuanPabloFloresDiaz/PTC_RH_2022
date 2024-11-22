using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
namespace PTC_Oficial
{
    internal class Salario
    {
        Conexion c = new Conexion();
        public int idSalario;
        public int RegistroPago;
        public int descuento;
        public string Salariobruto;
        public string Salarioneto;
        public string horasextra;
        public byte[] Cotizaciones;

        public bool Agregar()
        {
            MySqlConnection conex = c.Conectar();
            try
            {
                string comando = "INSERT INTO salarios (salario_bruto, contizaciones, salario_neto, horas_extras, id_registroPago, id_descuento) VALUES (@bruto,@cotizacion,@neto,@horas,@registro,@descuento);";
                MySqlCommand cmd = new MySqlCommand(comando, conex);
                cmd.Parameters.AddWithValue("@bruto", Salariobruto);
                cmd.Parameters.AddWithValue("@cotizacion", Cotizaciones);
                cmd.Parameters.AddWithValue("@neto", Salarioneto);
                cmd.Parameters.AddWithValue("@horas", horasextra);
                cmd.Parameters.AddWithValue("@registro", RegistroPago);
                cmd.Parameters.AddWithValue("@descuento", descuento);
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
                string comando = "DELETE FROM salarios WHERE id_salario=@ID;";
                MySqlCommand command = new MySqlCommand(comando, con);
                command.Parameters.AddWithValue("@ID", idSalario);
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
                string comando = "UPDATE salarios SET salario_bruto=@bruto, contizaciones=@cotizacion, salario_neto=@neto, horas_extras=@horas, id_registroPago=@registro, id_descuento=@descuento WHERE id_salario=@ID;";
                MySqlCommand cmd = new MySqlCommand(comando, con);
                cmd.Parameters.AddWithValue("@ID", idSalario);
                cmd.Parameters.AddWithValue("@bruto", Salariobruto);
                cmd.Parameters.AddWithValue("@cotizacion", Cotizaciones);
                cmd.Parameters.AddWithValue("@neto", Salarioneto);
                cmd.Parameters.AddWithValue("@horas", horasextra);
                cmd.Parameters.AddWithValue("@registro", RegistroPago);
                cmd.Parameters.AddWithValue("@descuento", descuento);
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
        public DataTable MostrarSalario()
        {
            string comando = "SELECT id_salario AS 'id', nombres_y_apellidosUsuario AS 'Nombre del empleado', fecha_pago AS 'Fecha de pago', fecha_vencimiento AS 'Fecha de vencimiento', tipoForma_pago AS'Forma de pago', tipo_descuento AS 'Descuento', salario_bruto AS 'Salario bruto', contizaciones AS 'Cotizaciones', salario_neto AS 'Salario neto', horas_extras AS 'Horas extra' FROM Salarios AS pv INNER JOIN FormaPagos AS f ON f.id_formaPago = pv.id_salario INNER JOIN registroPagos AS p ON p.id_registroPago = pv.id_registroPago INNER JOIN descuentos AS d ON d.id_descuento = pv.id_descuento INNER JOIN empleados AS e ON e.id_empleado = pv.id_salario;";
            MySqlConnection cnx = c.Conectar();
            DataTable dt = new DataTable();

            MySqlDataAdapter adaptador = new MySqlDataAdapter(comando, cnx);
            adaptador.Fill(dt);

            return dt;
        }
        public DataTable Pagos()
        {
            MySqlConnection CON = c.Conectar();
            try
            {
                string comando = "SELECT * FROM registroPagos;";
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
        public DataTable Descuentos()
        {
            MySqlConnection CON = c.Conectar();
            try
            {

                string comando = "SELECT * FROM descuentos;";
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
