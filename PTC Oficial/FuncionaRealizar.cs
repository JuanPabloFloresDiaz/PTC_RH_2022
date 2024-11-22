using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace PTC_Oficial
{
    internal class FuncionaRealizar
    {
        private int id;
        private string Funcion;

        Conexion c = new Conexion();
        //Para select
        public FuncionaRealizar()
        {

        }
        //Pare insert
        public FuncionaRealizar(string FUNCIONES)
        {
            Funcion = FUNCIONES;
        }
        //Para delete
        public FuncionaRealizar(int idf)
        {
            id = idf;
        }
        //Para update
        public FuncionaRealizar(int idf, string FUNCIONES)
        {
            id = idf;
            Funcion = FUNCIONES;
        }
        public bool Agregar()
        {
            string comando = "INSERT INTO Funcionesarealizar (funcionarealizar) VALUES('" + Funcion + "');";
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
        public DataTable MostrarFunciones()
        {
            string comando = "SELECT idfuncion AS 'id', funcionarealizar AS 'Funciones a realizar' FROM Funcionesarealizar;";
            MySqlConnection cnx = c.Conectar();
            DataTable dt = new DataTable();

            MySqlDataAdapter adaptador = new MySqlDataAdapter(comando, cnx);
            adaptador.Fill(dt);

            return dt;
        }
        public bool Eliminar()
        {
            string comando = "DELETE FROM Funcionesarealizar WHERE idfuncion='" + id + "';";
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
            string comando = "UPDATE Funcionesarealizar SET funcionarealizar = '" + Funcion + "' WHERE idfuncion ='" + id + "';";

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
