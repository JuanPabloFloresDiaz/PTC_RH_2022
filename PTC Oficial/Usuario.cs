using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace PTC_Oficial
{
    class Usuario
    {
        
        public static bool Verificar()
        {
            try
            {
                Conexion c = new Conexion();
                string comando = "SELECT * FROM Usuarios";
                
                MySqlConnection con = c.Conectar();
                MySqlCommand cmd = new MySqlCommand(comando, con);
                MySqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read() == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Error de conexión", "Alerta", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                Environment.Exit(0);
                return true;
            }
        }
        public static bool Agregar(string Usuario, string Clave, string Correo, int Tipousuario)
        {
            try
            {
                Conexion c = new Conexion();
                MySqlConnection con = c.Conectar();
                string comando = "INSERT INTO Usuarios(nombreUsuario,correoElectronico, contrasena, id_tipousuario) VALUES (@nombreUsuario,@correoElectronico,@contrasena,@tipousuario);";

                MySqlCommand cmd = new MySqlCommand(comando, con);

                cmd.Parameters.AddWithValue("@nombreUsuario", Usuario);
                cmd.Parameters.AddWithValue("@correoElectronico", Correo);
                Encriptacion_De_Contraseñas_Por_MD5 encriptar = new Encriptacion_De_Contraseñas_Por_MD5();
                Clave = encriptar.Encriptar(Clave);
                cmd.Parameters.AddWithValue("@contrasena", Clave);
             
                cmd.Parameters.AddWithValue("@tipousuario", Tipousuario);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("ERROR: "+ex.Message, "Alerta", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
        }
        public DataTable tipousuario()
        {
            Conexion c = new Conexion();
            MySqlConnection CON = c.Conectar();
            string comando = "SELECT * FROM Tipo_Usuarios;";
            MySqlDataAdapter adapter = new MySqlDataAdapter(comando, CON);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;
        }
    }
}
