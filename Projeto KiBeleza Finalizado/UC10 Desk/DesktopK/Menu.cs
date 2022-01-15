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
    public partial class frmMenu : Form
    {
        int linhaAtual, codigo;
        string status, cliente;
        string nomeProfissional, nomeCliente;

        public frmMenu()
        {
            InitializeComponent();
        }

        private void Status()
        {
            Banco banco = new Banco();
            banco.Conectar();

            var sql = "UPDATE reserva SET status=@status WHERE idReserva=@codigo";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@codigo", codigo);
            cmd.ExecuteNonQuery();

            banco.Desconectar();
        }

        private void CarregarReserva()
        {
            Banco banco = new Banco();
            banco.Conectar();

            var sql = "SELECT idReserva, dataReserva,horaReserva,status,nomeFunc,nomeCli,nomeServico,obs FROM reserva INNER JOIN funcionario ON reserva.idFuncionario = funcionario.idFuncionario INNER JOIN cliente ON reserva.idCliente = cliente.idCliente INNER JOIN servico ON reserva.idServico = Servico.idServico WHERE DATE(dataReserva) = DATE(NOW()) AND status!= 'CANCELADO' ORDER BY dataReserva,horaReserva";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvReserva.DataSource = dt;

            dgvReserva.Columns[0].HeaderText = "Codigo Reserva";
            dgvReserva.Columns[0].Visible = false;
            dgvReserva.Columns[1].HeaderText = "Data da Reserva";
            dgvReserva.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvReserva.Columns[2].HeaderText = "Horário";
            dgvReserva.Columns[2].DefaultCellStyle.Format = "HH:mm";
            dgvReserva.Columns[3].HeaderText = "Status";
            dgvReserva.Columns[4].HeaderText = "Nome do Funcionário";
            dgvReserva.Columns[5].HeaderText = "Nome do Cliente";
            dgvReserva.Columns[6].HeaderText = "Nome do Serviço";
            dgvReserva.Columns[7].HeaderText = "OBS";

            banco.Desconectar();
        }

        private void CarregarReservaProfissional()
        {
            Banco banco = new Banco();
            banco.Conectar();

            var sql = "SELECT idReserva, dataReserva,horaReserva,status,nomeFunc,nomeCli,nomeServico,obs FROM reserva INNER JOIN funcionario ON reserva.idFuncionario = funcionario.idFuncionario INNER JOIN cliente ON reserva.idCliente = cliente.idCliente INNER JOIN servico ON reserva.idServico = Servico.idServico WHERE nomeFunc LIKE '" + nomeProfissional + "%' ORDER BY dataReserva,horaReserva";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvReserva.DataSource = dt;

            dgvReserva.Columns[0].HeaderText = "Codigo Reserva";
            dgvReserva.Columns[0].Visible = false;
            dgvReserva.Columns[1].HeaderText = "Data da Reserva";
            dgvReserva.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvReserva.Columns[2].HeaderText = "Horário";
            dgvReserva.Columns[2].DefaultCellStyle.Format = "HH:mm";
            dgvReserva.Columns[3].HeaderText = "Status";
            dgvReserva.Columns[4].HeaderText = "Nome do Funcionário";
            dgvReserva.Columns[5].HeaderText = "Nome do Cliente";
            dgvReserva.Columns[6].HeaderText = "Nome do Serviço";
            dgvReserva.Columns[7].HeaderText = "OBS";

            banco.Desconectar();
        }

        private void CarregarReservaCliente()
        {
            Banco banco = new Banco();
            banco.Conectar();

            var sql = "SELECT idReserva, dataReserva,horaReserva,status,nomeFunc,nomeCli,nomeServico,obs FROM reserva INNER JOIN funcionario ON reserva.idFuncionario = funcionario.idFuncionario INNER JOIN cliente ON reserva.idCliente = cliente.idCliente INNER JOIN servico ON reserva.idServico = Servico.idServico WHERE nomeCli LIKE '" + nomeCliente + "%' ORDER BY dataReserva,horaReserva";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvReserva.DataSource = dt;

            dgvReserva.Columns[0].HeaderText = "Codigo Reserva";
            dgvReserva.Columns[0].Visible = false;
            dgvReserva.Columns[1].HeaderText = "Data da Reserva";
            dgvReserva.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvReserva.Columns[2].HeaderText = "Horário";
            dgvReserva.Columns[2].DefaultCellStyle.Format = "HH:mm";
            dgvReserva.Columns[3].HeaderText = "Status";
            dgvReserva.Columns[4].HeaderText = "Nome do Funcionário";
            dgvReserva.Columns[5].HeaderText = "Nome do Cliente";
            dgvReserva.Columns[6].HeaderText = "Nome do Serviço";
            dgvReserva.Columns[7].HeaderText = "OBS";

            banco.Desconectar();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            if (Banco.nivel == "ATENDENTE")
            {
                btnRelatorio.Enabled = false;
                btnFuncionario.Enabled = false;
                pctEmpresa.Enabled = false;
            }
            CarregarReserva();
            dgvReserva.ClearSelection();
            dgvReserva.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void dgvReserva_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            linhaAtual = int.Parse(e.RowIndex.ToString());
            if (linhaAtual >= 0)
            {
                codigo = Convert.ToInt32(dgvReserva[0, linhaAtual].Value);
                cliente = Convert.ToString(dgvReserva[5, linhaAtual].Value);
            } 
        }

        private void dgvReserva_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvReserva.Sort(dgvReserva.Columns[1], ListSortDirection.Ascending);
            dgvReserva.ClearSelection();
            txtProfissional.Select();
        }

        private void txtProfissional_TextChanged(object sender, EventArgs e)
        {
            nomeProfissional = txtProfissional.Text;
            CarregarReservaProfissional();
        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {
            nomeCliente = txtCliente.Text;
            CarregarReservaCliente();
        }

        private void pctEmpresa_Click(object sender, EventArgs e)
        {
            frmEmpresa empresa = new frmEmpresa();
            empresa.Show();
            Hide();
        }

        private void pctReserva_Click(object sender, EventArgs e)
        {
            frmCadReserva cadReserva = new frmCadReserva();
            cadReserva.Show();
            Hide();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            frmCliente cliente = new frmCliente();
            cliente.Show();
            Hide();
        }

        private void btnServico_Click(object sender, EventArgs e)
        {
            frmServico servico = new frmServico();
            servico.Show();
            Hide();
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            frmFuncionario funcionario = new frmFuncionario();
            funcionario.Show();
            Hide();
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            frmRelatorio relatorio = new frmRelatorio();
            relatorio.Show();
            Hide();
        }

        private void btnEmail_Click(object sender, EventArgs e)
        {
            frmContato contato = new frmContato();
            contato.Show();
            Hide();
        }

        private void btnBanner_Click(object sender, EventArgs e)
        {
            frmBanner banner = new frmBanner();
            banner.Show();
            Hide();
        }

        private void btnAprovar_Click(object sender, EventArgs e)
        {
            if (dgvReserva.SelectedRows.Count > 0)
            {
                status = "APROVADO";
                Status();
                CarregarReserva();
                MessageBox.Show("A reserva de " + cliente + " foi alterada para " + status);
                dgvReserva.ClearSelection();
            }
            else
            {
                MessageBox.Show("Selecione uma Reserva");
            }
        }

        private void btnReprovar_Click(object sender, EventArgs e)
        {
            if (dgvReserva.SelectedRows.Count > 0)
            {
                status = "REPROVADO";
                Status();
                CarregarReserva();
                MessageBox.Show("A reserva de " + cliente + " foi alterada para " + status);
                dgvReserva.ClearSelection();
            }
            else
            {
                MessageBox.Show("Selecione uma Reserva");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (dgvReserva.SelectedRows.Count > 0)
            {
                status = "CANCELADO";
                Status();
                CarregarReserva();
                MessageBox.Show("A reserva de " + cliente + " foi alterada para " + status);
                dgvReserva.ClearSelection();
            }
            else
            {
                MessageBox.Show("Selecione uma Reserva");
            }
        }

        private void btnAguardar_Click(object sender, EventArgs e)
        {
            if (dgvReserva.SelectedRows.Count > 0)
            {
                status = "AGUARDANDO";
                Status();
                CarregarReserva();
                MessageBox.Show("A reserva de " + cliente + " foi alterada para " + status);
                dgvReserva.ClearSelection();
            }
            else
            {
                MessageBox.Show("Selecione uma Reserva");
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (dgvReserva.SelectedRows.Count > 0)
            {
                status = "FINALIZADO";
                Status();
                CarregarReserva();
                MessageBox.Show("A reserva de " + cliente + " foi alterada para " + status);
                dgvReserva.ClearSelection();
            }
            else
            {
                MessageBox.Show("Selecione uma Reserva");
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            Close();
        }     
    }
}
