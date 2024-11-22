using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace PTC_Oficial
{
    internal class RegistroUsuarios
    {
        private int id_usuario;
        private int id_tipo_usuario;
        private string nombre_usuario;
        private string contrasena;
        private string correo_electronico;


        Encriptacion_De_Contraseñas_Por_MD5 encriptar = new Encriptacion_De_Contraseñas_Por_MD5();
        Conexion c = new Conexion();
        //Para select
        public RegistroUsuarios()
        {

        }
        //Para insert
        public RegistroUsuarios(string NAME, string E_Mail, string PASS, int tipeuser)
        {
            nombre_usuario = NAME;
            correo_electronico = E_Mail;
            contrasena = encriptar.Encriptar(PASS);
            id_tipo_usuario = tipeuser;
        }
        
        //para delete
        public RegistroUsuarios(int idu)
        {
            id_usuario = idu;
        }
        //Para update
        public RegistroUsuarios(int idu, string NAME, string E_Mail, string PASS, int tipeuser)
        {
            id_usuario = idu;
            nombre_usuario = NAME;
            correo_electronico = E_Mail;
            contrasena = encriptar.Encriptar(PASS);
            id_tipo_usuario = tipeuser;
        }
        public bool Agregar()
        {
            string comando = "INSERT INTO Usuarios(nombreUsuario,correoElectronico, contrasena, id_tipousuario)" +
                 " VALUES('" + nombre_usuario + "', '" + correo_electronico + "', '" + contrasena + "', '" + id_tipo_usuario + "'); ";
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

        public DataTable tipousuario()
        {
            MySqlConnection CON = c.Conectar();
            string comando = "SELECT * FROM Tipo_Usuarios;";
            MySqlDataAdapter adapter = new MySqlDataAdapter(comando, CON);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;
        }
        public bool Eliminar()
        {
            string comando = "DELETE FROM Usuarios WHERE id_Usuario='" + id_usuario + "';";
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
        public DataTable Mostrar()
        {
            string comando = "SELECT id_Usuario AS 'id', nombreUsuario AS 'Nombre del usuario', correoElectronico AS'Correo Electronico', contrasena AS 'Contraseña', tipousuario AS 'Tipo de usuario'FROM Usuarios AS pv INNER JOIN Tipo_Usuarios AS p ON pv.id_tipousuario = p.id_tipousuario;";
            MySqlConnection cnx = c.Conectar();
            DataTable dt = new DataTable();

            MySqlDataAdapter adaptador = new MySqlDataAdapter(comando, cnx);
            adaptador.Fill(dt);

            return dt;
        }

        public bool Actualizar()
        {
            string comando = "UPDATE Usuarios SET nombreUsuario ='" + nombre_usuario +  "', correoElectronico ='" + correo_electronico + "', contrasena ='" + contrasena + "', id_tipousuario ='" + id_tipo_usuario + "' WHERE id_Usuario= "+ id_usuario + ";";

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
