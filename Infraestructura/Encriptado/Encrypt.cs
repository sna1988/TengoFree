using System;
using System.Security.Cryptography;
using System.Text;

namespace Infrastructure.Encriptado
{
    public class Encrypt
    {
        readonly string _key = "ABCDEFG54669525PQRSTUVWXYZabcdef852846opqrstuvwxyz";
        
        public string EncryptKey(string cadena)
        {
            byte[] keyArray;
            byte[] Arreglo_a_Cifrar = UTF8Encoding.UTF8.GetBytes(cadena);

            var hashmd5 = new MD5CryptoServiceProvider();

            keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(_key));

            hashmd5.Clear();

            var tdes = new TripleDESCryptoServiceProvider();

            tdes.Key = keyArray;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform = tdes.CreateEncryptor();

            byte[] ArrayResultado = cTransform.TransformFinalBlock(Arreglo_a_Cifrar, 0, Arreglo_a_Cifrar.Length);

            tdes.Clear();

            return Convert.ToBase64String(ArrayResultado, 0, ArrayResultado.Length);
        }

        public string DecryptKey(string clave)
        {
            byte[] keyArray;

            byte[] Array_a_Descifrar = Convert.FromBase64String(clave);

            var hashmd5 = new MD5CryptoServiceProvider();

            keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(_key));

            hashmd5.Clear();
            
            var tdes = new TripleDESCryptoServiceProvider();
            
            tdes.Key = keyArray;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform = tdes.CreateDecryptor();

            byte[] resultArray = cTransform.TransformFinalBlock(Array_a_Descifrar, 0, Array_a_Descifrar.Length);
            
            tdes.Clear();

            return UTF8Encoding.UTF8.GetString(resultArray);
        }
    }
}
