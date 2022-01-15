
namespace DesktopK
{
    partial class frmCadReserva
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAdicionarReserva = new System.Windows.Forms.Label();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.cmbServico = new System.Windows.Forms.ComboBox();
            this.cmbProfissional = new System.Windows.Forms.ComboBox();
            this.cmbHorario = new System.Windows.Forms.ComboBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblProfissional = new System.Windows.Forms.Label();
            this.lblServico = new System.Windows.Forms.Label();
            this.lblHorario = new System.Windows.Forms.Label();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.lblDataReserva = new System.Windows.Forms.Label();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.calReserva = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // lblAdicionarReserva
            // 
            this.lblAdicionarReserva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblAdicionarReserva.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdicionarReserva.ForeColor = System.Drawing.Color.White;
            this.lblAdicionarReserva.Location = new System.Drawing.Point(150, 0);
            this.lblAdicionarReserva.Name = "lblAdicionarReserva";
            this.lblAdicionarReserva.Size = new System.Drawing.Size(751, 43);
            this.lblAdicionarReserva.TabIndex = 20;
            this.lblAdicionarReserva.Text = "ADICIONAR RESERVA";
            this.lblAdicionarReserva.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbCliente
            // 
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(169, 87);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(707, 21);
            this.cmbCliente.TabIndex = 60;
            this.cmbCliente.SelectionChangeCommitted += new System.EventHandler(this.cmbCliente_SelectionChangeCommitted);
            // 
            // cmbServico
            // 
            this.cmbServico.Enabled = false;
            this.cmbServico.FormattingEnabled = true;
            this.cmbServico.Location = new System.Drawing.Point(528, 153);
            this.cmbServico.Name = "cmbServico";
            this.cmbServico.Size = new System.Drawing.Size(348, 21);
            this.cmbServico.TabIndex = 61;
            this.cmbServico.SelectionChangeCommitted += new System.EventHandler(this.cmbServico_SelectionChangeCommitted);
            // 
            // cmbProfissional
            // 
            this.cmbProfissional.Enabled = false;
            this.cmbProfissional.FormattingEnabled = true;
            this.cmbProfissional.Location = new System.Drawing.Point(169, 153);
            this.cmbProfissional.Name = "cmbProfissional";
            this.cmbProfissional.Size = new System.Drawing.Size(341, 21);
            this.cmbProfissional.TabIndex = 62;
            this.cmbProfissional.SelectionChangeCommitted += new System.EventHandler(this.cmbProfissional_SelectionChangeCommitted);
            // 
            // cmbHorario
            // 
            this.cmbHorario.Enabled = false;
            this.cmbHorario.FormattingEnabled = true;
            this.cmbHorario.Location = new System.Drawing.Point(528, 275);
            this.cmbHorario.Name = "cmbHorario";
            this.cmbHorario.Size = new System.Drawing.Size(167, 21);
            this.cmbHorario.TabIndex = 63;
            this.cmbHorario.SelectionChangeCommitted += new System.EventHandler(this.cmbHorario_SelectionChangeCommitted);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblCliente.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblCliente.Location = new System.Drawing.Point(167, 68);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(133, 16);
            this.lblCliente.TabIndex = 64;
            this.lblCliente.Text = "NOME DO CLIENTE:";
            // 
            // lblProfissional
            // 
            this.lblProfissional.AutoSize = true;
            this.lblProfissional.BackColor = System.Drawing.Color.Transparent;
            this.lblProfissional.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfissional.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblProfissional.Location = new System.Drawing.Point(167, 134);
            this.lblProfissional.Name = "lblProfissional";
            this.lblProfissional.Size = new System.Drawing.Size(199, 16);
            this.lblProfissional.TabIndex = 65;
            this.lblProfissional.Text = "SELECIONE O PROFISSIONAL:";
            // 
            // lblServico
            // 
            this.lblServico.AutoSize = true;
            this.lblServico.BackColor = System.Drawing.Color.Transparent;
            this.lblServico.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblServico.Location = new System.Drawing.Point(525, 134);
            this.lblServico.Name = "lblServico";
            this.lblServico.Size = new System.Drawing.Size(160, 16);
            this.lblServico.TabIndex = 66;
            this.lblServico.Text = "SELECIONE O SERVIÇO:";
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.BackColor = System.Drawing.Color.Transparent;
            this.lblHorario.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblHorario.Location = new System.Drawing.Point(525, 256);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(170, 16);
            this.lblHorario.TabIndex = 67;
            this.lblHorario.Text = "HORÁRIOS DISPONÍVEIS:";
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.BackColor = System.Drawing.Color.Transparent;
            this.lblObservacao.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblObservacao.Location = new System.Drawing.Point(167, 195);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(99, 16);
            this.lblObservacao.TabIndex = 68;
            this.lblObservacao.Text = "OBSERVAÇÃO:";
            // 
            // lblDataReserva
            // 
            this.lblDataReserva.AutoSize = true;
            this.lblDataReserva.BackColor = System.Drawing.Color.Transparent;
            this.lblDataReserva.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataReserva.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblDataReserva.Location = new System.Drawing.Point(286, 256);
            this.lblDataReserva.Name = "lblDataReserva";
            this.lblDataReserva.Size = new System.Drawing.Size(219, 16);
            this.lblDataReserva.TabIndex = 69;
            this.lblDataReserva.Text = "SELECIONE A DATA DA RESERVA:";
            // 
            // txtObservacao
            // 
            this.txtObservacao.Enabled = false;
            this.txtObservacao.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.txtObservacao.Location = new System.Drawing.Point(169, 214);
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(707, 24);
            this.txtObservacao.TabIndex = 70;
            this.txtObservacao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtObservacao_KeyPress);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.btnSalvar.Enabled = false;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(654, 402);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(108, 36);
            this.btnSalvar.TabIndex = 72;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Location = new System.Drawing.Point(768, 402);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(108, 36);
            this.btnFechar.TabIndex = 71;
            this.btnFechar.Text = "FECHAR";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // calReserva
            // 
            this.calReserva.Location = new System.Drawing.Point(282, 275);
            this.calReserva.Name = "calReserva";
            this.calReserva.TabIndex = 73;
            this.calReserva.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.calReserva_DateSelected);
            // 
            // frmCadReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DesktopK.Properties.Resources.reserva;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.calReserva);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.txtObservacao);
            this.Controls.Add(this.lblDataReserva);
            this.Controls.Add(this.lblObservacao);
            this.Controls.Add(this.lblHorario);
            this.Controls.Add(this.lblServico);
            this.Controls.Add(this.lblProfissional);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.cmbHorario);
            this.Controls.Add(this.cmbProfissional);
            this.Controls.Add(this.cmbServico);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.lblAdicionarReserva);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCadReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadReserva";
            this.Load += new System.EventHandler(this.frmCadReserva_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdicionarReserva;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.ComboBox cmbServico;
        private System.Windows.Forms.ComboBox cmbProfissional;
        private System.Windows.Forms.ComboBox cmbHorario;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblProfissional;
        private System.Windows.Forms.Label lblServico;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.Label lblObservacao;
        private System.Windows.Forms.Label lblDataReserva;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.MonthCalendar calReserva;
    }
}