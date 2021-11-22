
namespace FrmCenso
{
    partial class FrmMenuPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnIngresarDatos = new System.Windows.Forms.Button();
            this.btnInformes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(307, 25);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(175, 36);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Censo 2021";
            // 
            // btnIngresarDatos
            // 
            this.btnIngresarDatos.Location = new System.Drawing.Point(411, 75);
            this.btnIngresarDatos.Name = "btnIngresarDatos";
            this.btnIngresarDatos.Size = new System.Drawing.Size(215, 50);
            this.btnIngresarDatos.TabIndex = 1;
            this.btnIngresarDatos.Text = "Ingresar datos";
            this.btnIngresarDatos.UseVisualStyleBackColor = true;
            this.btnIngresarDatos.Click += new System.EventHandler(this.btnIngresarDatos_Click);
            // 
            // btnInformes
            // 
            this.btnInformes.Location = new System.Drawing.Point(166, 75);
            this.btnInformes.Name = "btnInformes";
            this.btnInformes.Size = new System.Drawing.Size(215, 50);
            this.btnInformes.TabIndex = 2;
            this.btnInformes.Text = "Informes";
            this.btnInformes.UseVisualStyleBackColor = true;
            this.btnInformes.Click += new System.EventHandler(this.btnInformes_Click);
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 172);
            this.Controls.Add(this.btnInformes);
            this.Controls.Add(this.btnIngresarDatos);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FrmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnIngresarDatos;
        private System.Windows.Forms.Button btnInformes;
    }
}

