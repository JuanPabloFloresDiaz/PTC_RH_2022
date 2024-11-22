using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;


namespace PTC_Oficial
{
     class Encriptacion_De_Contraseñas_Por_MD5
    {
        public string Encriptar (string Mensaje)
        {
            string hash = "coding con c";
            byte[] data = UTF8Encoding.UTF8.GetBytes(Mensaje);

            MD5 md5 = MD5.Create();
            TripleDES tripleDES = TripleDES.Create();

            tripleDES.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
            tripleDES.Mode = CipherMode.ECB;

            ICryptoTransform transformar = tripleDES.CreateEncryptor();
            byte[] resultado = transformar.TransformFinalBlock(data, 0, data.Length);

            return Convert.ToBase64String(resultado);
        }
       
        public string LETMD5(string textoEncriptado)
        {
            try
            {
                string key = "coding con c";
                byte[] keyArray;
                byte[] Array_a_Descifrar = Convert.FromBase64String(textoEncriptado);
                //algoritmo MD5
                MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
                keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                hashmd5.Clear();
                TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
                tdes.Key = keyArray;
                tdes.Mode = CipherMode.ECB;
                tdes.Padding = PaddingMode.PKCS7;
                ICryptoTransform cTransform = tdes.CreateDecryptor();
                byte[] resultArray = cTransform.TransformFinalBlock(Array_a_Descifrar, 0, Array_a_Descifrar.Length);
                tdes.Clear();
                textoEncriptado = UTF8Encoding.UTF8.GetString(resultArray);
            }
            catch (Exception)
            {
            }
            return textoEncriptado;
        }
    }
}
