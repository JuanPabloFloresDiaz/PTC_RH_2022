using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace PTC_Oficial
{
    internal class Conexion
    {
        string servidor, usuario, basededatos, cadena;
        MySqlConnection conector;

        public Conexion()
        {
            usuario = "root";
            servidor = "127.0.0.1";
            basededatos = "PTC";

            cadena = "server=" + servidor + ";uid=" + usuario + ";database=" + basededatos;

            conector = new MySqlConnection(cadena);
        }


        public MySqlConnection Conectar()
        {
                conector.Open();
                return conector;
        }
    }
}
