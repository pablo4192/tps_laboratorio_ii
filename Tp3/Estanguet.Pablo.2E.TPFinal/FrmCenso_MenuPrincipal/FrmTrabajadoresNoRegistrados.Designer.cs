
namespace FrmCenso
{
    partial class FrmTrabajadoresNoRegistrados
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
            this.lblInforme.Location = new System.Drawing.Point(12, 63);
            // 
            // btnExportarCsv
            // 
            this.btnExportarCsv.Click += new System.EventHandler(this.btnExportarCsv_Click);
            // 
            // lblSoloLetras
            // 
            this.lblSoloLetras.Location = new System.Drawing.Point(518, 63);
            // 
            // FrmTrabajadoresNoRegistrados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 450);
            this.Name = "FrmTrabajadoresNoRegistrados";
            this.Text = "FrmTrabajadoresNoRegistrados";
            this.Load += new System.EventHandler(this.FrmTrabajadoresNoRegistrados_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}