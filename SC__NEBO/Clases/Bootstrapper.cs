using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO; //Esta libreria permite gestionar archivos (crear archivos, verificar si existen, etc.)

namespace SC__NEBO.Clases
{
    class Bootstrapper
    {
        Clases.Asistente a = new Clases.Asistente();

        public void CheckFileConfiguration()
        {
            string path = @"C:\DataApp\Configuration.accdb";

            if (File.Exists(path))
            {
                ReadConfiguration();
            }
            else
            {
                a.Advertencia("ERROR AL CARGAR EL ARCHIVO DE CONFIGURACION", "ERROR");

                Application.Exit();
            }
        }

        private void ReadConfiguration()
        {
            string Cadena_Conexion = @"Provider=Microsoft.ACE.OLEDB.4.0;Data Source=C:\DataApp\Configuration.accdb;Jet OLEDB:Database Password=123;";

            OleDbConnection ConAccess = new OleDbConnection(Cadena_Conexion);

            try
            {
                string query = "SELECT * FROM INFOSERVER";
                OleDbCommand con = new OleDbCommand(query, ConAccess);
                ConAccess.Open();
                OleDbDataReader reader;

                reader = con.ExecuteReader();

                if (reader.Read())
                {
                    Clases.Env.SERVER = reader["SERVER"].ToString();
                    Clases.Env.USER = reader["USUARIO"].ToString();
                    Clases.Env.PASS = reader["PASSWORD"].ToString();
                    Clases.Env.DB = reader["DATABASE"].ToString();

                    Clases.Conexion.SetConfigurationServer();

                    a.Advertencia(Clases.Env.SERVER);

                }
                else
                {
                    a.Advertencia("ERROR AL CARGAR LOS DATOS DE CONFIGURACION", "ERROR");
                    Application.Exit();
                }

                //Liberacion del recursos
                reader.Close();
                con.Dispose();
                ConAccess.Close();
            }
            catch (OleDbException error)
            {
                a.Advertencia(error.Message);
                throw;
            }
        }
    }
}
