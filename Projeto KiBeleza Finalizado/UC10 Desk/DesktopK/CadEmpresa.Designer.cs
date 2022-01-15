
namespace DesktopK
{
    partial class frmCadEmpresa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.TelefoneEmpresa = new System.Windows.Forms.Panel();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnAdicionarTelefone = new System.Windows.Forms.Button();
            this.dgvFoneEmpresa = new System.Windows.Forms.DataGridView();
            this.CadFoneEmpresa = new System.Windows.Forms.Panel();
            this.btnFecharFone = new System.Windows.Forms.Button();
            this.btnSalvarFone = new System.Windows.Forms.Button();
            this.cmbDescFone = new System.Windows.Forms.ComboBox();
            this.cmbTipFone = new System.Windows.Forms.ComboBox();
            this.lblDescFone = new System.Windows.Forms.Label();
            this.lblNumFone = new System.Windows.Forms.Label();
            this.lblTipFone = new System.Windows.Forms.Label();
            this.txtNumFone = new System.Windows.Forms.MaskedTextBox();
            this.txtCodFone = new System.Windows.Forms.TextBox();
            this.lblCodFone = new System.Windows.Forms.Label();
            this.lblAdicionarFoneCliente = new System.Windows.Forms.Label();
            this.txtDataCadastro = new System.Windows.Forms.MaskedTextBox();
            this.lblDataCadastro = new System.Windows.Forms.Label();
            this.txtRazaoSocial = new System.Windows.Forms.TextBox();
            this.lblRazaoSocial = new System.Windows.Forms.Label();
            this.txtNomeEmpresa = new System.Windows.Forms.TextBox();
            this.lblNomeFantasiaEmpresa = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblAdicionarEmpresa = new System.Windows.Forms.Label();
            this.txtCnpjCpf = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radCNPJ = new System.Windows.Forms.RadioButton();
            this.radCPF = new System.Windows.Forms.RadioButton();
            this.lblHorarioAtendimento = new System.Windows.Forms.Label();
            this.cmbHorarioAtendimento = new System.Windows.Forms.ComboBox();
            this.TelefoneEmpresa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoneEmpresa)).BeginInit();
            this.CadFoneEmpresa.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.BackColor = System.Drawing.Color.Transparent;
            this.lblCodigo.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblCodigo.Location = new System.Drawing.Point(162, 56);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(65, 16);
            this.lblCodigo.TabIndex = 38;
            this.lblCodigo.Text = "CÓDIGO:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblStatus.Location = new System.Drawing.Point(561, 165);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(61, 16);
            this.lblStatus.TabIndex = 53;
            this.lblStatus.Text = "STATUS:";
            // 
            // cmbStatus
            // 
            this.cmbStatus.Enabled = false;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "ATIVO",
            "INATIVO",
            ""});
            this.cmbStatus.Location = new System.Drawing.Point(564, 184);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(151, 21);
            this.cmbStatus.TabIndex = 52;
            this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.cmbStatus_SelectedIndexChanged);
            // 
            // TelefoneEmpresa
            // 
            this.TelefoneEmpresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.TelefoneEmpresa.BackgroundImage = global::DesktopK.Properties.Resources.fonemepresa;
            this.TelefoneEmpresa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TelefoneEmpresa.Controls.Add(this.btnExcluir);
            this.TelefoneEmpresa.Controls.Add(this.btnAlterar);
            this.TelefoneEmpresa.Controls.Add(this.btnAdicionarTelefone);
            this.TelefoneEmpresa.Controls.Add(this.dgvFoneEmpresa);
            this.TelefoneEmpresa.Enabled = false;
            this.TelefoneEmpresa.Location = new System.Drawing.Point(164, 241);
            this.TelefoneEmpresa.Name = "TelefoneEmpresa";
            this.TelefoneEmpresa.Size = new System.Drawing.Size(415, 197);
            this.TelefoneEmpresa.TabIndex = 51;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(303, 168);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(108, 24);
            this.btnExcluir.TabIndex = 36;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ForeColor = System.Drawing.Color.White;
            this.btnAlterar.Location = new System.Drawing.Point(188, 168);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(108, 24);
            this.btnAlterar.TabIndex = 35;
            this.btnAlterar.Text = "ALTERAR";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnAdicionarTelefone
            // 
            this.btnAdicionarTelefone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.btnAdicionarTelefone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarTelefone.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarTelefone.ForeColor = System.Drawing.Color.White;
            this.btnAdicionarTelefone.Location = new System.Drawing.Point(72, 168);
            this.btnAdicionarTelefone.Name = "btnAdicionarTelefone";
            this.btnAdicionarTelefone.Size = new System.Drawing.Size(108, 24);
            this.btnAdicionarTelefone.TabIndex = 34;
            this.btnAdicionarTelefone.Text = "ADICIONAR";
            this.btnAdicionarTelefone.UseVisualStyleBackColor = false;
            this.btnAdicionarTelefone.Click += new System.EventHandler(this.btnAdicionarTelefone_Click);
            // 
            // dgvFoneEmpresa
            // 
            this.dgvFoneEmpresa.AllowUserToAddRows = false;
            this.dgvFoneEmpresa.AllowUserToDeleteRows = false;
            this.dgvFoneEmpresa.AllowUserToResizeColumns = false;
            this.dgvFoneEmpresa.AllowUserToResizeRows = false;
            this.dgvFoneEmpresa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFoneEmpresa.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.dgvFoneEmpresa.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvFoneEmpresa.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFoneEmpresa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFoneEmpresa.ColumnHeadersHeight = 40;
            this.dgvFoneEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(52)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFoneEmpresa.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvFoneEmpresa.EnableHeadersVisualStyles = false;
            this.dgvFoneEmpresa.Location = new System.Drawing.Point(72, 4);
            this.dgvFoneEmpresa.MultiSelect = false;
            this.dgvFoneEmpresa.Name = "dgvFoneEmpresa";
            this.dgvFoneEmpresa.ReadOnly = true;
            this.dgvFoneEmpresa.RowHeadersVisible = false;
            this.dgvFoneEmpresa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFoneEmpresa.Size = new System.Drawing.Size(339, 158);
            this.dgvFoneEmpresa.TabIndex = 0;
            this.dgvFoneEmpresa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFoneEmpresa_CellClick);
            // 
            // CadFoneEmpresa
            // 
            this.CadFoneEmpresa.BackgroundImage = global::DesktopK.Properties.Resources.fonemepresa;
            this.CadFoneEmpresa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CadFoneEmpresa.Controls.Add(this.btnFecharFone);
            this.CadFoneEmpresa.Controls.Add(this.btnSalvarFone);
            this.CadFoneEmpresa.Controls.Add(this.cmbDescFone);
            this.CadFoneEmpresa.Controls.Add(this.cmbTipFone);
            this.CadFoneEmpresa.Controls.Add(this.lblDescFone);
            this.CadFoneEmpresa.Controls.Add(this.lblNumFone);
            this.CadFoneEmpresa.Controls.Add(this.lblTipFone);
            this.CadFoneEmpresa.Controls.Add(this.txtNumFone);
            this.CadFoneEmpresa.Controls.Add(this.txtCodFone);
            this.CadFoneEmpresa.Controls.Add(this.lblCodFone);
            this.CadFoneEmpresa.Controls.Add(this.lblAdicionarFoneCliente);
            this.CadFoneEmpresa.Location = new System.Drawing.Point(156, 56);
            this.CadFoneEmpresa.Name = "CadFoneEmpresa";
            this.CadFoneEmpresa.Size = new System.Drawing.Size(713, 382);
            this.CadFoneEmpresa.TabIndex = 64;
            this.CadFoneEmpresa.Visible = false;
            // 
            // btnFecharFone
            // 
            this.btnFecharFone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.btnFecharFone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFecharFone.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFecharFone.ForeColor = System.Drawing.Color.White;
            this.btnFecharFone.Location = new System.Drawing.Point(424, 324);
            this.btnFecharFone.Name = "btnFecharFone";
            this.btnFecharFone.Size = new System.Drawing.Size(108, 36);
            this.btnFecharFone.TabIndex = 47;
            this.btnFecharFone.Text = "FECHAR";
            this.btnFecharFone.UseVisualStyleBackColor = false;
            this.btnFecharFone.Click += new System.EventHandler(this.btnFecharFone_Click);
            // 
            // btnSalvarFone
            // 
            this.btnSalvarFone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.btnSalvarFone.Enabled = false;
            this.btnSalvarFone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarFone.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarFone.ForeColor = System.Drawing.Color.White;
            this.btnSalvarFone.Location = new System.Drawing.Point(310, 324);
            this.btnSalvarFone.Name = "btnSalvarFone";
            this.btnSalvarFone.Size = new System.Drawing.Size(108, 36);
            this.btnSalvarFone.TabIndex = 46;
            this.btnSalvarFone.Text = "SALVAR";
            this.btnSalvarFone.UseVisualStyleBackColor = false;
            this.btnSalvarFone.Click += new System.EventHandler(this.btnSalvarFone_Click);
            // 
            // cmbDescFone
            // 
            this.cmbDescFone.Enabled = false;
            this.cmbDescFone.FormattingEnabled = true;
            this.cmbDescFone.Items.AddRange(new object[] {
            "FIXO",
            "CELULAR",
            "RECADO"});
            this.cmbDescFone.Location = new System.Drawing.Point(345, 274);
            this.cmbDescFone.Name = "cmbDescFone";
            this.cmbDescFone.Size = new System.Drawing.Size(155, 21);
            this.cmbDescFone.TabIndex = 40;
            this.cmbDescFone.SelectedIndexChanged += new System.EventHandler(this.cmbDescFone_SelectedIndexChanged);
            // 
            // cmbTipFone
            // 
            this.cmbTipFone.Enabled = false;
            this.cmbTipFone.FormattingEnabled = true;
            this.cmbTipFone.Items.AddRange(new object[] {
            "CLARO",
            "TIM",
            "OI",
            "VIVO",
            "NEXTEL",
            "OUTROS"});
            this.cmbTipFone.Location = new System.Drawing.Point(345, 210);
            this.cmbTipFone.Name = "cmbTipFone";
            this.cmbTipFone.Size = new System.Drawing.Size(155, 21);
            this.cmbTipFone.TabIndex = 45;
            this.cmbTipFone.SelectedIndexChanged += new System.EventHandler(this.cmbTipFone_SelectedIndexChanged);
            // 
            // lblDescFone
            // 
            this.lblDescFone.AutoSize = true;
            this.lblDescFone.BackColor = System.Drawing.Color.Transparent;
            this.lblDescFone.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescFone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblDescFone.Location = new System.Drawing.Point(342, 255);
            this.lblDescFone.Name = "lblDescFone";
            this.lblDescFone.Size = new System.Drawing.Size(158, 16);
            this.lblDescFone.TabIndex = 44;
            this.lblDescFone.Text = "DESCRIÇÃO TELEFONE:";
            // 
            // lblNumFone
            // 
            this.lblNumFone.AutoSize = true;
            this.lblNumFone.BackColor = System.Drawing.Color.Transparent;
            this.lblNumFone.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumFone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblNumFone.Location = new System.Drawing.Point(342, 127);
            this.lblNumFone.Name = "lblNumFone";
            this.lblNumFone.Size = new System.Drawing.Size(138, 16);
            this.lblNumFone.TabIndex = 43;
            this.lblNumFone.Text = "NÚMERO TELEFONE:";
            // 
            // lblTipFone
            // 
            this.lblTipFone.AutoSize = true;
            this.lblTipFone.BackColor = System.Drawing.Color.Transparent;
            this.lblTipFone.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipFone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblTipFone.Location = new System.Drawing.Point(342, 191);
            this.lblTipFone.Name = "lblTipFone";
            this.lblTipFone.Size = new System.Drawing.Size(114, 16);
            this.lblTipFone.TabIndex = 42;
            this.lblTipFone.Text = "TIPO TELEFONE:";
            // 
            // txtNumFone
            // 
            this.txtNumFone.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumFone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.txtNumFone.Location = new System.Drawing.Point(345, 146);
            this.txtNumFone.Mask = "(99) 99000-0000";
            this.txtNumFone.Name = "txtNumFone";
            this.txtNumFone.Size = new System.Drawing.Size(155, 24);
            this.txtNumFone.TabIndex = 41;
            this.txtNumFone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumFone_KeyPress);
            // 
            // txtCodFone
            // 
            this.txtCodFone.Enabled = false;
            this.txtCodFone.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodFone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.txtCodFone.Location = new System.Drawing.Point(345, 79);
            this.txtCodFone.Name = "txtCodFone";
            this.txtCodFone.Size = new System.Drawing.Size(155, 24);
            this.txtCodFone.TabIndex = 39;
            // 
            // lblCodFone
            // 
            this.lblCodFone.AutoSize = true;
            this.lblCodFone.BackColor = System.Drawing.Color.Transparent;
            this.lblCodFone.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodFone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblCodFone.Location = new System.Drawing.Point(342, 60);
            this.lblCodFone.Name = "lblCodFone";
            this.lblCodFone.Size = new System.Drawing.Size(135, 16);
            this.lblCodFone.TabIndex = 38;
            this.lblCodFone.Text = "CÓDIGO TELEFONE:";
            // 
            // lblAdicionarFoneCliente
            // 
            this.lblAdicionarFoneCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblAdicionarFoneCliente.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdicionarFoneCliente.ForeColor = System.Drawing.Color.White;
            this.lblAdicionarFoneCliente.Location = new System.Drawing.Point(117, 1);
            this.lblAdicionarFoneCliente.Name = "lblAdicionarFoneCliente";
            this.lblAdicionarFoneCliente.Size = new System.Drawing.Size(596, 43);
            this.lblAdicionarFoneCliente.TabIndex = 37;
            this.lblAdicionarFoneCliente.Text = "ADICIONAR TELEFONE EMPRESA";
            this.lblAdicionarFoneCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDataCadastro
            // 
            this.txtDataCadastro.Enabled = false;
            this.txtDataCadastro.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataCadastro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.txtDataCadastro.Location = new System.Drawing.Point(730, 181);
            this.txtDataCadastro.Mask = "00/00/0000";
            this.txtDataCadastro.Name = "txtDataCadastro";
            this.txtDataCadastro.Size = new System.Drawing.Size(139, 24);
            this.txtDataCadastro.TabIndex = 49;
            this.txtDataCadastro.ValidatingType = typeof(System.DateTime);
            this.txtDataCadastro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDataCadastro_KeyPress);
            // 
            // lblDataCadastro
            // 
            this.lblDataCadastro.AutoSize = true;
            this.lblDataCadastro.BackColor = System.Drawing.Color.Transparent;
            this.lblDataCadastro.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataCadastro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblDataCadastro.Location = new System.Drawing.Point(727, 162);
            this.lblDataCadastro.Name = "lblDataCadastro";
            this.lblDataCadastro.Size = new System.Drawing.Size(142, 16);
            this.lblDataCadastro.TabIndex = 46;
            this.lblDataCadastro.Text = "DATA DE CADASTRO:";
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRazaoSocial.Enabled = false;
            this.txtRazaoSocial.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRazaoSocial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.txtRazaoSocial.Location = new System.Drawing.Point(410, 131);
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.Size = new System.Drawing.Size(459, 24);
            this.txtRazaoSocial.TabIndex = 43;
            this.txtRazaoSocial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRazaoSocial_KeyPress);
            // 
            // lblRazaoSocial
            // 
            this.lblRazaoSocial.AutoSize = true;
            this.lblRazaoSocial.BackColor = System.Drawing.Color.Transparent;
            this.lblRazaoSocial.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRazaoSocial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblRazaoSocial.Location = new System.Drawing.Point(407, 112);
            this.lblRazaoSocial.Name = "lblRazaoSocial";
            this.lblRazaoSocial.Size = new System.Drawing.Size(107, 16);
            this.lblRazaoSocial.TabIndex = 42;
            this.lblRazaoSocial.Text = "RAZÃO SOCIAL:";
            // 
            // txtNomeEmpresa
            // 
            this.txtNomeEmpresa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeEmpresa.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeEmpresa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.txtNomeEmpresa.Location = new System.Drawing.Point(305, 75);
            this.txtNomeEmpresa.Name = "txtNomeEmpresa";
            this.txtNomeEmpresa.Size = new System.Drawing.Size(564, 24);
            this.txtNomeEmpresa.TabIndex = 41;
            this.txtNomeEmpresa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomeEmpresa_KeyPress);
            // 
            // lblNomeFantasiaEmpresa
            // 
            this.lblNomeFantasiaEmpresa.AutoSize = true;
            this.lblNomeFantasiaEmpresa.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeFantasiaEmpresa.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeFantasiaEmpresa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblNomeFantasiaEmpresa.Location = new System.Drawing.Point(302, 56);
            this.lblNomeFantasiaEmpresa.Name = "lblNomeFantasiaEmpresa";
            this.lblNomeFantasiaEmpresa.Size = new System.Drawing.Size(202, 16);
            this.lblNomeFantasiaEmpresa.TabIndex = 40;
            this.lblNomeFantasiaEmpresa.Text = "NOME FANTASIA DA EMPRESA:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.txtCodigo.Location = new System.Drawing.Point(164, 75);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 24);
            this.txtCodigo.TabIndex = 39;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.btnSalvar.Enabled = false;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(624, 402);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(108, 36);
            this.btnSalvar.TabIndex = 37;
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
            this.btnFechar.Location = new System.Drawing.Point(738, 402);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(108, 36);
            this.btnFechar.TabIndex = 36;
            this.btnFechar.Text = "FECHAR";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblAdicionarEmpresa
            // 
            this.lblAdicionarEmpresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblAdicionarEmpresa.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdicionarEmpresa.ForeColor = System.Drawing.Color.White;
            this.lblAdicionarEmpresa.Location = new System.Drawing.Point(150, -4);
            this.lblAdicionarEmpresa.Name = "lblAdicionarEmpresa";
            this.lblAdicionarEmpresa.Size = new System.Drawing.Size(751, 43);
            this.lblAdicionarEmpresa.TabIndex = 54;
            this.lblAdicionarEmpresa.Text = "ADICIONAR EMPRESA";
            this.lblAdicionarEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCnpjCpf
            // 
            this.txtCnpjCpf.Enabled = false;
            this.txtCnpjCpf.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCnpjCpf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.txtCnpjCpf.Location = new System.Drawing.Point(232, 122);
            this.txtCnpjCpf.Mask = "00,000,000/0000-00";
            this.txtCnpjCpf.Name = "txtCnpjCpf";
            this.txtCnpjCpf.Size = new System.Drawing.Size(141, 24);
            this.txtCnpjCpf.TabIndex = 56;
            this.txtCnpjCpf.ValidatingType = typeof(System.DateTime);
            this.txtCnpjCpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCnpjCpf_KeyPress);
            // 
            // txtEmail
            // 
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtEmail.Enabled = false;
            this.txtEmail.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.txtEmail.Location = new System.Drawing.Point(219, 181);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(336, 24);
            this.txtEmail.TabIndex = 58;
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmail_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.label2.Location = new System.Drawing.Point(161, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 57;
            this.label2.Text = "EMAIL:";
            // 
            // radCNPJ
            // 
            this.radCNPJ.AutoSize = true;
            this.radCNPJ.BackColor = System.Drawing.Color.Transparent;
            this.radCNPJ.Enabled = false;
            this.radCNPJ.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCNPJ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.radCNPJ.Location = new System.Drawing.Point(164, 111);
            this.radCNPJ.Name = "radCNPJ";
            this.radCNPJ.Size = new System.Drawing.Size(63, 21);
            this.radCNPJ.TabIndex = 60;
            this.radCNPJ.Text = "CNPJ";
            this.radCNPJ.UseVisualStyleBackColor = false;
            this.radCNPJ.CheckedChanged += new System.EventHandler(this.radCNPJ_CheckedChanged);
            // 
            // radCPF
            // 
            this.radCPF.AutoSize = true;
            this.radCPF.BackColor = System.Drawing.Color.Transparent;
            this.radCPF.Enabled = false;
            this.radCPF.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCPF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.radCPF.Location = new System.Drawing.Point(164, 134);
            this.radCPF.Name = "radCPF";
            this.radCPF.Size = new System.Drawing.Size(54, 21);
            this.radCPF.TabIndex = 61;
            this.radCPF.Text = "CPF";
            this.radCPF.UseVisualStyleBackColor = false;
            this.radCPF.CheckedChanged += new System.EventHandler(this.radCPF_CheckedChanged);
            // 
            // lblHorarioAtendimento
            // 
            this.lblHorarioAtendimento.AutoSize = true;
            this.lblHorarioAtendimento.BackColor = System.Drawing.Color.Transparent;
            this.lblHorarioAtendimento.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorarioAtendimento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblHorarioAtendimento.Location = new System.Drawing.Point(676, 226);
            this.lblHorarioAtendimento.Name = "lblHorarioAtendimento";
            this.lblHorarioAtendimento.Size = new System.Drawing.Size(193, 16);
            this.lblHorarioAtendimento.TabIndex = 62;
            this.lblHorarioAtendimento.Text = "HORÁRIO DE ATENDIMENTO:";
            // 
            // cmbHorarioAtendimento
            // 
            this.cmbHorarioAtendimento.Enabled = false;
            this.cmbHorarioAtendimento.FormattingEnabled = true;
            this.cmbHorarioAtendimento.Items.AddRange(new object[] {
            "4:00",
            "5:00",
            "6:00",
            "7:00",
            "8:00",
            "9:00",
            "10:00",
            "11:00",
            "12:00"});
            this.cmbHorarioAtendimento.Location = new System.Drawing.Point(679, 245);
            this.cmbHorarioAtendimento.Name = "cmbHorarioAtendimento";
            this.cmbHorarioAtendimento.Size = new System.Drawing.Size(190, 21);
            this.cmbHorarioAtendimento.TabIndex = 63;
            this.cmbHorarioAtendimento.SelectedIndexChanged += new System.EventHandler(this.cmbHorarioAtendimento_SelectedIndexChanged);
            // 
            // frmCadEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DesktopK.Properties.Resources.empresa;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.CadFoneEmpresa);
            this.Controls.Add(this.cmbHorarioAtendimento);
            this.Controls.Add(this.lblHorarioAtendimento);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.radCPF);
            this.Controls.Add(this.radCNPJ);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCnpjCpf);
            this.Controls.Add(this.lblAdicionarEmpresa);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.TelefoneEmpresa);
            this.Controls.Add(this.txtDataCadastro);
            this.Controls.Add(this.lblDataCadastro);
            this.Controls.Add(this.txtRazaoSocial);
            this.Controls.Add(this.lblRazaoSocial);
            this.Controls.Add(this.txtNomeEmpresa);
            this.Controls.Add(this.lblNomeFantasiaEmpresa);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnFechar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCadEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadEmpresa";
            this.Load += new System.EventHandler(this.frmCadEmpresa_Load);
            this.TelefoneEmpresa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoneEmpresa)).EndInit();
            this.CadFoneEmpresa.ResumeLayout(false);
            this.CadFoneEmpresa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Panel TelefoneEmpresa;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnAdicionarTelefone;
        private System.Windows.Forms.DataGridView dgvFoneEmpresa;
        private System.Windows.Forms.MaskedTextBox txtDataCadastro;
        private System.Windows.Forms.Label lblDataCadastro;
        private System.Windows.Forms.TextBox txtRazaoSocial;
        private System.Windows.Forms.Label lblRazaoSocial;
        private System.Windows.Forms.TextBox txtNomeEmpresa;
        private System.Windows.Forms.Label lblNomeFantasiaEmpresa;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblAdicionarEmpresa;
        private System.Windows.Forms.MaskedTextBox txtCnpjCpf;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radCNPJ;
        private System.Windows.Forms.RadioButton radCPF;
        private System.Windows.Forms.Label lblHorarioAtendimento;
        private System.Windows.Forms.ComboBox cmbHorarioAtendimento;
        private System.Windows.Forms.Panel CadFoneEmpresa;
        private System.Windows.Forms.Button btnFecharFone;
        private System.Windows.Forms.Button btnSalvarFone;
        private System.Windows.Forms.ComboBox cmbDescFone;
        private System.Windows.Forms.ComboBox cmbTipFone;
        private System.Windows.Forms.Label lblDescFone;
        private System.Windows.Forms.Label lblNumFone;
        private System.Windows.Forms.Label lblTipFone;
        private System.Windows.Forms.MaskedTextBox txtNumFone;
        private System.Windows.Forms.TextBox txtCodFone;
        private System.Windows.Forms.Label lblCodFone;
        private System.Windows.Forms.Label lblAdicionarFoneCliente;
    }
}