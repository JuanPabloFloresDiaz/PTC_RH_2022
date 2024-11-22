using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
namespace PTC_Oficial
{
    internal class Calendario
    {

        private int id;
        private int dia;
        private int funcionesarealizar;
        private int empleados;
        private string Fecha;
        private string Horas;
      

        Conexion c = new Conexion();

        //para select 
        public Calendario()
        {

        }
        //Para insert
        public Calendario(string fecha, string horas, int Dia, int funcion, int empleado)
        {
            Fecha = fecha;
            Horas = horas;
            dia = Dia;
            funcionesarealizar = funcion;
            empleados = empleado;
        }
        //para delete
        public Calendario(int idh)
        {
            id = idh;
        }
        //para update
        public Calendario(int idh, string fecha, string horas, int Dia, int funcion, int empleado)
        {
            id = idh;
            Fecha = fecha;
            Horas = horas;
            dia = Dia;
            funcionesarealizar = funcion;
            empleados = empleado;
        }


        public bool Agregar()
        {
            string comando = "INSERT INTO calendariodetrabajo (fecha, horas, id_dia, idfuncion, id_empleado) VALUES('" + Fecha + "', '" + Horas + "', '" + dia + "', '" + funcionesarealizar + "', '" + empleados + "');";
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
        public DataTable MostrarCalendario()
        {
            string comando = "SELECT idCalendario AS 'id', fecha AS 'Fecha', horas AS 'Horas', dia AS 'Dia de semana', funcionarealizar AS 'Funciones a realizar', nombres_y_apellidosUsuario AS 'Nombre completo' FROM calendariodetrabajo AS c INNER JOIN dias AS d ON d.id_dia = c.id_dia INNER JOIN funcionesarealizar AS f ON f.idfuncion = c.idfuncion INNER JOIN empleados AS e ON e.id_empleado = c.id_empleado;";
            MySqlConnection cnx = c.Conectar();
            DataTable dt = new DataTable();

            MySqlDataAdapter adaptador = new MySqlDataAdapter(comando, cnx);
            adaptador.Fill(dt);

            return dt;
        }

        public bool Eliminar()
        {
            string comando = "DELETE FROM calendariodetrabajo WHERE idCalendario='" + id + "';";
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
            string comando = "UPDATE calendariodetrabajo SET fecha = '" + Fecha + "', horas = '" + Horas + "', id_dia = '" + dia + "', idfuncion = '" + funcionesarealizar + "', id_empleado = '" + empleados + "' WHERE idCalendario ='" + id + "';";

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
        public DataTable Funciones()
        {
            MySqlConnection CON = c.Conectar();
            try
            {
                string comando = "SELECT * FROM Funcionesarealizar;";
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
    }
}
