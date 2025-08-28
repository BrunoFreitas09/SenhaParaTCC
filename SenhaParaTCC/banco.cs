using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace SenhaParaTCC.Models
{
    public class banco
    {

        public static MySqlConnection Connection { get; set; }
        public static MySqlCommand Command { get; set; }
        public static MySqlDataAdapter DataAdapter { get; set; }
        public static DataTable datTable { get; set; }


        public static void OpenConnection()
        {
            try
            {
                Connection = new MySqlConnection("server=localhost;port=3307;uid=root;pwd=etecjau;database=AccessControl;");
                //Na escola:
                //pwd:etecjau
                //port =3307
                //uid=root




                Connection.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro Ao Conectar com o Banco", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(e.ToString());
            }
        }

        public static void CloseConnection()
        {
            try
            {
                Connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro Ao Fechar a Conexão com o Banco", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void CreateDatabase()
        {
            try
            {
                //abre a conexão com o banco de dados
                OpenConnection();



                Command = new MySqlCommand("CREATE DATABASE IF NOT EXISTS testedesenha", Connection);

                Command.ExecuteNonQuery();

                Command = new MySqlCommand("use testedesenha", Connection);



                // Criação da tabela 'aluno'
                Command = new MySqlCommand("create table if not exists aluno" +
                    "(id integer auto_increment primary key," +
                    "nome varchar(50)," +
                    "email varchar(80)," +
                    "senha char(20))", Connection);
                Command.ExecuteNonQuery();

                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(e.ToString());
            }
        }
    }
}