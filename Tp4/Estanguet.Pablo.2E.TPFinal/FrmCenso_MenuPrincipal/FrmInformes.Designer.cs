
namespace FrmCenso
{
    partial class FrmInformes
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
            this.dgvListadoCenso = new System.Windows.Forms.DataGridView();
            this.lblInformes = new System.Windows.Forms.Label();
            this.btnExportarCsv = new System.Windows.Forms.Button();
            this.btnExportarJson = new System.Windows.Forms.Button();
            this.cmbActividad = new System.Windows.Forms.ComboBox();
            this.lblActividad = new System.Windows.Forms.Label();
            this.lblFiltros = new System.Windows.Forms.Label();
            this.btnFiltro_Menores30Deso = new System.Windows.Forms.Button();
            this.btnFiltro_CarreraMasEstudiada = new System.Windows.Forms.Button();
            this.btnFiltro_TrabajoNoRegistrado = new System.Windows.Forms.Button();
            this.btnFiltro_LocalidadMasDesoc = new System.Windows.Forms.Button();
            this.btnFiltro_SexoMasDesoc = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.txtNombreArchivo = new System.Windows.Forms.TextBox();
            this.lblNombreArchivo = new System.Windows.Forms.Label();
            this.lblExportarListaPersonas = new System.Windows.Forms.Label();
            this.cmbCriterio = new System.Windows.Forms.ComboBox();
            this.lblOrdenarLista = new System.Windows.Forms.Label();
            this.lblAvisoOrdenar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoCenso)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListadoCenso
            // 
            this.dgvListadoCenso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoCenso.Location = new System.Drawing.Point(12, 106);
            this.dgvListadoCenso.Name = "dgvListadoCenso";
            this.dgvListadoCenso.ReadOnly = true;
            this.dgvListadoCenso.RowHeadersWidth = 51;
            this.dgvListadoCenso.RowTemplate.Height = 29;
            this.dgvListadoCenso.Size = new System.Drawing.Size(956, 285);
            this.dgvListadoCenso.TabIndex = 0;
            // 
            // lblInformes
            // 
            this.lblInformes.AutoSize = true;
            this.lblInformes.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInformes.Location = new System.Drawing.Point(371, 9);
            this.lblInformes.Name = "lblInformes";
            this.lblInformes.Size = new System.Drawing.Size(255, 33);
            this.lblInformes.TabIndex = 1;
            this.lblInformes.Text = "Seccion Informes";
            // 
            // btnExportarCsv
            // 
            this.btnExportarCsv.Location = new System.Drawing.Point(627, 444);
            this.btnExportarCsv.Name = "btnExportarCsv";
            this.btnExportarCsv.Size = new System.Drawing.Size(165, 29);
            this.btnExportarCsv.TabIndex = 5;
            this.btnExportarCsv.Text = "Exportar info a Csv";
            this.btnExportarCsv.UseVisualStyleBackColor = true;
            this.btnExportarCsv.Click += new System.EventHandler(this.btnExportarCsv_Click);
            // 
            // btnExportarJson
            // 
            this.btnExportarJson.Location = new System.Drawing.Point(798, 444);
            this.btnExportarJson.Name = "btnExportarJson";
            this.btnExportarJson.Size = new System.Drawing.Size(165, 29);
            this.btnExportarJson.TabIndex = 6;
            this.btnExportarJson.Text = "Exportar info a Json";
            this.btnExportarJson.UseVisualStyleBackColor = true;
            this.btnExportarJson.Click += new System.EventHandler(this.btnExportarJson_Click);
            // 
            // cmbActividad
            // 
            this.cmbActividad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbActividad.FormattingEnabled = true;
            this.cmbActividad.Location = new System.Drawing.Point(89, 72);
            this.cmbActividad.Name = "cmbActividad";
            this.cmbActividad.Size = new System.Drawing.Size(151, 28);
            this.cmbActividad.TabIndex = 8;
            this.cmbActividad.SelectedIndexChanged += new System.EventHandler(this.cmbActividad_SelectedIndexChanged);
            // 
            // lblActividad
            // 
            this.lblActividad.AutoSize = true;
            this.lblActividad.Location = new System.Drawing.Point(11, 80);
            this.lblActividad.Name = "lblActividad";
            this.lblActividad.Size = new System.Drawing.Size(72, 20);
            this.lblActividad.TabIndex = 9;
            this.lblActividad.Text = "Actividad";
            // 
            // lblFiltros
            // 
            this.lblFiltros.AutoSize = true;
            this.lblFiltros.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFiltros.Location = new System.Drawing.Point(12, 493);
            this.lblFiltros.Name = "lblFiltros";
            this.lblFiltros.Size = new System.Drawing.Size(433, 23);
            this.lblFiltros.TabIndex = 10;
            this.lblFiltros.Text = "Seleccione si desea filtar la informacion de los registros ";
            // 
            // btnFiltro_Menores30Deso
            // 
            this.btnFiltro_Menores30Deso.Location = new System.Drawing.Point(195, 529);
            this.btnFiltro_Menores30Deso.Name = "btnFiltro_Menores30Deso";
            this.btnFiltro_Menores30Deso.Size = new System.Drawing.Size(191, 62);
            this.btnFiltro_Menores30Deso.TabIndex = 11;
            this.btnFiltro_Menores30Deso.Text = "Menores de 30 años desocupados";
            this.btnFiltro_Menores30Deso.UseVisualStyleBackColor = true;
            this.btnFiltro_Menores30Deso.Click += new System.EventHandler(this.btnFiltro_Menores30Deso_Click);
            // 
            // btnFiltro_CarreraMasEstudiada
            // 
            this.btnFiltro_CarreraMasEstudiada.Location = new System.Drawing.Point(780, 529);
            this.btnFiltro_CarreraMasEstudiada.Name = "btnFiltro_CarreraMasEstudiada";
            this.btnFiltro_CarreraMasEstudiada.Size = new System.Drawing.Size(188, 62);
            this.btnFiltro_CarreraMasEstudiada.TabIndex = 12;
            this.btnFiltro_CarreraMasEstudiada.Text = "Carrera mas estudiada";
            this.btnFiltro_CarreraMasEstudiada.UseVisualStyleBackColor = true;
            this.btnFiltro_CarreraMasEstudiada.Click += new System.EventHandler(this.btnFiltro_CarreraMasEstudiada_Click);
            // 
            // btnFiltro_TrabajoNoRegistrado
            // 
            this.btnFiltro_TrabajoNoRegistrado.Location = new System.Drawing.Point(583, 529);
            this.btnFiltro_TrabajoNoRegistrado.Name = "btnFiltro_TrabajoNoRegistrado";
            this.btnFiltro_TrabajoNoRegistrado.Size = new System.Drawing.Size(191, 62);
            this.btnFiltro_TrabajoNoRegistrado.TabIndex = 13;
            this.btnFiltro_TrabajoNoRegistrado.Text = "Cantidad de trabajadores no registrados";
            this.btnFiltro_TrabajoNoRegistrado.UseVisualStyleBackColor = true;
            this.btnFiltro_TrabajoNoRegistrado.Click += new System.EventHandler(this.btnFiltro_TrabajoNoRegistrado_Click);
            // 
            // btnFiltro_LocalidadMasDesoc
            // 
            this.btnFiltro_LocalidadMasDesoc.Location = new System.Drawing.Point(11, 529);
            this.btnFiltro_LocalidadMasDesoc.Name = "btnFiltro_LocalidadMasDesoc";
            this.btnFiltro_LocalidadMasDesoc.Size = new System.Drawing.Size(178, 62);
            this.btnFiltro_LocalidadMasDesoc.TabIndex = 14;
            this.btnFiltro_LocalidadMasDesoc.Text = "Localidad con mayor indice de desocupacion";
            this.btnFiltro_LocalidadMasDesoc.UseVisualStyleBackColor = true;
            this.btnFiltro_LocalidadMasDesoc.Click += new System.EventHandler(this.btnFiltro_LocalidadMasDesoc_Click);
            // 
            // btnFiltro_SexoMasDesoc
            // 
            this.btnFiltro_SexoMasDesoc.Location = new System.Drawing.Point(392, 529);
            this.btnFiltro_SexoMasDesoc.Name = "btnFiltro_SexoMasDesoc";
            this.btnFiltro_SexoMasDesoc.Size = new System.Drawing.Size(185, 62);
            this.btnFiltro_SexoMasDesoc.TabIndex = 15;
            this.btnFiltro_SexoMasDesoc.Text = "Sexo con mayor indice de desocupacion";
            this.btnFiltro_SexoMasDesoc.UseVisualStyleBackColor = true;
            this.btnFiltro_SexoMasDesoc.Click += new System.EventHandler(this.btnFiltro_SexoMasDesoc_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(871, 9);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(94, 29);
            this.btnAtras.TabIndex = 16;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // txtNombreArchivo
            // 
            this.txtNombreArchivo.Location = new System.Drawing.Point(421, 444);
            this.txtNombreArchivo.Name = "txtNombreArchivo";
            this.txtNombreArchivo.PlaceholderText = "Asignele nombre al archivo";
            this.txtNombreArchivo.Size = new System.Drawing.Size(200, 27);
            this.txtNombreArchivo.TabIndex = 17;
            // 
            // lblNombreArchivo
            // 
            this.lblNombreArchivo.AutoSize = true;
            this.lblNombreArchivo.Location = new System.Drawing.Point(299, 448);
            this.lblNombreArchivo.Name = "lblNombreArchivo";
            this.lblNombreArchivo.Size = new System.Drawing.Size(116, 20);
            this.lblNombreArchivo.TabIndex = 18;
            this.lblNombreArchivo.Text = "Nombre archivo";
            // 
            // lblExportarListaPersonas
            // 
            this.lblExportarListaPersonas.AutoSize = true;
            this.lblExportarListaPersonas.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblExportarListaPersonas.Location = new System.Drawing.Point(11, 404);
            this.lblExportarListaPersonas.Name = "lblExportarListaPersonas";
            this.lblExportarListaPersonas.Size = new System.Drawing.Size(300, 23);
            this.lblExportarListaPersonas.TabIndex = 20;
            this.lblExportarListaPersonas.Text = "Exportar listado de personas censadas";
            // 
            // cmbCriterio
            // 
            this.cmbCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCriterio.FormattingEnabled = true;
            this.cmbCriterio.Items.AddRange(new object[] {
            "Ascendente",
            "Descendente"});
            this.cmbCriterio.Location = new System.Drawing.Point(817, 72);
            this.cmbCriterio.Name = "cmbCriterio";
            this.cmbCriterio.Size = new System.Drawing.Size(151, 28);
            this.cmbCriterio.TabIndex = 21;
            this.cmbCriterio.SelectedIndexChanged += new System.EventHandler(this.cmbCriterio_SelectedIndexChanged);
            // 
            // lblOrdenarLista
            // 
            this.lblOrdenarLista.AutoSize = true;
            this.lblOrdenarLista.Location = new System.Drawing.Point(649, 80);
            this.lblOrdenarLista.Name = "lblOrdenarLista";
            this.lblOrdenarLista.Size = new System.Drawing.Size(162, 20);
            this.lblOrdenarLista.TabIndex = 22;
            this.lblOrdenarLista.Text = "Ordenar lista por edad:";
            // 
            // lblAvisoOrdenar
            // 
            this.lblAvisoOrdenar.AutoSize = true;
            this.lblAvisoOrdenar.ForeColor = System.Drawing.Color.Green;
            this.lblAvisoOrdenar.Location = new System.Drawing.Point(650, 51);
            this.lblAvisoOrdenar.Name = "lblAvisoOrdenar";
            this.lblAvisoOrdenar.Size = new System.Drawing.Size(274, 20);
            this.lblAvisoOrdenar.TabIndex = 23;
            this.lblAvisoOrdenar.Text = "Ordenando lista espere unos segundos...";
            this.lblAvisoOrdenar.Visible = false;
            // 
            // FrmInformes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 603);
            this.Controls.Add(this.lblAvisoOrdenar);
            this.Controls.Add(this.lblOrdenarLista);
            this.Controls.Add(this.cmbCriterio);
            this.Controls.Add(this.lblExportarListaPersonas);
            this.Controls.Add(this.lblNombreArchivo);
            this.Controls.Add(this.txtNombreArchivo);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnFiltro_SexoMasDesoc);
            this.Controls.Add(this.btnFiltro_LocalidadMasDesoc);
            this.Controls.Add(this.btnFiltro_TrabajoNoRegistrado);
            this.Controls.Add(this.btnFiltro_CarreraMasEstudiada);
            this.Controls.Add(this.btnFiltro_Menores30Deso);
            this.Controls.Add(this.lblFiltros);
            this.Controls.Add(this.lblActividad);
            this.Controls.Add(this.cmbActividad);
            this.Controls.Add(this.btnExportarJson);
            this.Controls.Add(this.btnExportarCsv);
            this.Controls.Add(this.lblInformes);
            this.Controls.Add(this.dgvListadoCenso);
            this.Name = "FrmInformes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmInformes";
            this.Load += new System.EventHandler(this.FrmInformes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoCenso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListadoCenso;
        private System.Windows.Forms.Label lblInformes;
        private System.Windows.Forms.Button btnExportarCsv;
        private System.Windows.Forms.Button btnExportarJson;
        private System.Windows.Forms.ComboBox cmbActividad;
        private System.Windows.Forms.Label lblActividad;
        private System.Windows.Forms.Label lblFiltros;
        private System.Windows.Forms.Button btnFiltro_Menores30Deso;
        private System.Windows.Forms.Button btnFiltro_CarreraMasEstudiada;
        private System.Windows.Forms.Button btnFiltro_TrabajoNoRegistrado;
        private System.Windows.Forms.Button btnFiltro_LocalidadMasDesoc;
        private System.Windows.Forms.Button btnFiltro_SexoMasDesoc;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.TextBox txtNombreArchivo;
        private System.Windows.Forms.Label lblNombreArchivo;
        private System.Windows.Forms.Label lblExportarListaPersonas;
        private System.Windows.Forms.ComboBox cmbCriterio;
        private System.Windows.Forms.Label lblOrdenarLista;
        private System.Windows.Forms.Label lblAvisoOrdenar;
    }
}