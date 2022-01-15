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
    public partial class frmFuncionario : Form
    {
        public int linhaAtual, codigo;
        string status, nome;

        public frmFuncionario()
        {
            InitializeComponent();
        }

        private void CarregarFuncionario()
        {
            Banco banco = new Banco();
            banco.Conectar();

            var sql = "SELECT idFuncionario,nomeFunc,emailFunc,senhaFunc,nivelFunc,statusFunc,dataCadFunc,horarioTrabalhoFunc,fotoFunc,nomeEmp FROM funcionario INNER JOIN empresa ON funcionario.idEmpresa = empresa.idEmpresa ORDER BY nomeFunc";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvFuncionario.DataSource = dt;

            dgvFuncionario.Columns[0].HeaderText = "Código";
            dgvFuncionario.Columns[1].HeaderText = "Nome do Funcionário";
            dgvFuncionario.Columns[2].HeaderText = "E-Mail";
            dgvFuncionario.Columns[3].HeaderText = "Senha";
            dgvFuncionario.Columns[4].HeaderText = "Nível";
            dgvFuncionario.Columns[5].HeaderText = "Status";
            dgvFuncionario.Columns[6].HeaderText = "Data de Cadastro";
            dgvFuncionario.Columns[7].HeaderText = "Horário de Trabalho";
            dgvFuncionario.Columns[8].HeaderText = "Foto do Funcionario";
            dgvFuncionario.Columns[9].HeaderText = "Nome da Empresa";

            banco.Desconectar();
        }

        private void CarregarFuncionarioStatus()
        {
            Banco banco = new Banco();
            banco.Conectar();

            var sql = "SELECT * FROM funcionario WHERE statusFunc=@status ORDER BY nomeFunc";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            cmd.Parameters.AddWithValue("@status", status);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvFuncionario.DataSource = dt;

            dgvFuncionario.Columns[0].HeaderText = "Código";
            dgvFuncionario.Columns[1].HeaderText = "Nome do Funcionário";
            dgvFuncionario.Columns[2].HeaderText = "E-Mail";
            dgvFuncionario.Columns[3].HeaderText = "Senha";
            dgvFuncionario.Columns[4].HeaderText = "Nível";
            dgvFuncionario.Columns[5].HeaderText = "Status";
            dgvFuncionario.Columns[6].HeaderText = "Data de Cadastro";
            dgvFuncionario.Columns[7].HeaderText = "Horário de Trabalho";
            dgvFuncionario.Columns[8].HeaderText = "Nome da Empresa";

            banco.Desconectar();
        }

        private void CarregarFuncionarioNome()
        {
            Banco banco = new Banco();
            banco.Conectar();

            var sql = "SELECT * FROM funcionario WHERE nomeFunc LIKE '" + @nome + "%' ORDER BY nomeFunc";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvFuncionario.DataSource = dt;

            dgvFuncionario.Columns[0].HeaderText = "Código";
            dgvFuncionario.Columns[1].HeaderText = "Nome do Funcionário";
            dgvFuncionario.Columns[2].HeaderText = "E-Mail";
            dgvFuncionario.Columns[3].HeaderText = "Senha";
            dgvFuncionario.Columns[4].HeaderText = "Nível";
            dgvFuncionario.Columns[5].HeaderText = "Status";
            dgvFuncionario.Columns[6].HeaderText = "Data de Cadastro";
            dgvFuncionario.Columns[7].HeaderText = "Horário de Trabalho";
            dgvFuncionario.Columns[8].HeaderText = "Nome da Empresa";

            banco.Desconectar();
        }

        private void ExcluirFuncionario()
        {
            try
            {
                Banco banco = new Banco();
                banco.Conectar();

                string sql = "DELETE FROM funcionario WHERE idFuncionario=@codigo";
                MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
                cmd.Parameters.AddWithValue("@codigo", codigo);
                cmd.ExecuteNonQuery();

                banco.Desconectar();
            }
            catch
            {
                MessageBox.Show("Impossivel excluir o Funcionário \n\n Ele já foi vinculado em outra tabela");
            }
        }

        private void frmFuncionario_Load(object sender, EventArgs e)
        {
            CarregarFuncionario();
            dgvFuncionario.ClearSelection();
            dgvFuncionario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void dgvFuncionario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            linhaAtual = int.Parse(e.RowIndex.ToString());
            if (linhaAtual >= 0)
            {
                codigo = Convert.ToInt32(dgvFuncionario[0, linhaAtual].Value);
            }
        }

        private void dgvFuncionario_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvFuncionario.Sort(dgvFuncionario.Columns[1], ListSortDirection.Ascending);
            dgvFuncionario.ClearSelection();
            txtBuscarFuncionario.Select();
        }

        private void txtBuscarFuncionario_TextChanged(object sender, EventArgs e)
        {
            nome = txtBuscarFuncionario.Text;
            CarregarFuncionarioNome();
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            status = cmbStatus.Text;
            if (status == "TODOS")
            {
                CarregarFuncionario();
            }
            else
            {
                CarregarFuncionarioStatus();
            }
            dgvFuncionario.ClearSelection();
            dgvFuncionario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            frmCadFuncionário cadfuncionario = new frmCadFuncionário();
            cadfuncionario.Show();
            cadfuncionario.funcao = "ADICIONAR";
            Hide();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            menu.Show();
            Close();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            frmCadFuncionário cadFuncionario = new frmCadFuncionário();
            cadFuncionario.codigoFuncionario = Convert.ToInt32(dgvFuncionario[0, linhaAtual].Value);
            cadFuncionario.funcao = "ALTERAR";
            cadFuncionario.Show();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvFuncionario.SelectedRows.Count > 0)
            {
                var resultado = MessageBox.Show("Deseja realmente excluir esse Funcionário? \n\n Essa ação não poderá ser desfeita...", "EXCLUIR FUNCIONÁRIO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    ExcluirFuncionario();
                    txtBuscarFuncionario.Select();
                }
                CarregarFuncionario();
                dgvFuncionario.ClearSelection();
                dgvFuncionario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
        }
    }
}
