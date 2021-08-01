using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste_WFA_SQL
{
    public class DAL
    {


        private static string Server = "database-1.c9rst2cteqor.sa-east-1.rds.amazonaws.com;";
        private static string Database = "Cadastro";
        private static string User = "lukesdras";
        private static string Password = "gostoso12";
        private MySqlConnection Connection;

        private string ConnectionString = $"Server={Server};Database={Database};Uid={User};Pwd={Password};Sslmode=none;charset=utf8;";

        public DAL()
        {
            Connection = new MySqlConnection(ConnectionString);
            Connection.Open();
        }

        //Executa: INSERT, UPDATE, DELETE
        public void ExecutarComandoSQL(string sql)
        {
            MySqlCommand Command = new MySqlCommand(sql, Connection);
            Command.ExecuteNonQuery();

        }

        //Retorna Dados do Banco
        public DataTable RetornarDataTable(string sql)
        {
            MySqlCommand Command = new MySqlCommand(sql, Connection);
            MySqlDataAdapter DataAdaptar = new MySqlDataAdapter(Command);
            DataTable Dados = new DataTable();
            DataAdaptar.Fill(Dados);
            return Dados;
        }

        //Contar numero de Rows
        public int ReturnDataRows(string sql)
        {
            MySqlCommand Command = new MySqlCommand(sql, Connection);
            MySqlDataAdapter DataAdaptar = new MySqlDataAdapter(Command);
            DataTable get = new DataTable();
            DataAdaptar.Fill(get);
            int rows = get.Rows.Count;
            return rows;
 
        }
        public string ReturnSTRsql(string sql)
        {
            MySqlCommand Command = new MySqlCommand(sql, Connection);
            MySqlDataReader get;
            get = Command.ExecuteReader();
            get.Read();
            string retorno;
            retorno = get.GetString(0);
            get.Close();
            return retorno;
        }




    }




}





