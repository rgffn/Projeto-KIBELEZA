
namespace DesktopK
{
    partial class frmEmpresa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvEmpresa = new System.Windows.Forms.DataGridView();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.txtBuscarEmpresa = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblBuscarEmpresa = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpresa)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmpresa
            // 
            this.dgvEmpresa.AllowUserToAddRows = false;
            this.dgvEmpresa.AllowUserToDeleteRows = false;
            this.dgvEmpresa.AllowUserToResizeColumns = false;
            this.dgvEmpresa.AllowUserToResizeRows = false;
            this.dgvEmpresa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmpresa.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.dgvEmpresa.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvEmpresa.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmpresa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(52)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmpresa.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEmpresa.EnableHeadersVisualStyles = false;
            this.dgvEmpresa.Location = new System.Drawing.Point(160, 46);
            this.dgvEmpresa.MultiSelect = false;
            this.dgvEmpresa.Name = "dgvEmpresa";
            this.dgvEmpresa.ReadOnly = true;
            this.dgvEmpresa.RowHeadersVisible = false;
            this.dgvEmpresa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmpresa.Size = new System.Drawing.Size(728, 351);
            this.dgvEmpresa.TabIndex = 17;
            this.dgvEmpresa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpresa_CellClick);
            this.dgvEmpresa.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvEmpresa_ColumnHeaderMouseClick);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(582, 403);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(106, 36);
            this.btnExcluir.TabIndex = 16;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Location = new System.Drawing.Point(782, 403);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(106, 36);
            this.btnFechar.TabIndex = 15;
            this.btnFechar.Text = "FECHAR";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ForeColor = System.Drawing.Color.White;
            this.btnAlterar.Location = new System.Drawing.Point(365, 403);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(106, 36);
            this.btnAlterar.TabIndex = 14;
            this.btnAlterar.Text = "ALTERAR";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.ForeColor = System.Drawing.Color.White;
            this.btnAdicionar.Location = new System.Drawing.Point(160, 403);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(106, 36);
            this.btnAdicionar.TabIndex = 13;
            this.btnAdicionar.Text = "ADICIONAR";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "TODOS",
            "ATIVO",
            "INATIVO"});
            this.cmbStatus.Location = new System.Drawing.Point(731, 14);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(143, 25);
            this.cmbStatus.TabIndex = 12;
            this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.cmbStatus_SelectedIndexChanged);
            // 
            // txtBuscarEmpresa
            // 
            this.txtBuscarEmpresa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBuscarEmpresa.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarEmpresa.Location = new System.Drawing.Point(313, 15);
            this.txtBuscarEmpresa.Name = "txtBuscarEmpresa";
            this.txtBuscarEmpresa.Size = new System.Drawing.Size(333, 25);
            this.txtBuscarEmpresa.TabIndex = 11;
            this.txtBuscarEmpresa.TextChanged += new System.EventHandler(this.txtBuscarEmpresa_TextChanged);
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(665, 10);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(223, 33);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.Text = "Status:";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBuscarEmpresa
            // 
            this.lblBuscarEmpresa.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarEmpresa.Location = new System.Drawing.Point(160, 10);
            this.lblBuscarEmpresa.Name = "lblBuscarEmpresa";
            this.lblBuscarEmpresa.Size = new System.Drawing.Size(499, 33);
            this.lblBuscarEmpresa.TabIndex = 9;
            this.lblBuscarEmpresa.Text = "Buscar Empresa:";
            this.lblBuscarEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DesktopK.Properties.Resources.empresa;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.dgvEmpresa);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.txtBuscarEmpresa);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblBuscarEmpresa);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empresa";
            this.Load += new System.EventHandler(this.frmEmpresa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpresa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmpresa;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.TextBox txtBuscarEmpresa;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblBuscarEmpresa;
    }
}