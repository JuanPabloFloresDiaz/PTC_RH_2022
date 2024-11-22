using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace PTC_Oficial
{
    internal class Pagos
    {
        private int id_registroPago;
        private int id_formaPago;
        private int empleados;
        private string fecha_pago;
        private string fecha_vencimiento;
        Conexion c = new Conexion();
        //Para select
        public Pagos()
        {

        }
        //Para insert
        public Pagos(string fechaPago, string fechaVencimiento, int idFormaPago, int empleado)
        {
            fecha_pago = fechaPago;
            fecha_vencimiento = fechaVencimiento;
            id_formaPago = idFormaPago;
            empleados = empleado;
        }
        //para delete
        public Pagos(int idregistropago)
        {
            id_registroPago = idregistropago;
        }
        //Para update
        public Pagos(int idregistropago, string fechaPago, string fechaVencimiento, int idFormaPago, int empleado)
        {
            id_registroPago = idregistropago;
            fecha_pago = fechaPago;
            fecha_vencimiento = fechaVencimiento;
            id_formaPago = idFormaPago;
            empleados = empleado;
        }
        public bool Agregar()
        {
            string comando = "INSERT INTO registroPagos(fecha_pago,fecha_vencimiento, id_formaPago, id_empleado)" +
                 " VALUES('" + fecha_pago + "', '" + fecha_vencimiento + "', '" + id_formaPago + "', '" + empleados + "'); ";
            MySqlConnection con = c.Conectar();
            try
            {
                MySqlCommand cmd = new MySqlCommand(comando, con);
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


        
        public DataTable formaPago()
        {
            MySqlConnection CON = c.Conectar();
            try
            {
                string comando = "SELECT * FROM FormaPagos;";
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
        public DataTable Mostrar()
        {
            string comando = "SELECT id_registroPago AS 'id', fecha_pago AS 'Fecha de pago', fecha_vencimiento AS 'fecha de vencimiento', tipoForma_pago AS 'Forma de pago', nombres_y_apellidosUsuario AS 'Nombre completo' FROM registroPagos AS pv INNER JOIN FormaPagos AS p ON pv.id_formaPago = p.id_formaPago INNER JOIN Empleados AS e ON pv.id_empleado = e.id_empleado;";
            MySqlConnection cnx = c.Conectar();
            DataTable dt = new DataTable();

            MySqlDataAdapter adaptador = new MySqlDataAdapter(comando, cnx);
            adaptador.Fill(dt);

            return dt;
        }
        public bool Eliminar()
        {
            string comando = "DELETE FROM registroPagos WHERE id_registroPago='" + id_registroPago + "';";
            MySqlConnection con = c.Conectar();
            try
            {
                MySqlCommand command = new MySqlCommand(comando, con);
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
        public bool Actualizar()
        {
            string comando = "UPDATE registroPagos SET fecha_pago ='" + fecha_pago + "', fecha_vencimiento ='" + fecha_vencimiento + "', id_formaPago ='" + id_formaPago + "', id_empleado ='" + empleados + "' WHERE id_registroPago= '" + id_registroPago + "';";

            MySqlConnection con = c.Conectar();

            try
            {
                MySqlCommand command = new MySqlCommand(comando, con);
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
