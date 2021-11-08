
namespace FrmCenso
{
    partial class FrmCarreraMasEstudiada
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
            // btnExportarCsv
            // 
            this.btnExportarCsv.Click += new System.EventHandler(this.btnExportarCsv_Click);
            // 
            // FrmCarreraMasEstudiada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 447);
            this.Name = "FrmCarreraMasEstudiada";
            this.Text = "FrmCarreraMasEstudiada";
            this.Load += new System.EventHandler(this.FrmCarreraMasEstudiada_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}