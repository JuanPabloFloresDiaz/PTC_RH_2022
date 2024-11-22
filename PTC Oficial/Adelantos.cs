using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
namespace PTC_Oficial
{
    internal class Adelantos
    {
        private int id;
        private int empleados;
        private int dia;
        private int estatus;
        private string Fecha;
        private string Hora;
        private string Justificacion;
        Conexion c = new Conexion();
        //Para select
        public Adelantos()
        {

        }
        //Para insert
        public Adelantos(int Dia, string hora, string fecha, int empleado, string jusificacion)
        {
            dia = Dia;
            Hora = hora;
            Fecha = fecha;
            empleados = empleado;
            Justificacion = jusificacion;
        }
        //Para delete
        public Adelantos(int idP)
        {
            id = idP;
        }
        //Para update
        public Adelantos(int idP, int Dia, string hora, string fecha, int empleado, string jusificacion)
        {
            id = idP;
            dia = Dia;         
            Hora = hora; 
            Fecha = fecha;
            empleados = empleado;
            Justificacion = jusificacion;
        }
        //Para Estatus
        public Adelantos(int idp, int estatu)
        {
            id = idp;
            estatus = estatu;
        }

        public bool Agregar()
        {
            string comando = "INSERT INTO adelantos_salariales (id_dia, hora, fecha, id_empleado, justificacion) VALUES('" + dia + "', '" + Hora + "', '" + Fecha + "', '" + empleados + "', '" + Justificacion + "');";
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

        public DataTable MostrarAdelantos()
        {
            string comando = "SELECT id_adelantos AS 'id', dia AS 'Dia', hora AS 'Hora', fecha AS 'Fecha', nombres_y_apellidosUsuario AS 'Nombre del empleado', justificacion AS 'Justificacion', estatu AS 'Estatu del adelanto' FROM adelantos_salariales AS pv INNER JOIN dias AS p ON pv.id_dia = p.id_dia INNER JOIN Empleados AS e ON pv.id_empleado = e.id_empleado LEFT JOIN estatus AS st ON pv.idEstatus = st.idEstatus;";
            MySqlConnection cnx = c.Conectar();
            DataTable dt = new DataTable();

            MySqlDataAdapter adaptador = new MySqlDataAdapter(comando, cnx);
            adaptador.Fill(dt);

            return dt;
        }
        public bool Eliminar()
        {
            string comando = "DELETE FROM adelantos_salariales WHERE id_adelantos='" + id + "';";
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
            string comando = "UPDATE adelantos_salariales SET id_dia = '" + dia + "', hora = '" + Hora + "', fecha = '" + Fecha + "', id_empleado = '" + empleados + "', justificacion = '" + Justificacion + "' WHERE id_adelantos ='" + id + "';";

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
        public bool ActualizarEstatus()
        {
            string comando = "UPDATE adelantos_salariales SET idEstatus = '" + estatus + "' WHERE id_adelantos ='" + id + "';";

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
    }
}
