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
    public partial class frmServico : Form
    {
        int linhaAtual, codigo;
        string status, nome;

        public frmServico()
        {
            InitializeComponent();
        }

        private void CarregarServico()
        {
            Banco banco = new Banco();
            banco.Conectar();

            var sql = "SELECT idServico,nomeServico,valorServico,statusServico,dataCadServico,fotoServico,fotoServico1,fotoServico2,fotoServico3,descServico,texto,tempoServico,nomeEmp FROM servico INNER JOIN empresa ON servico.idEmpresa = empresa.idEmpresa ORDER BY nomeServico";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvServico.DataSource = dt;

            dgvServico.Columns[0].HeaderText = "Código";
            dgvServico.Columns[1].HeaderText = "Nome do Serviço";
            dgvServico.Columns[2].HeaderText = "Valor";
            dgvServico.Columns[3].HeaderText = "Status";
            dgvServico.Columns[4].HeaderText = "Data de Cadastro";
            dgvServico.Columns[5].HeaderText = "Foto";
            dgvServico.Columns[6].HeaderText = "Foto 1";
            dgvServico.Columns[7].HeaderText = "Foto 2";
            dgvServico.Columns[8].HeaderText = "Foto 3";
            dgvServico.Columns[9].HeaderText = "Descrição";
            dgvServico.Columns[10].HeaderText = "Texto";
            dgvServico.Columns[11].HeaderText = "Tempo de Execução";
            dgvServico.Columns[12].HeaderText = "Nome da Empresa";

            banco.Desconectar();
        }

        private void CarregarServicoStatus()
        {
            Banco banco = new Banco();
            banco.Conectar();

            var sql = "SELECT * FROM servico WHERE statusServico=@status ORDER BY nomeServico";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            cmd.Parameters.AddWithValue("@status", status);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvServico.DataSource = dt;

            dgvServico.Columns[0].HeaderText = "Código";
            dgvServico.Columns[1].HeaderText = "Nome do Serviço";
            dgvServico.Columns[2].HeaderText = "Valor";
            dgvServico.Columns[3].HeaderText = "Status";
            dgvServico.Columns[4].HeaderText = "Data de Cadastro";
            dgvServico.Columns[5].HeaderText = "Foto";
            dgvServico.Columns[6].HeaderText = "Foto 1";
            dgvServico.Columns[7].HeaderText = "Foto 2";
            dgvServico.Columns[8].HeaderText = "Foto 3";
            dgvServico.Columns[9].HeaderText = "Descrição";
            dgvServico.Columns[10].HeaderText = "Texto";
            dgvServico.Columns[11].HeaderText = "Tempo de Execução";
            dgvServico.Columns[12].HeaderText = "Nome da Empresa";

            banco.Desconectar();
        }

        private void CarregarServicoNome()
        {
            Banco banco = new Banco();
            banco.Conectar();

            var sql = "SELECT * FROM servico WHERE nomeServico LIKE '" + @nome + "%' ORDER BY nomeServico";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvServico.DataSource = dt;

            dgvServico.Columns[0].HeaderText = "Código";
            dgvServico.Columns[1].HeaderText = "Nome do Serviço";
            dgvServico.Columns[2].HeaderText = "Valor";
            dgvServico.Columns[3].HeaderText = "Status";
            dgvServico.Columns[4].HeaderText = "Data de Cadastro";
            dgvServico.Columns[5].HeaderText = "Foto";
            dgvServico.Columns[6].HeaderText = "Foto 1";
            dgvServico.Columns[7].HeaderText = "Foto 2";
            dgvServico.Columns[8].HeaderText = "Foto 3";
            dgvServico.Columns[9].HeaderText = "Descrição";
            dgvServico.Columns[10].HeaderText = "Texto";
            dgvServico.Columns[11].HeaderText = "Tempo de Execução";
            dgvServico.Columns[12].HeaderText = "Nome da Empresa";

            banco.Desconectar();
        }

        private void ExcluirServico()
        {
            try
            {
                Banco banco = new Banco();
                banco.Conectar();

                string sql = "DELETE FROM servico WHERE idServico=@codigo";
                MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
                cmd.Parameters.AddWithValue("@codigo", codigo);
                cmd.ExecuteNonQuery();

                banco.Desconectar();
            }
            catch
            {
                MessageBox.Show("Impossivel excluir o Serviço \n\n Ele já foi vinculado em outra tabela");
            }
        }

        private void frmServico_Load(object sender, EventArgs e)
        {
            CarregarServico();
            dgvServico.ClearSelection();
            dgvServico.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void dgvServico_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            linhaAtual = int.Parse(e.RowIndex.ToString());
            if (linhaAtual >= 0)
            {
                codigo = Convert.ToInt32(dgvServico[0, linhaAtual].Value);
            }
        }

        private void dgvServico_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvServico.Sort(dgvServico.Columns[1], ListSortDirection.Ascending);
            dgvServico.ClearSelection();
            txtBuscarServico.Select();
        }

        private void txtBuscarServico_TextChanged(object sender, EventArgs e)
        {
            nome = txtBuscarServico.Text;
            CarregarServicoNome();
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            status = cmbStatus.Text;
            if (status == "TODOS")
            {
                CarregarServico();
            }
            else
            {
                CarregarServicoStatus();
            }
            dgvServico.ClearSelection();
            dgvServico.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            frmCadServico cadServico = new frmCadServico();
            cadServico.funcao = "ADICIONAR";
            cadServico.Show();
            Hide();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            frmCadServico cadServico = new frmCadServico();
            cadServico.codServico = Convert.ToInt32(dgvServico[0, linhaAtual].Value);
            cadServico.funcao = "ALTERAR";
            cadServico.Show();
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
            if (dgvServico.SelectedRows.Count > 0)
            {
                var resultado = MessageBox.Show("Deseja realmente excluir esse Serviço? \n\n Essa ação não poderá ser desfeita...", "EXCLUIR SERVICO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    ExcluirServico();
                    txtBuscarServico.Select();
                }
                CarregarServico();
                dgvServico.ClearSelection();
                dgvServico.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
        }
    }
}
    

