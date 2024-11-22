using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PTC_Oficial
{
    internal class Inicio_Sesion
    {
        public int id_tipousuario;
        private string nombre_usuario;
        private string contrasena;
        Encriptacion_De_Contraseñas_Por_MD5 encriptar = new Encriptacion_De_Contraseñas_Por_MD5();
        Conexion c = new Conexion();
        //Para select
        public Inicio_Sesion()
        {

        }
        //Para insert
        public Inicio_Sesion(string NAME, string PASS)
        {
            nombre_usuario = NAME;
            contrasena = encriptar.Encriptar(PASS);
        }
        public Inicio_Sesion LOGIN()
        {
            MySqlConnection conexion = c.Conectar();

            string comando = "SELECT nombreUsuario , contrasena , id_tipousuario FROM Usuarios WHERE nombreUsuario=@NAME AND contrasena=@PASS;";
            MySqlCommand cmd = new MySqlCommand(comando, conexion);

            cmd.Parameters.AddWithValue("@NAME", string.Format(nombre_usuario));
            cmd.Parameters.AddWithValue("@PASS", string.Format(contrasena));

            MySqlDataReader lector = cmd.ExecuteReader();

            if (lector.Read() == true)
            {
                Inicio_Sesion inicio = new Inicio_Sesion();
                inicio.nombre_usuario = lector[0].ToString();
                inicio.contrasena = lector[1].ToString();
                inicio.id_tipousuario = int.Parse(lector[2].ToString());
                conexion.Close();
                return inicio;
            }
            else
            {
                conexion.Close();
                return null;
            }
        }
    }
}