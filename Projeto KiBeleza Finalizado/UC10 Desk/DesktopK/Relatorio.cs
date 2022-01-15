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
    public partial class frmRelatorio : Form
    {
        string status;

        public frmRelatorio()
        {
            InitializeComponent();
        }

        private void DesabilitarPDF()
        {
            var toolStrip = this.reportViewer1.Controls.Find("toolStrip1", true)[0] as ToolStrip;

            if (toolStrip != null)
                foreach (var dropDownButton in toolStrip.Items.OfType<ToolStripDropDownButton>())
                    dropDownButton.DropDownOpened += new EventHandler(dropDownButton_DropDownOpened);
        }

        void dropDownButton_DropDownOpened(object sender, EventArgs e)
        {
            if (sender is ToolStripDropDownButton)
            {
                var ddList = sender as ToolStripDropDownButton;
                foreach (var item in ddList.DropDownItems.OfType<ToolStripDropDownItem>())
                    if (item.Text.Contains("PDF"))
                        item.Enabled = false;
            }
        }

        private void CarregarReserva()
        {
            Banco banco = new Banco();
            banco.Conectar();

            var sql = "SELECT idReserva, dataReserva,horaReserva,status,nomeFunc,nomeCli,nomeServico,obs FROM reserva INNER JOIN funcionario ON reserva.idFuncionario = funcionario.idFuncionario INNER JOIN cliente ON reserva.idCliente = cliente.idCliente INNER JOIN servico ON reserva.idServico = Servico.idServico ORDER BY dataReserva,horaReserva";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            ds.Clear();
            da.Fill(ds);
            ds.Tables[0].TableName = "DataTable1";
            DataTable1BindingSource.DataSource = ds;

            banco.Desconectar();
        }

        private void CarregarReservaHoje()
        {
            Banco banco = new Banco();
            banco.Conectar();

            var sql = "SELECT idReserva, dataReserva,horaReserva,status,nomeFunc,nomeCli,nomeServico,obs FROM reserva INNER JOIN funcionario ON reserva.idFuncionario = funcionario.idFuncionario INNER JOIN cliente ON reserva.idCliente = cliente.idCliente INNER JOIN servico ON reserva.idServico = Servico.idServico WHERE DATE(dataReserva) = DATE(NOW()) ORDER BY dataReserva,horaReserva";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            ds.Clear();
            da.Fill(ds);
            ds.Tables[0].TableName = "DataTable1";
            DataTable1BindingSource.DataSource = ds;

            banco.Desconectar();
        }

        private void CarregarReservaStatus()
        {
            Banco banco = new Banco();
            banco.Conectar();

            var sql = "SELECT idReserva, dataReserva,horaReserva,status,nomeFunc,nomeCli,nomeServico,obs FROM reserva INNER JOIN funcionario ON reserva.idFuncionario = funcionario.idFuncionario INNER JOIN cliente ON reserva.idCliente = cliente.idCliente INNER JOIN servico ON reserva.idServico = Servico.idServico WHERE status=@status ORDER BY dataReserva,horaReserva";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            cmd.Parameters.AddWithValue("@status", status);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            ds.Clear();
            da.Fill(ds);
            ds.Tables[0].TableName = "DataTable1";
            DataTable1BindingSource.DataSource = ds;

            banco.Desconectar();
        }

        private void frmRelatorio_Load(object sender, EventArgs e)
        {
            DesabilitarPDF();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            menu.Show();
            Close();
        }

        private void btnGeral_Click(object sender, EventArgs e)
        {
            CarregarReserva();
            this.reportViewer1.RefreshReport();
        }

        private void btnTodasHoje_Click(object sender, EventArgs e)
        {
            CarregarReservaHoje();
            this.reportViewer1.RefreshReport();
        }

        private void btnAguardando_Click(object sender, EventArgs e)
        {
            status = "AGUARDANDO";
            CarregarReservaStatus();
            this.reportViewer1.RefreshReport();
        }

        private void btnAprovado_Click(object sender, EventArgs e)
        {
            status = "APROVADO";
            CarregarReservaStatus();
            this.reportViewer1.RefreshReport();
        }

        private void btnCancelado_Click(object sender, EventArgs e)
        {
            status = "CANCELADO";
            CarregarReservaStatus();
            this.reportViewer1.RefreshReport();
        }

        private void btnFinalizado_Click(object sender, EventArgs e)
        {
            status = "FINALIZADO";
            CarregarReservaStatus();
            this.reportViewer1.RefreshReport();
        }

        private void btnReprovado_Click(object sender, EventArgs e)
        {
            status = "REPROVADA";
            CarregarReservaStatus();
            this.reportViewer1.RefreshReport();
        }
    }
}
