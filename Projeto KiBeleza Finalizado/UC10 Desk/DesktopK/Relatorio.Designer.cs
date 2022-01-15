
namespace DesktopK
{
    partial class frmRelatorio
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource7 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new DesktopK.DataSet1();
            this.btnTodasHoje = new System.Windows.Forms.Button();
            this.btnAprovado = new System.Windows.Forms.Button();
            this.btnReprovado = new System.Windows.Forms.Button();
            this.btnGeral = new System.Windows.Forms.Button();
            this.btnAguardando = new System.Windows.Forms.Button();
            this.btnFinalizado = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnCancelado = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnTodasHoje
            // 
            this.btnTodasHoje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.btnTodasHoje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTodasHoje.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTodasHoje.ForeColor = System.Drawing.Color.White;
            this.btnTodasHoje.Location = new System.Drawing.Point(367, 347);
            this.btnTodasHoje.Name = "btnTodasHoje";
            this.btnTodasHoje.Size = new System.Drawing.Size(119, 36);
            this.btnTodasHoje.TabIndex = 23;
            this.btnTodasHoje.Text = "TODAS HOJE";
            this.btnTodasHoje.UseVisualStyleBackColor = false;
            this.btnTodasHoje.Click += new System.EventHandler(this.btnTodasHoje_Click);
            // 
            // btnAprovado
            // 
            this.btnAprovado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.btnAprovado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAprovado.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAprovado.ForeColor = System.Drawing.Color.White;
            this.btnAprovado.Location = new System.Drawing.Point(575, 346);
            this.btnAprovado.Name = "btnAprovado";
            this.btnAprovado.Size = new System.Drawing.Size(119, 36);
            this.btnAprovado.TabIndex = 24;
            this.btnAprovado.Text = "APROVADO";
            this.btnAprovado.UseVisualStyleBackColor = false;
            this.btnAprovado.Click += new System.EventHandler(this.btnAprovado_Click);
            // 
            // btnReprovado
            // 
            this.btnReprovado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.btnReprovado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReprovado.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReprovado.ForeColor = System.Drawing.Color.White;
            this.btnReprovado.Location = new System.Drawing.Point(769, 346);
            this.btnReprovado.Name = "btnReprovado";
            this.btnReprovado.Size = new System.Drawing.Size(119, 36);
            this.btnReprovado.TabIndex = 25;
            this.btnReprovado.Text = "REPROVADO";
            this.btnReprovado.UseVisualStyleBackColor = false;
            this.btnReprovado.Click += new System.EventHandler(this.btnReprovado_Click);
            // 
            // btnGeral
            // 
            this.btnGeral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.btnGeral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeral.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeral.ForeColor = System.Drawing.Color.White;
            this.btnGeral.Location = new System.Drawing.Point(161, 347);
            this.btnGeral.Name = "btnGeral";
            this.btnGeral.Size = new System.Drawing.Size(119, 36);
            this.btnGeral.TabIndex = 26;
            this.btnGeral.Text = "GERAL";
            this.btnGeral.UseVisualStyleBackColor = false;
            this.btnGeral.Click += new System.EventHandler(this.btnGeral_Click);
            // 
            // btnAguardando
            // 
            this.btnAguardando.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.btnAguardando.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAguardando.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAguardando.ForeColor = System.Drawing.Color.White;
            this.btnAguardando.Location = new System.Drawing.Point(161, 402);
            this.btnAguardando.Name = "btnAguardando";
            this.btnAguardando.Size = new System.Drawing.Size(119, 36);
            this.btnAguardando.TabIndex = 27;
            this.btnAguardando.Text = "AGUARDANDO";
            this.btnAguardando.UseVisualStyleBackColor = false;
            this.btnAguardando.Click += new System.EventHandler(this.btnAguardando_Click);
            // 
            // btnFinalizado
            // 
            this.btnFinalizado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.btnFinalizado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizado.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizado.ForeColor = System.Drawing.Color.White;
            this.btnFinalizado.Location = new System.Drawing.Point(367, 402);
            this.btnFinalizado.Name = "btnFinalizado";
            this.btnFinalizado.Size = new System.Drawing.Size(119, 36);
            this.btnFinalizado.TabIndex = 28;
            this.btnFinalizado.Text = "FINALIZADO";
            this.btnFinalizado.UseVisualStyleBackColor = false;
            this.btnFinalizado.Click += new System.EventHandler(this.btnFinalizado_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Location = new System.Drawing.Point(769, 402);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(119, 36);
            this.btnFechar.TabIndex = 29;
            this.btnFechar.Text = "FECHAR";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnCancelado
            // 
            this.btnCancelado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.btnCancelado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelado.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelado.ForeColor = System.Drawing.Color.White;
            this.btnCancelado.Location = new System.Drawing.Point(575, 402);
            this.btnCancelado.Name = "btnCancelado";
            this.btnCancelado.Size = new System.Drawing.Size(119, 36);
            this.btnCancelado.TabIndex = 30;
            this.btnCancelado.Text = "CANCELADO";
            this.btnCancelado.UseVisualStyleBackColor = false;
            this.btnCancelado.Click += new System.EventHandler(this.btnCancelado_Click);
            // 
            // reportViewer1
            // 
            reportDataSource7.Name = "DataSet1";
            reportDataSource7.Value = this.DataTable1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource7);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DesktopK.reserva.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(161, 9);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(727, 332);
            this.reportViewer1.TabIndex = 31;
            // 
            // frmRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DesktopK.Properties.Resources.reserva;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnCancelado);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnFinalizado);
            this.Controls.Add(this.btnAguardando);
            this.Controls.Add(this.btnGeral);
            this.Controls.Add(this.btnReprovado);
            this.Controls.Add(this.btnAprovado);
            this.Controls.Add(this.btnTodasHoje);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRelatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatorio";
            this.Load += new System.EventHandler(this.frmRelatorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTodasHoje;
        private System.Windows.Forms.Button btnAprovado;
        private System.Windows.Forms.Button btnReprovado;
        private System.Windows.Forms.Button btnGeral;
        private System.Windows.Forms.Button btnAguardando;
        private System.Windows.Forms.Button btnFinalizado;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnCancelado;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private DataSet1 DataSet1;
    }
}