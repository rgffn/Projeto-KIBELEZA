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
    public partial class frmBanner : Form
    {
        public int linhaAtual, codigo;
        string status, nome;
        public frmBanner()
        {
            InitializeComponent();
        }

        private void CarregarBanner()
        {
            Banco banco = new Banco();
            banco.Conectar();

            var sql = "SELECT * FROM banner ORDER BY nomeBanner";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvBanner.DataSource = dt;

            dgvBanner.Columns[0].HeaderText = "Codigo";
            dgvBanner.Columns[1].HeaderText = "Nome Banner";
            dgvBanner.Columns[2].HeaderText = "Caminho Banner";
            dgvBanner.Columns[2].HeaderText = "Status Banner";

            banco.Desconectar();
        }

        private void ExcluirBanner()
        {
            Banco banco = new Banco();
            banco.Conectar();

            string sql = "DELETE FROM banner WHERE idBanner=@codigo";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            cmd.Parameters.AddWithValue("@codigo", codigo);
            cmd.ExecuteNonQuery();

            banco.Desconectar();
        }

        private void CarregarBannerStatus()
        {
            Banco banco = new Banco();
            banco.Conectar();

            var sql = "SELECT * FROM banner WHERE statusBanner=@status ORDER BY nomeBanner";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            cmd.Parameters.AddWithValue("@status", status);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvBanner.DataSource = dt;

            dgvBanner.Columns[0].HeaderText = "Codigo";
            dgvBanner.Columns[1].HeaderText = "Nome Banner";
            dgvBanner.Columns[2].HeaderText = "Caminho Banner";
            dgvBanner.Columns[2].HeaderText = "Status Banner";

            banco.Desconectar();
        }

        private void CarregarBannerNome()
        {
            Banco banco = new Banco();
            banco.Conectar();

            var sql = "SELECT * FROM banner WHERE nomeBanner LIKE '" + @nome + "%' ORDER BY nomeBanner";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvBanner.DataSource = dt;

            dgvBanner.Columns[0].HeaderText = "Codigo";
            dgvBanner.Columns[1].HeaderText = "Nome Banner";
            dgvBanner.Columns[2].HeaderText = "Caminho Banner";
            dgvBanner.Columns[2].HeaderText = "Status Banner";

            banco.Desconectar();
        }

        private void frmBanner_Load(object sender, EventArgs e)
        {
            CarregarBanner();
            dgvBanner.ClearSelection();
            dgvBanner.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void dgvBanner_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            linhaAtual = int.Parse(e.RowIndex.ToString());
            if (linhaAtual >= 0)
            {
                codigo = Convert.ToInt32(dgvBanner[0, linhaAtual].Value);
            }
        }

        private void dgvBanner_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvBanner.Sort(dgvBanner.Columns[1], ListSortDirection.Ascending);
            dgvBanner.ClearSelection();
            txtBuscarBanner.Select();
        }

        private void txtBuscarBanner_TextChanged(object sender, EventArgs e)
        {
            nome = txtBuscarBanner.Text;
            CarregarBannerNome();
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            status = cmbStatus.Text;
            if (status == "TODOS")
            {
                CarregarBanner();
            }
            else
            {
                CarregarBannerStatus();
            }
            dgvBanner.ClearSelection();
            dgvBanner.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            frmCadBanner cadBanner = new frmCadBanner();
            cadBanner.funcao = "ADICIONAR";
            cadBanner.Show();
            Hide();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (dgvBanner.SelectedRows.Count > 0)
            {
                frmCadBanner cadBanner = new frmCadBanner();
                cadBanner.codigo = Convert.ToInt32(dgvBanner[0, linhaAtual].Value);
                cadBanner.funcao = "ALTERAR";
                cadBanner.Show();
                Hide(); 
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvBanner.SelectedRows.Count > 0)
            {
                var resultado = MessageBox.Show("Deseja realmente Excluir esse Banner? \n\n Essa ação não poderá ser desfeita...","EXCLUIR BANNER",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if(resultado == DialogResult.Yes)
                {
                    ExcluirBanner();
                    txtBuscarBanner.Select();
                }
                CarregarBanner();
                dgvBanner.ClearSelection();
                dgvBanner.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            menu.Show();
            Close();
        }
    }
}
