using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopK
{
    //Alterar a class Banco para public class Banco
    public class Banco
    {

        //Vinculação e Conexão do Desktop no Banco KiB (string)
        string db = "SERVER=localhost;USER=root;DATABASE=kibeleza";
        public MySqlConnection conexao;
        public void Conectar()
        {
            try //Se conseguir
            {
                //Abrindo a conexão com o Banco de Dados
                conexao = new MySqlConnection(db);
                conexao.Open();
            }
            catch //Se não conseguir
            {
                //Mostar uma mensagem no caso da abertura da conexão der erro
                MessageBox.Show("Erro ao tentar conexão com o banco de dados", "ERRO");
            }
        }

        public void Desconectar()
        {
            try
            {
                //Fechar a conexão com o Banco de Dados
                conexao = new MySqlConnection(db);
                conexao.Close();
            }
            catch
            {
                //Mostrar mensagem caso haja falha na conexão
                MessageBox.Show("Falha ao tentar se comunicar com o Banco de Dados", "ERRO!");
            }
        }

        public static string nivel;
    }
}
