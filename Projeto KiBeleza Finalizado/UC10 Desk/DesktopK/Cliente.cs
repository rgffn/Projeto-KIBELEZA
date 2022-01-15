using MySql.Data.MySqlClient;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace DesktopK
{
    public partial class frmCliente : Form
    {
        int linhaAtual, codigo;
        string status, nome;

        public object DataGridViewAutoSizeMode { get; private set; }

        public frmCliente()
        {
            InitializeComponent();
        }

        private void CarregarCliente()
        {
            Banco banco = new Banco();
            banco.Conectar();

            var sql = "SELECT * FROM cliente ORDER BY nomeCli";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvCliente.DataSource = dt;

            dgvCliente.Columns[0].HeaderText = "Código";
            dgvCliente.Columns[0].Width = 60;
            dgvCliente.Columns[1].HeaderText = "Nome do Cliente";
            dgvCliente.Columns[1].Width = 120;
            dgvCliente.Columns[2].HeaderText = "E-Mail";
            dgvCliente.Columns[3].HeaderText = "Senha";
            dgvCliente.Columns[4].HeaderText = "Status";
            dgvCliente.Columns[4].Width = 68;
            dgvCliente.Columns[5].HeaderText = "Data de Cadastro";
            dgvCliente.Columns[5].Width = 120;
            dgvCliente.Columns[6].HeaderText = "Foto";

            banco.Desconectar();
        }

        private void CarregarClienteStatus()
        {
            Banco banco = new Banco();
            banco.Conectar();

            var sql = "SELECT * FROM cliente WHERE statusCli=@status ORDER BY nomeCli";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            cmd.Parameters.AddWithValue("@status", status);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvCliente.DataSource = dt;

            dgvCliente.Columns[0].HeaderText = "Código";
            dgvCliente.Columns[0].Width = 60;
            dgvCliente.Columns[1].HeaderText = "Nome do Cliente";
            dgvCliente.Columns[1].Width = 120;
            dgvCliente.Columns[2].HeaderText = "E-Mail";
            dgvCliente.Columns[3].HeaderText = "Senha";
            dgvCliente.Columns[4].HeaderText = "Status";
            dgvCliente.Columns[4].Width = 68;
            dgvCliente.Columns[5].HeaderText = "Data de Cadastro";
            dgvCliente.Columns[5].Width = 120;
            dgvCliente.Columns[6].HeaderText = "Foto";

            banco.Desconectar();
        }

        private void CarregarClienteNome()
        {
            Banco banco = new Banco();
            banco.Conectar();

            var sql = "SELECT * FROM cliente WHERE nomeCli LIKE '" + @nome + "%' ORDER BY nomeCli";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvCliente.DataSource = dt;

            dgvCliente.Columns[0].HeaderText = "Código";
            dgvCliente.Columns[0].Width = 60;
            dgvCliente.Columns[1].HeaderText = "Nome do Cliente";
            dgvCliente.Columns[1].Width = 120;
            dgvCliente.Columns[2].HeaderText = "E-Mail";
            dgvCliente.Columns[3].HeaderText = "Senha";
            dgvCliente.Columns[4].HeaderText = "Status";
            dgvCliente.Columns[4].Width = 68;
            dgvCliente.Columns[5].HeaderText = "Data de Cadastro";
            dgvCliente.Columns[5].Width = 120;
            dgvCliente.Columns[6].HeaderText = "Foto";

            banco.Desconectar();
        }

        private void ExcluirCliente()
        {
            try
            {
                Banco banco = new Banco();
                banco.Conectar();

                string sql = "DELETE FROM cliente WHERE idCliente=@codigo";
                MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
                cmd.Parameters.AddWithValue("@codigo", codigo);
                cmd.ExecuteNonQuery();

                banco.Desconectar();
            }
            catch
            {
                MessageBox.Show("Impossivel excluir o cliente. \n\n Ele ja foi vinculado a outra tabela.");
            }

        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            CarregarCliente();
            dgvCliente.ClearSelection();
            dgvCliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void dgvCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            linhaAtual = int.Parse(e.RowIndex.ToString());
            if (linhaAtual >= 0)
            {
                codigo = Convert.ToInt32(dgvCliente[0, linhaAtual].Value);
            }
        }

        private void dgvCliente_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvCliente.Sort(dgvCliente.Columns[1], ListSortDirection.Ascending);
            dgvCliente.ClearSelection();
            txtBuscarClientes.Select();
        }

        private void txtBuscarClientes_TextChanged(object sender, EventArgs e)
        {
            nome = txtBuscarClientes.Text;
            CarregarClienteNome();
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            status = cmbStatus.Text;
            if (status == "TODOS")
            {
                CarregarCliente();
            }
            else
            {
                CarregarClienteStatus();
            }
            dgvCliente.ClearSelection();
            dgvCliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            frmCadCliente cadcliente = new frmCadCliente();
            cadcliente.Show();
            cadcliente.funcao = "ADICIONAR";
            Hide();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvCliente.SelectedRows.Count > 0)
            {
                var resultado = MessageBox.Show("Deseja realmente excluir esse Cliente? \n\n Essa ação não poderá ser desfeita...", "EXCLUIR CLIENTE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    ExcluirCliente();
                    txtBuscarClientes.Select();
                }
                CarregarCliente();
                dgvCliente.ClearSelection();
                dgvCliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {         
            frmCadCliente cadcliente = new frmCadCliente();
            cadcliente.codigo = Convert.ToInt32(dgvCliente[0, linhaAtual].Value);
            cadcliente.funcao = "ALTERAR";
            cadcliente.Show();          
            Hide();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            menu.Show();
            Close();
        }
    }
}
