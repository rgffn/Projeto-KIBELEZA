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
    public partial class frmCadReserva : Form
    {
        int codFuncionario, codCliente, codServico;
        string funcionario, cliente, servico, obs;
        string dataReserva = DateTime.Now.ToString();
        DateTime dataRes = DateTime.Now;
        string horario;
        DateTime horaRes;

        public frmCadReserva()
        {
            InitializeComponent();
        }

        private void InserirReserva()
        {
            Banco banco = new Banco();
            banco.Conectar();

            var sql = "INSERT INTO reserva (idReserva,obs,dataReserva,horaReserva,status,idFuncionario,idCliente,idServico) VALUES (DEFAULT,@obs,@dataReserva,@horaReserva,@status,@codFuncionario,@codCliente,@codServico)";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            cmd.Parameters.AddWithValue("@obs", obs);
            cmd.Parameters.AddWithValue("@dataReserva", dataRes);
            cmd.Parameters.AddWithValue("@horaReserva", horaRes);
            cmd.Parameters.AddWithValue("@status", "AGUARDANDO");
            cmd.Parameters.AddWithValue("@codFuncionario", codFuncionario);
            cmd.Parameters.AddWithValue("@codCliente", codCliente);
            cmd.Parameters.AddWithValue("@codServico", codServico);
            cmd.ExecuteNonQuery();

            banco.Desconectar();

            MessageBox.Show("Reserva efetuada com Sucesso! \n\n \n\n AGUARDANDO APROVAÇÃO", "RESERVA");
        }

        private void CarregarCliente()
        {
            Banco banco = new Banco();
            banco.Conectar();

            var sql = "SELECT idCliente,nomeCli FROM cliente ORDER BY nomeCli";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cmbCliente.DataSource = dt;

            cmbCliente.DisplayMember = "nomeCli";
            cmbCliente.ValueMember = "idCliente";
            cmbCliente.SelectedIndex = -1;

            banco.Desconectar();
        }

        private void CarregarFuncionario()
        {
            Banco banco = new Banco();
            banco.Conectar();

            var sql = "SELECT idFuncionario,nomeFunc FROM funcionario ORDER BY nomeFunc";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cmbProfissional.DataSource = dt;

            cmbProfissional.DisplayMember = "nomeFunc";
            cmbProfissional.ValueMember = "idFuncionario";
            cmbProfissional.SelectedIndex = -1;

            banco.Desconectar();
        }

        private void CarregarServico()
        {
            Banco banco = new Banco();
            banco.Conectar();

            var sql = "SELECT idServico,nomeServico FROM servico ORDER BY nomeServico";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cmbServico.DataSource = dt;

            cmbServico.DisplayMember = "nomeServico";
            cmbServico.ValueMember = "idServico";
            cmbServico.SelectedIndex = -1;

            banco.Desconectar();
        }

        private void CarregarHorarioDisponivel()
        {
            Banco banco = new Banco();
            banco.Conectar();

            var sql = "SELECT idHorarioReserva,DATE_FORMAT(horarioReserva,'%H:%i') FROM horariosreserva WHERE DATE_FORMAT(horarioReserva,'%H:%i') NOT IN (SELECT DATE_FORMAT(horaReserva,'%H:%i') FROM reserva WHERE idFuncionario = @codFuncionario AND DATE_FORMAT(dataReserva,'%d/%m/%Y') = @dataReserva) ORDER BY horarioReserva ";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            cmd.Parameters.AddWithValue("@codFuncionario", codFuncionario);
            cmd.Parameters.AddWithValue("@dataReserva", dataReserva);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cmbHorario.DataSource = dt;

            cmbHorario.DisplayMember = "DATE_FORMAT(horarioReserva,'%H:%I')";
            cmbHorario.ValueMember = "idHorarioReserva";
            cmbHorario.SelectedIndex = -1;

            banco.Desconectar();
        }

        private void CarregarClienteSelecionado()
        {
            Banco banco = new Banco();
            banco.Conectar();

            var sql = "SELECT idCliente,nomeCli FROM cliente WHERE nomeCli = @nomeCliente";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            cmd.Parameters.AddWithValue("@nomeCliente", cliente);
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                codCliente = reader.GetInt32(0);
            }
        }

        private void CarregarFuncionarioSelecionado()
        {
            Banco banco = new Banco();
            banco.Conectar();

            var sql = "SELECT idFuncionario,nomeFunc FROM funcionario WHERE nomeFunc = @nomeFuncionario";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            cmd.Parameters.AddWithValue("@nomeFuncionario", funcionario);
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                codFuncionario = reader.GetInt32(0);
            }
        }

        private void CarregarServicoSelecionado()
        {
            Banco banco = new Banco();
            banco.Conectar();

            var sql = "SELECT idServico,nomeServico FROM servico WHERE nomeServico = @nomeServico";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            cmd.Parameters.AddWithValue("@nomeServico", servico);
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                codServico = reader.GetInt32(0);
            }
        }

        private void frmCadReserva_Load(object sender, EventArgs e)
        {
            CarregarCliente();
            CarregarFuncionario();
            CarregarServico();
            CarregarHorarioDisponivel();
            cmbProfissional.Enabled = false;
            cmbServico.Enabled = false;
            cmbHorario.Enabled = false;
        }

        private void txtObservacao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                servico = cmbServico.Text;
                CarregarServicoSelecionado();
                obs = txtObservacao.Text;
                calReserva.Enabled = true;
                calReserva.Select();
            }
        }

        private void calReserva_DateSelected(object sender, DateRangeEventArgs e)
        {
            dataReserva = calReserva.SelectionRange.Start.ToShortDateString();
            dataRes = Convert.ToDateTime(calReserva.SelectionRange.Start.ToShortDateString());
            cmbHorario.Enabled = true;
            cmbHorario.Select();
            CarregarHorarioDisponivel();
        }

        private void cmbCliente_SelectionChangeCommitted(object sender, EventArgs e)
        {
     
            cmbProfissional.Enabled = true;
            cmbProfissional.Focus();
        }

        private void cmbProfissional_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cliente = cmbCliente.Text;
            CarregarClienteSelecionado();
            cmbServico.Enabled = true;
            cmbServico.Select();
            CarregarHorarioDisponivel();
        }

        private void cmbServico_SelectionChangeCommitted(object sender, EventArgs e)
        {
            funcionario = cmbProfissional.Text;
            CarregarFuncionarioSelecionado();
            txtObservacao.Enabled = true;
            txtObservacao.Select();
        }

        private void cmbHorario_SelectionChangeCommitted(object sender, EventArgs e)
        {
            btnSalvar.Enabled = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            horario = cmbHorario.Text;
            horaRes = Convert.ToDateTime(cmbHorario.Text);
            InserirReserva();
            btnSalvar.Enabled = false;
            btnFechar.PerformClick();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            menu.Show();
            Close();
        }
    }
}
