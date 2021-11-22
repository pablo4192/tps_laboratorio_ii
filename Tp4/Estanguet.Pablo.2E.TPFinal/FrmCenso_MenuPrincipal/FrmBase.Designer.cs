
namespace FrmCenso
{
    partial class FrmBase
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
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblInforme = new System.Windows.Forms.Label();
            this.lblSubTitulo = new System.Windows.Forms.Label();
            this.btnExportarCsv = new System.Windows.Forms.Button();
            this.txtNombreArchivo = new System.Windows.Forms.TextBox();
            this.lblNombreArchivo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLista
            // 
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Location = new System.Drawing.Point(12, 147);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.ReadOnly = true;
            this.dgvLista.RowHeadersWidth = 51;
            this.dgvLista.RowTemplate.Height = 29;
            this.dgvLista.Size = new System.Drawing.Size(995, 291);
            this.dgvLista.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(99, 32);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "label1";
            // 
            // lblInforme
            // 
            this.lblInforme.AutoSize = true;
            this.lblInforme.Location = new System.Drawing.Point(12, 67);
            this.lblInforme.Name = "lblInforme";
            this.lblInforme.Size = new System.Drawing.Size(50, 20);
            this.lblInforme.TabIndex = 2;
            this.lblInforme.Text = "label1";
            // 
            // lblSubTitulo
            // 
            this.lblSubTitulo.AutoSize = true;
            this.lblSubTitulo.Location = new System.Drawing.Point(12, 121);
            this.lblSubTitulo.Name = "lblSubTitulo";
            this.lblSubTitulo.Size = new System.Drawing.Size(50, 20);
            this.lblSubTitulo.TabIndex = 3;
            this.lblSubTitulo.Text = "label1";
            // 
            // btnExportarCsv
            // 
            this.btnExportarCsv.Location = new System.Drawing.Point(870, 112);
            this.btnExportarCsv.Name = "btnExportarCsv";
            this.btnExportarCsv.Size = new System.Drawing.Size(137, 29);
            this.btnExportarCsv.TabIndex = 4;
            this.btnExportarCsv.Text = "Exportar a Csv";
            this.btnExportarCsv.UseVisualStyleBackColor = true;
            // 
            // txtNombreArchivo
            // 
            this.txtNombreArchivo.Location = new System.Drawing.Point(669, 114);
            this.txtNombreArchivo.Name = "txtNombreArchivo";
            this.txtNombreArchivo.PlaceholderText = "Asignele nombre al archivo";
            this.txtNombreArchivo.Size = new System.Drawing.Size(195, 27);
            this.txtNombreArchivo.TabIndex = 5;
            // 
            // lblNombreArchivo
            // 
            this.lblNombreArchivo.AutoSize = true;
            this.lblNombreArchivo.Location = new System.Drawing.Point(547, 121);
            this.lblNombreArchivo.Name = "lblNombreArchivo";
            this.lblNombreArchivo.Size = new System.Drawing.Size(116, 20);
            this.lblNombreArchivo.TabIndex = 6;
            this.lblNombreArchivo.Text = "Nombre archivo";
            // 
            // FrmBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 449);
            this.Controls.Add(this.lblNombreArchivo);
            this.Controls.Add(this.txtNombreArchivo);
            this.Controls.Add(this.btnExportarCsv);
            this.Controls.Add(this.lblSubTitulo);
            this.Controls.Add(this.lblInforme);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dgvLista);
            this.Name = "FrmBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBase";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvLista;
        public System.Windows.Forms.Label lblTitulo;
        public System.Windows.Forms.Label lblInforme;
        public System.Windows.Forms.Label lblSubTitulo;
        public System.Windows.Forms.Button btnExportarCsv;
        public System.Windows.Forms.TextBox txtNombreArchivo;
        public System.Windows.Forms.Label lblNombreArchivo;
    }
}