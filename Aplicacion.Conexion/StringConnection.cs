namespace Aplication.Conexion
{
    public static class CadenaConexion
    {
        private static string _servidor = @".\";
        private static string _baseDatos = "XCommerceDb";

        public static string NombreServidor
        {
            set { _servidor = value; }
        }

        public static string NombreBaseDatos
        {
            set { _baseDatos = value; }
        }

        public static string Get()
        {
           // return @"Data Source=" + _servidor + ";Initial Catalog=" + _baseDatos + ";User Id=sa;Password=1Monitorfeo;"; 
            return @"Data Source=" + _servidor + ";Initial Catalog=" + _baseDatos + ";Integrated Security=true";
        }
    }



}
