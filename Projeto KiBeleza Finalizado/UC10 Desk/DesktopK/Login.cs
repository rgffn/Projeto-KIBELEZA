using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopK
{
    public partial class frmLogin : Form
    {

        string email, senha;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void Login()
        {
            Banco banco = new Banco();
            banco.Conectar();

            var sql = "SELECT emailFunc, senhaFunc, nivelFunc FROM funcionario WHERE emailFunc=@email AND senhaFunc=@senha";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@senha", senha);
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                Banco.nivel = reader.GetString(2);
                frmMenu menu = new frmMenu();
                menu.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Usuário ou Senha inválidos!...");
                txtEmail.Text = string.Empty;
                txtSenha.Text = string.Empty;
                txtSenha.Enabled = false;
                btnEntrar.Enabled = false;
                txtEmail.Select();
            }
            banco.Desconectar();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Encerrar o Sistema?", "ENCERRAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                txtEmail.Text = string.Empty;
                txtSenha.Text = string.Empty;
                txtSenha.Enabled = false;
                btnEntrar.Enabled = false;
                txtEmail.Select();
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Login();
   
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                int i = txtEmail.Text.IndexOf('@');
                int j = txtEmail.Text.IndexOf('.');

                if ((i == -1) || (j == -1))
                {
                    MessageBox.Show("Favor digitar um E-mail válido");
                    txtEmail.Clear();
                    txtEmail.Select();
                }
                else
                {
                    email = txtEmail.Text;
                    txtSenha.Enabled = true;
                    txtSenha.Select();
                }
            }
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                senha = txtSenha.Text;
                btnEntrar.Enabled = true;
                btnEntrar.Focus();
            }
        }
    }
}
