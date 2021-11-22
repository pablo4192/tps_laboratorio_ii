
namespace FrmCenso
{
    partial class FrmMenores30Desocupados
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
            this.SuspendLayout();
            // 
            // lblInforme
            // 
            this.lblInforme.Location = new System.Drawing.Point(12, 64);
            // 
            // lblSubTitulo
            // 
            this.lblSubTitulo.Location = new System.Drawing.Point(12, 123);
            // 
            // btnExportarCsv
            // 
            this.btnExportarCsv.Location = new System.Drawing.Point(841, 105);
            this.btnExportarCsv.Click += new System.EventHandler(this.btnExportarCsv_Click);
            // 
            // txtNombreArchivo
            // 
            this.txtNombreArchivo.Location = new System.Drawing.Point(640, 107);
            // 
            // lblNombreArchivo
            // 
            this.lblNombreArchivo.Location = new System.Drawing.Point(518, 114);
            // 
            // lblSoloLetras
            // 
           
            // 
            // FrmMenores30Desocupados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 446);
            this.Name = "FrmMenores30Desocupados";
            this.Text = "FrmMenores30Desocupados";
            this.Load += new System.EventHandler(this.FrmMenores30Desocupados_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}