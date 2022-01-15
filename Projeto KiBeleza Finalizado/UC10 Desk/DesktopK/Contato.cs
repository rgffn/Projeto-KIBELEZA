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
    public partial class frmContato : Form
    {
        public int codigo;
        string nome;
        int linhaAtual;

        public frmContato()
        {
            InitializeComponent();
        }

        private void CarregarContato()
        {
            Banco banco = new Banco();
            banco.Conectar();

            var sql = "SELECT * FROM contato";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvContato.DataSource = dt;

            dgvContato.Columns[0].HeaderText = "Código";
            dgvContato.Columns[1].HeaderText = "Nome";
            dgvContato.Columns[2].HeaderText = "E-Mail";
            dgvContato.Columns[3].HeaderText = "Assunto";
            dgvContato.Columns[3].Width = 118;
            dgvContato.Columns[4].HeaderText = "Telefone";
            dgvContato.Columns[5].HeaderText = "Mensagem";
            dgvContato.Columns[5].Width = 150;

            banco.Desconectar();
        }

        private void CarregarContatoNome()
        {
            Banco banco = new Banco();
            banco.Conectar();

            var sql = "SELECT * FROM contato WHERE nome LIKE '" + @nome + "%' ORDER BY nome";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvContato.DataSource = dt;

            dgvContato.Columns[0].HeaderText = "Código";
            dgvContato.Columns[1].HeaderText = "Nome";
            dgvContato.Columns[2].HeaderText = "E-Mail";
            dgvContato.Columns[3].HeaderText = "Assunto";
            dgvContato.Columns[3].Width = 118;
            dgvContato.Columns[4].HeaderText = "Telefone";
            dgvContato.Columns[5].HeaderText = "Mensagem";
            dgvContato.Columns[5].Width = 150;

            banco.Desconectar();
        }

        private void ExcluirContato()
        {
            Banco banco = new Banco();
            banco.Conectar();

            string sql = "DELETE FROM contato WHERE id=@codigo";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            cmd.Parameters.AddWithValue("@codigo", codigo);
            cmd.ExecuteNonQuery();

            banco.Desconectar();
        }

        private void frmContato_Load(object sender, EventArgs e)
        {
            CarregarContato();
            dgvContato.ClearSelection();
            dgvContato.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void dgvContato_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            linhaAtual = int.Parse(e.RowIndex.ToString());
            if (linhaAtual >= 0)
            {
                codigo = Convert.ToInt32(dgvContato[0, linhaAtual].Value);
            } 
        }

        private void dgvContato_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvContato.Sort(dgvContato.Columns[1], ListSortDirection.Ascending);
            dgvContato.ClearSelection();
            txtBuscarContato.Select();
        }

        private void txtBuscarContato_TextChanged(object sender, EventArgs e)
        {
            nome = txtBuscarContato.Text;
            CarregarContatoNome();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            menu.Show();
            Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvContato.SelectedRows.Count > 0)
            {
                var resultado = MessageBox.Show("Deseja realmente Excluir esse Contato? \n\n Essa ação não poderá ser desfeita...", "EXCLUIR CONTATO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    ExcluirContato();
                    txtBuscarContato.Select();
                }
                CarregarContato();
                dgvContato.ClearSelection();
                dgvContato.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
        }
    }
}
