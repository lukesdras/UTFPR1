using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace teste_WFA_SQL
{
    public class Database
    {
        public static string MySqlClientString = "server=database-1.c9rst2cteqor.sa-east-1.rds.amazonaws.com; port=3306; User Id=lukesdras; database=Cadastro; password=gostoso12";

        public static void ConexaoBD()
        {
            MySqlConnection conn = new MySqlConnection(MySqlClientString);
            try
            {
                if (conn.State.Equals(ConnectionState.Closed))
                {
                    conn.Open();
                }
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("Não foi possível conectar com o banco de dados : " + erro.Message, "Erro de Conexão",
MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
            finally
            {
                conn.Dispose();
            }
        }
    }
}
