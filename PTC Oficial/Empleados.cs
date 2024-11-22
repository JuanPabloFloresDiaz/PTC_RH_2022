using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace PTC_Oficial
{
    internal class Empleados
    {
        private int id;
        private int Area;
        private int Genero;
        private int Usuario;
        private string Nacimiento;
        private string Ingreso;
        private string NombreCompleto;
        private string Direccion;

        Conexion c = new Conexion();

        //para select 
        public Empleados()
        {

        }
        //Para insert
        public Empleados( string ingreso, string nombres, string fechanacimiento, string direccion, int area, int sexo, int usuario)
        {
            Ingreso = ingreso;
            NombreCompleto = nombres;
            Nacimiento = fechanacimiento;
            Direccion = direccion;
            Area = area;
            Genero = sexo;
            Usuario = usuario;
        }
        //para delete
        public Empleados(int idh)
        {
            id = idh;
        }
        //para update
        public Empleados(int idh, string ingreso, string nombres, string fechanacimiento, string direccion, int area, int sexo, int usuario)
        {
            id = idh;
            Ingreso = ingreso;
            NombreCompleto = nombres;
            Nacimiento = fechanacimiento;
            Direccion = direccion;
            Area = area;
            Genero = sexo;
            Usuario = usuario;
        }
        //Update en otro form
        public Empleados(int idh, string direccion)
        {
            id = idh;
            Direccion = direccion;
        }

        public bool Agregar()
        {
            string comando = "INSERT INTO Empleados (fecha_ingreso, nombres_y_apellidosUsuario, fecha_nacimiento_empleado, direccion_empleado, idArea, id_genero, id_Usuario) VALUES('" + Ingreso + "', '" + NombreCompleto + "', '" + Nacimiento + "', '" + Direccion + "', '" + Area + "', '" + Genero + "', '" + Usuario + "');";
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
        public bool Eliminar()
        {
            string comando = "DELETE FROM Empleados WHERE id_empleado='" + id + "';";
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
            string comando = "UPDATE Empleados SET fecha_ingreso = '" + Ingreso + "', nombres_y_apellidosUsuario = '" + NombreCompleto + "', fecha_nacimiento_empleado = '" + Nacimiento + "', direccion_empleado = '" + Direccion + "', idArea = '" + Area + "', id_genero = '" + Genero + "', id_Usuario = '" + Usuario + "' WHERE id_empleado = '" + id + "';";

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
        public bool ActualizarF()
        {
            string comando = "UPDATE Empleados SET direccion_empleado = '" + Direccion + "' WHERE id_empleado = '" + id + "';";

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
        public DataTable Areas()
        {
            MySqlConnection CON = c.Conectar();
            try
            {

                string comando = "SELECT * FROM Areasdetrabajo";
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
        public DataTable Generos()
        {
            MySqlConnection CON = c.Conectar();
            try
            {

                string comando = "SELECT * FROM Generos";
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
        public DataTable Usuarios()
        {
            MySqlConnection CON = c.Conectar();
            try
            {

                string comando = "SELECT * FROM Usuarios";
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
