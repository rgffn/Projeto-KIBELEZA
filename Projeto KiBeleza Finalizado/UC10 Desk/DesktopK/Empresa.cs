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
    public partial class frmEmpresa : Form
    {
        int linhaAtual, codigo;
        string status, nome;

        public frmEmpresa()
        {
            InitializeComponent();
        }

        private void CarregarEmpresa()
        {
            Banco banco = new Banco();
            banco.Conectar();

            var sql = "SELECT * FROM empresa ORDER BY nomeEmp";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvEmpresa.DataSource = dt;

            dgvEmpresa.Columns[0].HeaderText = "Código";
            dgvEmpresa.Columns[1].HeaderText = "Nome da Empresa";
            dgvEmpresa.Columns[2].HeaderText = "CNPJ/CPF";
            dgvEmpresa.Columns[3].HeaderText = "Razão Social";
            dgvEmpresa.Columns[4].HeaderText = "E-mail";
            dgvEmpresa.Columns[5].HeaderText = "Status";
            dgvEmpresa.Columns[6].HeaderText = "Data de Cadastro";
            dgvEmpresa.Columns[7].HeaderText = "Horário de Atendimento";

            banco.Desconectar();
        }

        private void CarregarEmpresaStatus()
        {
            Banco banco = new Banco();
            banco.Conectar();

            var sql = "SELECT * FROM empresa WHERE statusEmp=@status ORDER BY nomeEmp";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            cmd.Parameters.AddWithValue("@status", status);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvEmpresa.DataSource = dt;

            dgvEmpresa.Columns[0].HeaderText = "Código";
            dgvEmpresa.Columns[1].HeaderText = "Nome da Empresa";
            dgvEmpresa.Columns[2].HeaderText = "CNPJ/CPF";
            dgvEmpresa.Columns[3].HeaderText = "Razão Social";
            dgvEmpresa.Columns[4].HeaderText = "E-mail";
            dgvEmpresa.Columns[5].HeaderText = "Status";
            dgvEmpresa.Columns[6].HeaderText = "Data de Cadastro";
            dgvEmpresa.Columns[7].HeaderText = "Horário de Atendimento";

            banco.Desconectar();
        }

        private void CarregarEmpresaNome()
        {
            Banco banco = new Banco();
            banco.Conectar();

            var sql = "SELECT * FROM empresa WHERE nomeEmp LIKE '" + @nome + "%' ORDER BY nomeEmp";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvEmpresa.DataSource = dt;

            dgvEmpresa.Columns[0].HeaderText = "Código";
            dgvEmpresa.Columns[1].HeaderText = "Nome da Empresa";
            dgvEmpresa.Columns[2].HeaderText = "CNPJ/CPF";
            dgvEmpresa.Columns[3].HeaderText = "Razão Social";
            dgvEmpresa.Columns[4].HeaderText = "E-mail";
            dgvEmpresa.Columns[5].HeaderText = "Status";
            dgvEmpresa.Columns[6].HeaderText = "Data de Cadastro";
            dgvEmpresa.Columns[7].HeaderText = "Horário de Atendimento";

            banco.Desconectar();
        }

        private void ExcluirEmpresa()
        {
            try
            {
                Banco banco = new Banco();
                banco.Conectar();

                var sql = "DELETE FROM empresa WHERE idEmpresa = @codigo;";
                MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
                cmd.Parameters.AddWithValue("@codigo", codigo);
                cmd.ExecuteNonQuery();

                banco.Desconectar();
            }
            catch
            {
                MessageBox.Show("Impossivel Excluir a Empresa. \n\n Ela ja foi vinculada a outra tabela.");
            }
        }

        private void frmEmpresa_Load(object sender, EventArgs e)
        {
            CarregarEmpresa();
            dgvEmpresa.ClearSelection();
            dgvEmpresa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void dgvEmpresa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            linhaAtual = int.Parse(e.RowIndex.ToString());
            if (linhaAtual >= 0)
            {
                codigo = Convert.ToInt32(dgvEmpresa[0, linhaAtual].Value);
            }
        }

        private void dgvEmpresa_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvEmpresa.Sort(dgvEmpresa.Columns[1], ListSortDirection.Ascending);
            dgvEmpresa.ClearSelection();
            txtBuscarEmpresa.Select();
        }

        private void txtBuscarEmpresa_TextChanged(object sender, EventArgs e)
        {
            nome = txtBuscarEmpresa.Text;
            CarregarEmpresaNome();
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            status = cmbStatus.Text;
            if (status == "TODOS")
            {
                CarregarEmpresa();
            }
            else
            {
                CarregarEmpresaStatus();
            }
            dgvEmpresa.ClearSelection();
            dgvEmpresa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            frmCadEmpresa CadEmpresa = new frmCadEmpresa();
            CadEmpresa.funcao = "ADICIONAR";
            CadEmpresa.Show();
            Hide();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            frmCadEmpresa CadEmpresa = new frmCadEmpresa();
            CadEmpresa.codigo = Convert.ToInt32(dgvEmpresa[0, linhaAtual].Value);
            CadEmpresa.funcao = "ALTERAR";
            CadEmpresa.Show();
            Hide();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            menu.Show();
            Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvEmpresa.SelectedRows.Count > 0)
            {
                var resultado = MessageBox.Show("Deseja realmente Excluir essa Empresa? \n\n Essa ação não poderá ser desfeita...", "EXCLUIR EMPRESA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                   ExcluirEmpresa();
                   txtBuscarEmpresa.Select();
                }
                CarregarEmpresa();
                dgvEmpresa.ClearSelection();
                dgvEmpresa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
        }
    }
}

