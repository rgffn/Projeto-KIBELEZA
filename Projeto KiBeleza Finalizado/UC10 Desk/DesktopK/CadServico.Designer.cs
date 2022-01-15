
namespace DesktopK
{
    partial class frmCadServico
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
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblAdicionarServico = new System.Windows.Forms.Label();
            this.cmbDuracaoServico = new System.Windows.Forms.ComboBox();
            this.lbLDuracaoServico = new System.Windows.Forms.Label();
            this.lblDataCadastro = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtDataCadastro = new System.Windows.Forms.MaskedTextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtNomeServico = new System.Windows.Forms.TextBox();
            this.lblNomeServico = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.lblTexto = new System.Windows.Forms.Label();
            this.cmbEmpresa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtFoto3 = new System.Windows.Forms.TextBox();
            this.pctFoto3 = new System.Windows.Forms.PictureBox();
            this.txtFoto2 = new System.Windows.Forms.TextBox();
            this.pctFoto2 = new System.Windows.Forms.PictureBox();
            this.txtFoto1 = new System.Windows.Forms.TextBox();
            this.pctFoto1 = new System.Windows.Forms.PictureBox();
            this.txtFoto = new System.Windows.Forms.TextBox();
            this.pctFoto = new System.Windows.Forms.PictureBox();
            this.lblFotos = new System.Windows.Forms.Label();
            this.ofdFoto = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctFoto3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctFoto2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctFoto1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.btnSalvar.Enabled = false;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(429, 413);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(108, 36);
            this.btnSalvar.TabIndex = 21;
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
            this.btnFechar.Location = new System.Drawing.Point(543, 413);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(108, 36);
            this.btnFechar.TabIndex = 20;
            this.btnFechar.Text = "FECHAR";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblAdicionarServico
            // 
            this.lblAdicionarServico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblAdicionarServico.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdicionarServico.ForeColor = System.Drawing.Color.White;
            this.lblAdicionarServico.Location = new System.Drawing.Point(150, -2);
            this.lblAdicionarServico.Name = "lblAdicionarServico";
            this.lblAdicionarServico.Size = new System.Drawing.Size(751, 43);
            this.lblAdicionarServico.TabIndex = 19;
            this.lblAdicionarServico.Text = "ADICIONAR SERVIÇO";
            this.lblAdicionarServico.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbDuracaoServico
            // 
            this.cmbDuracaoServico.Enabled = false;
            this.cmbDuracaoServico.FormattingEnabled = true;
            this.cmbDuracaoServico.Items.AddRange(new object[] {
            "0:30",
            "1:00",
            "1:30",
            "2:00",
            "2:30",
            "3:00",
            "3:30",
            "4:00"});
            this.cmbDuracaoServico.Location = new System.Drawing.Point(172, 229);
            this.cmbDuracaoServico.Name = "cmbDuracaoServico";
            this.cmbDuracaoServico.Size = new System.Drawing.Size(133, 21);
            this.cmbDuracaoServico.TabIndex = 48;
            this.cmbDuracaoServico.SelectedIndexChanged += new System.EventHandler(this.cmbDuracaoServico_SelectedIndexChanged);
            // 
            // lbLDuracaoServico
            // 
            this.lbLDuracaoServico.AutoSize = true;
            this.lbLDuracaoServico.BackColor = System.Drawing.Color.Transparent;
            this.lbLDuracaoServico.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLDuracaoServico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lbLDuracaoServico.Location = new System.Drawing.Point(169, 213);
            this.lbLDuracaoServico.Name = "lbLDuracaoServico";
            this.lbLDuracaoServico.Size = new System.Drawing.Size(136, 16);
            this.lbLDuracaoServico.TabIndex = 52;
            this.lbLDuracaoServico.Text = "DURAÇÃO SERVIÇO:";
            // 
            // lblDataCadastro
            // 
            this.lblDataCadastro.AutoSize = true;
            this.lblDataCadastro.BackColor = System.Drawing.Color.Transparent;
            this.lblDataCadastro.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataCadastro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblDataCadastro.Location = new System.Drawing.Point(372, 99);
            this.lblDataCadastro.Name = "lblDataCadastro";
            this.lblDataCadastro.Size = new System.Drawing.Size(120, 16);
            this.lblDataCadastro.TabIndex = 51;
            this.lblDataCadastro.Text = "DATA CADASTRO:";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.BackColor = System.Drawing.Color.Transparent;
            this.lblDescricao.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblDescricao.Location = new System.Drawing.Point(169, 142);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(88, 16);
            this.lblDescricao.TabIndex = 50;
            this.lblDescricao.Text = "DESCRIÇÃO:";
            // 
            // txtDataCadastro
            // 
            this.txtDataCadastro.Enabled = false;
            this.txtDataCadastro.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataCadastro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.txtDataCadastro.Location = new System.Drawing.Point(375, 116);
            this.txtDataCadastro.Mask = "00/00/0000";
            this.txtDataCadastro.Name = "txtDataCadastro";
            this.txtDataCadastro.Size = new System.Drawing.Size(176, 24);
            this.txtDataCadastro.TabIndex = 49;
            this.txtDataCadastro.ValidatingType = typeof(System.DateTime);
            this.txtDataCadastro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDataCadastro_KeyPress);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.txtCodigo.Location = new System.Drawing.Point(172, 69);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(115, 24);
            this.txtCodigo.TabIndex = 47;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.BackColor = System.Drawing.Color.Transparent;
            this.lblCodigo.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblCodigo.Location = new System.Drawing.Point(169, 50);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(65, 16);
            this.lblCodigo.TabIndex = 46;
            this.lblCodigo.Text = "CÓDIGO:";
            // 
            // txtNomeServico
            // 
            this.txtNomeServico.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeServico.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeServico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.txtNomeServico.Location = new System.Drawing.Point(309, 69);
            this.txtNomeServico.Name = "txtNomeServico";
            this.txtNomeServico.Size = new System.Drawing.Size(430, 24);
            this.txtNomeServico.TabIndex = 55;
            this.txtNomeServico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomeServico_KeyPress);
            // 
            // lblNomeServico
            // 
            this.lblNomeServico.AutoSize = true;
            this.lblNomeServico.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeServico.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeServico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblNomeServico.Location = new System.Drawing.Point(306, 50);
            this.lblNomeServico.Name = "lblNomeServico";
            this.lblNomeServico.Size = new System.Drawing.Size(135, 16);
            this.lblNomeServico.TabIndex = 54;
            this.lblNomeServico.Text = "NOME DO SERVIÇO:";
            // 
            // txtValor
            // 
            this.txtValor.Enabled = false;
            this.txtValor.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.txtValor.Location = new System.Drawing.Point(754, 69);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(121, 24);
            this.txtValor.TabIndex = 57;
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.BackColor = System.Drawing.Color.Transparent;
            this.lblValor.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblValor.Location = new System.Drawing.Point(751, 50);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(55, 16);
            this.lblValor.TabIndex = 56;
            this.lblValor.Text = "VALOR:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblStatus.Location = new System.Drawing.Point(169, 99);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(61, 16);
            this.lblStatus.TabIndex = 58;
            this.lblStatus.Text = "STATUS:";
            // 
            // cmbStatus
            // 
            this.cmbStatus.Enabled = false;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "ATIVO",
            "INATIVO"});
            this.cmbStatus.Location = new System.Drawing.Point(172, 118);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(183, 21);
            this.cmbStatus.TabIndex = 59;
            this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.cmbStatus_SelectedIndexChanged);
            // 
            // txtDescricao
            // 
            this.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescricao.Enabled = false;
            this.txtDescricao.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.txtDescricao.Location = new System.Drawing.Point(172, 161);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(379, 49);
            this.txtDescricao.TabIndex = 60;
            this.txtDescricao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescricao_KeyPress);
            // 
            // txtTexto
            // 
            this.txtTexto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTexto.Enabled = false;
            this.txtTexto.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTexto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.txtTexto.Location = new System.Drawing.Point(572, 116);
            this.txtTexto.Multiline = true;
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(303, 94);
            this.txtTexto.TabIndex = 62;
            this.txtTexto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTexto_KeyPress);
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.BackColor = System.Drawing.Color.Transparent;
            this.lblTexto.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblTexto.Location = new System.Drawing.Point(569, 99);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(55, 16);
            this.lblTexto.TabIndex = 61;
            this.lblTexto.Text = "TEXTO:";
            // 
            // cmbEmpresa
            // 
            this.cmbEmpresa.Enabled = false;
            this.cmbEmpresa.FormattingEnabled = true;
            this.cmbEmpresa.Location = new System.Drawing.Point(334, 229);
            this.cmbEmpresa.Name = "cmbEmpresa";
            this.cmbEmpresa.Size = new System.Drawing.Size(541, 21);
            this.cmbEmpresa.TabIndex = 63;
            this.cmbEmpresa.SelectedIndexChanged += new System.EventHandler(this.cmbEmpresa_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.label1.Location = new System.Drawing.Point(331, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 64;
            this.label1.Text = "EMPRESA:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.pctFoto3);
            this.panel1.Controls.Add(this.pctFoto2);
            this.panel1.Controls.Add(this.pctFoto1);
            this.panel1.Controls.Add(this.pctFoto);
            this.panel1.Controls.Add(this.txtFoto3);
            this.panel1.Controls.Add(this.txtFoto2);
            this.panel1.Controls.Add(this.txtFoto1);
            this.panel1.Controls.Add(this.txtFoto);
            this.panel1.Controls.Add(this.lblFotos);
            this.panel1.Location = new System.Drawing.Point(172, 256);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(703, 157);
            this.panel1.TabIndex = 65;
            // 
            // txtFoto3
            // 
            this.txtFoto3.Enabled = false;
            this.txtFoto3.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFoto3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.txtFoto3.Location = new System.Drawing.Point(539, 117);
            this.txtFoto3.Name = "txtFoto3";
            this.txtFoto3.Size = new System.Drawing.Size(158, 24);
            this.txtFoto3.TabIndex = 72;
            // 
            // pctFoto3
            // 
            this.pctFoto3.BackColor = System.Drawing.SystemColors.Control;
            this.pctFoto3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctFoto3.Enabled = false;
            this.pctFoto3.Location = new System.Drawing.Point(539, 25);
            this.pctFoto3.Name = "pctFoto3";
            this.pctFoto3.Size = new System.Drawing.Size(158, 116);
            this.pctFoto3.TabIndex = 73;
            this.pctFoto3.TabStop = false;
            this.pctFoto3.Click += new System.EventHandler(this.pctFoto3_Click);
            // 
            // txtFoto2
            // 
            this.txtFoto2.Enabled = false;
            this.txtFoto2.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFoto2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.txtFoto2.Location = new System.Drawing.Point(371, 117);
            this.txtFoto2.Name = "txtFoto2";
            this.txtFoto2.Size = new System.Drawing.Size(162, 24);
            this.txtFoto2.TabIndex = 70;
            // 
            // pctFoto2
            // 
            this.pctFoto2.BackColor = System.Drawing.SystemColors.Control;
            this.pctFoto2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctFoto2.Enabled = false;
            this.pctFoto2.Location = new System.Drawing.Point(371, 25);
            this.pctFoto2.Name = "pctFoto2";
            this.pctFoto2.Size = new System.Drawing.Size(162, 116);
            this.pctFoto2.TabIndex = 71;
            this.pctFoto2.TabStop = false;
            this.pctFoto2.Click += new System.EventHandler(this.pctFoto2_Click);
            // 
            // txtFoto1
            // 
            this.txtFoto1.Enabled = false;
            this.txtFoto1.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFoto1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.txtFoto1.Location = new System.Drawing.Point(203, 117);
            this.txtFoto1.Name = "txtFoto1";
            this.txtFoto1.Size = new System.Drawing.Size(162, 24);
            this.txtFoto1.TabIndex = 68;
            // 
            // pctFoto1
            // 
            this.pctFoto1.BackColor = System.Drawing.SystemColors.Control;
            this.pctFoto1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctFoto1.Enabled = false;
            this.pctFoto1.Location = new System.Drawing.Point(203, 25);
            this.pctFoto1.Name = "pctFoto1";
            this.pctFoto1.Size = new System.Drawing.Size(162, 116);
            this.pctFoto1.TabIndex = 69;
            this.pctFoto1.TabStop = false;
            this.pctFoto1.Click += new System.EventHandler(this.pctFoto1_Click);
            // 
            // txtFoto
            // 
            this.txtFoto.Enabled = false;
            this.txtFoto.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFoto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.txtFoto.Location = new System.Drawing.Point(35, 117);
            this.txtFoto.Name = "txtFoto";
            this.txtFoto.Size = new System.Drawing.Size(162, 24);
            this.txtFoto.TabIndex = 66;
            // 
            // pctFoto
            // 
            this.pctFoto.BackColor = System.Drawing.SystemColors.Control;
            this.pctFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctFoto.Enabled = false;
            this.pctFoto.Location = new System.Drawing.Point(35, 25);
            this.pctFoto.Name = "pctFoto";
            this.pctFoto.Size = new System.Drawing.Size(162, 116);
            this.pctFoto.TabIndex = 67;
            this.pctFoto.TabStop = false;
            this.pctFoto.Click += new System.EventHandler(this.pctFoto_Click);
            // 
            // lblFotos
            // 
            this.lblFotos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblFotos.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblFotos.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFotos.ForeColor = System.Drawing.Color.White;
            this.lblFotos.Location = new System.Drawing.Point(0, 0);
            this.lblFotos.Name = "lblFotos";
            this.lblFotos.Size = new System.Drawing.Size(33, 157);
            this.lblFotos.TabIndex = 66;
            this.lblFotos.Text = "FOTOS";
            this.lblFotos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ofdFoto
            // 
            this.ofdFoto.FileName = "openFileDialog1";
            // 
            // frmCadServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DesktopK.Properties.Resources.servico;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmbEmpresa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTexto);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.cmbDuracaoServico);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.txtNomeServico);
            this.Controls.Add(this.lblNomeServico);
            this.Controls.Add(this.lbLDuracaoServico);
            this.Controls.Add(this.lblDataCadastro);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.txtDataCadastro);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.lblAdicionarServico);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCadServico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadServico";
            this.Load += new System.EventHandler(this.frmCadServico_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctFoto3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctFoto2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctFoto1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblAdicionarServico;
        private System.Windows.Forms.ComboBox cmbDuracaoServico;
        private System.Windows.Forms.Label lbLDuracaoServico;
        private System.Windows.Forms.Label lblDataCadastro;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.MaskedTextBox txtDataCadastro;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtNomeServico;
        private System.Windows.Forms.Label lblNomeServico;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.ComboBox cmbEmpresa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtFoto2;
        private System.Windows.Forms.PictureBox pctFoto2;
        private System.Windows.Forms.TextBox txtFoto1;
        private System.Windows.Forms.PictureBox pctFoto1;
        private System.Windows.Forms.TextBox txtFoto;
        private System.Windows.Forms.PictureBox pctFoto;
        private System.Windows.Forms.Label lblFotos;
        private System.Windows.Forms.TextBox txtFoto3;
        private System.Windows.Forms.PictureBox pctFoto3;
        private System.Windows.Forms.OpenFileDialog ofdFoto;
    }
}