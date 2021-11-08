
namespace FrmCenso
{
    partial class FrmAlta
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
            this.cmbActividad = new System.Windows.Forms.ComboBox();
            this.lblActividad = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.lblEstadoCivil = new System.Windows.Forms.Label();
            this.lblCantidadHijos = new System.Windows.Forms.Label();
            this.lblEstudioCompleto = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtLocalidad = new System.Windows.Forms.TextBox();
            this.cmbEstadoCivil = new System.Windows.Forms.ComboBox();
            this.txtCantidadHijos = new System.Windows.Forms.TextBox();
            this.cmbEstudioCompleto = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.chkTrabajoRegistrado = new System.Windows.Forms.CheckBox();
            this.chkRelacionDependencia = new System.Windows.Forms.CheckBox();
            this.txtHorasTrabajadas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEstablecimiento = new System.Windows.Forms.Label();
            this.lblNivelCarrera = new System.Windows.Forms.Label();
            this.lblNombreTitulo = new System.Windows.Forms.Label();
            this.txtEstablecimiento = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblAnioJubilacion = new System.Windows.Forms.Label();
            this.chkSigueTrabajando = new System.Windows.Forms.CheckBox();
            this.chkAyudaEstatal = new System.Windows.Forms.CheckBox();
            this.cmbAnioJubilacion = new System.Windows.Forms.ComboBox();
            this.cmbNivelCarrera = new System.Windows.Forms.ComboBox();
            this.dtpFechaUltimoTrabajo = new System.Windows.Forms.DateTimePicker();
            this.lblUltimoTrabajo = new System.Windows.Forms.Label();
            this.lblAltaExitosa = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbActividad
            // 
            this.cmbActividad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbActividad.FormattingEnabled = true;
            this.cmbActividad.Location = new System.Drawing.Point(444, 11);
            this.cmbActividad.Name = "cmbActividad";
            this.cmbActividad.Size = new System.Drawing.Size(151, 28);
            this.cmbActividad.TabIndex = 0;
            this.cmbActividad.SelectedIndexChanged += new System.EventHandler(this.cmbActividad_SelectedIndexChanged);
            // 
            // lblActividad
            // 
            this.lblActividad.AutoSize = true;
            this.lblActividad.Location = new System.Drawing.Point(170, 19);
            this.lblActividad.Name = "lblActividad";
            this.lblActividad.Size = new System.Drawing.Size(268, 20);
            this.lblActividad.TabIndex = 1;
            this.lblActividad.Text = "Escoja actividad de la persona censada";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(14, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(150, 32);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Menu Alta";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 68);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(64, 20);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(12, 114);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(66, 20);
            this.lblApellido.TabIndex = 4;
            this.lblApellido.Text = "Apellido";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(12, 157);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(43, 20);
            this.lblEdad.TabIndex = 5;
            this.lblEdad.Text = "Edad";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(14, 201);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(41, 20);
            this.lblSexo.TabIndex = 6;
            this.lblSexo.Text = "Sexo";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(14, 244);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(32, 20);
            this.lblDni.TabIndex = 7;
            this.lblDni.Text = "Dni";
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Location = new System.Drawing.Point(14, 287);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(74, 20);
            this.lblLocalidad.TabIndex = 8;
            this.lblLocalidad.Text = "Localidad";
            // 
            // lblEstadoCivil
            // 
            this.lblEstadoCivil.AutoSize = true;
            this.lblEstadoCivil.Location = new System.Drawing.Point(14, 332);
            this.lblEstadoCivil.Name = "lblEstadoCivil";
            this.lblEstadoCivil.Size = new System.Drawing.Size(84, 20);
            this.lblEstadoCivil.TabIndex = 9;
            this.lblEstadoCivil.Text = "Estado civil";
            // 
            // lblCantidadHijos
            // 
            this.lblCantidadHijos.AutoSize = true;
            this.lblCantidadHijos.Location = new System.Drawing.Point(14, 374);
            this.lblCantidadHijos.Name = "lblCantidadHijos";
            this.lblCantidadHijos.Size = new System.Drawing.Size(104, 20);
            this.lblCantidadHijos.TabIndex = 10;
            this.lblCantidadHijos.Text = "Cantidad hijos";
            // 
            // lblEstudioCompleto
            // 
            this.lblEstudioCompleto.AutoSize = true;
            this.lblEstudioCompleto.Location = new System.Drawing.Point(14, 418);
            this.lblEstudioCompleto.Name = "lblEstudioCompleto";
            this.lblEstudioCompleto.Size = new System.Drawing.Size(126, 20);
            this.lblEstudioCompleto.TabIndex = 11;
            this.lblEstudioCompleto.Text = "Estudio completo";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(146, 61);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(151, 27);
            this.txtNombre.TabIndex = 12;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(146, 107);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(151, 27);
            this.txtApellido.TabIndex = 13;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(146, 150);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(151, 27);
            this.txtEdad.TabIndex = 14;
            // 
            // cmbSexo
            // 
            this.cmbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino",
            "Otro"});
            this.cmbSexo.Location = new System.Drawing.Point(146, 193);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(151, 28);
            this.cmbSexo.TabIndex = 15;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(146, 237);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(151, 27);
            this.txtDni.TabIndex = 16;
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.Location = new System.Drawing.Point(146, 280);
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.Size = new System.Drawing.Size(151, 27);
            this.txtLocalidad.TabIndex = 17;
            // 
            // cmbEstadoCivil
            // 
            this.cmbEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoCivil.FormattingEnabled = true;
            this.cmbEstadoCivil.Items.AddRange(new object[] {
            "Soltero",
            "Casado"});
            this.cmbEstadoCivil.Location = new System.Drawing.Point(146, 324);
            this.cmbEstadoCivil.Name = "cmbEstadoCivil";
            this.cmbEstadoCivil.Size = new System.Drawing.Size(151, 28);
            this.cmbEstadoCivil.TabIndex = 18;
            // 
            // txtCantidadHijos
            // 
            this.txtCantidadHijos.Location = new System.Drawing.Point(146, 367);
            this.txtCantidadHijos.Name = "txtCantidadHijos";
            this.txtCantidadHijos.Size = new System.Drawing.Size(151, 27);
            this.txtCantidadHijos.TabIndex = 19;
            // 
            // cmbEstudioCompleto
            // 
            this.cmbEstudioCompleto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstudioCompleto.FormattingEnabled = true;
            this.cmbEstudioCompleto.Items.AddRange(new object[] {
            "Primario",
            "Secundario",
            "Terciario",
            "Universitario"});
            this.cmbEstudioCompleto.Location = new System.Drawing.Point(146, 410);
            this.cmbEstudioCompleto.Name = "cmbEstudioCompleto";
            this.cmbEstudioCompleto.Size = new System.Drawing.Size(151, 28);
            this.cmbEstudioCompleto.TabIndex = 20;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(737, 450);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(118, 40);
            this.btnGuardar.TabIndex = 21;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(613, 450);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(118, 40);
            this.btnAtras.TabIndex = 22;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // chkTrabajoRegistrado
            // 
            this.chkTrabajoRegistrado.AutoSize = true;
            this.chkTrabajoRegistrado.Enabled = false;
            this.chkTrabajoRegistrado.Location = new System.Drawing.Point(330, 61);
            this.chkTrabajoRegistrado.Name = "chkTrabajoRegistrado";
            this.chkTrabajoRegistrado.Size = new System.Drawing.Size(157, 24);
            this.chkTrabajoRegistrado.TabIndex = 23;
            this.chkTrabajoRegistrado.Text = "Trabajo Registrado";
            this.chkTrabajoRegistrado.UseVisualStyleBackColor = true;
            // 
            // chkRelacionDependencia
            // 
            this.chkRelacionDependencia.AutoSize = true;
            this.chkRelacionDependencia.Enabled = false;
            this.chkRelacionDependencia.Location = new System.Drawing.Point(330, 109);
            this.chkRelacionDependencia.Name = "chkRelacionDependencia";
            this.chkRelacionDependencia.Size = new System.Drawing.Size(199, 24);
            this.chkRelacionDependencia.TabIndex = 24;
            this.chkRelacionDependencia.Text = "Relacion de dependencia";
            this.chkRelacionDependencia.UseVisualStyleBackColor = true;
            // 
            // txtHorasTrabajadas
            // 
            this.txtHorasTrabajadas.Enabled = false;
            this.txtHorasTrabajadas.Location = new System.Drawing.Point(457, 150);
            this.txtHorasTrabajadas.Name = "txtHorasTrabajadas";
            this.txtHorasTrabajadas.Size = new System.Drawing.Size(72, 27);
            this.txtHorasTrabajadas.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(330, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Horas semanales";
            // 
            // lblEstablecimiento
            // 
            this.lblEstablecimiento.AutoSize = true;
            this.lblEstablecimiento.Location = new System.Drawing.Point(330, 202);
            this.lblEstablecimiento.Name = "lblEstablecimiento";
            this.lblEstablecimiento.Size = new System.Drawing.Size(115, 20);
            this.lblEstablecimiento.TabIndex = 27;
            this.lblEstablecimiento.Text = "Establecimiento";
            // 
            // lblNivelCarrera
            // 
            this.lblNivelCarrera.AutoSize = true;
            this.lblNivelCarrera.Location = new System.Drawing.Point(330, 244);
            this.lblNivelCarrera.Name = "lblNivelCarrera";
            this.lblNivelCarrera.Size = new System.Drawing.Size(93, 20);
            this.lblNivelCarrera.TabIndex = 28;
            this.lblNivelCarrera.Text = "Nivel carrera";
            // 
            // lblNombreTitulo
            // 
            this.lblNombreTitulo.AutoSize = true;
            this.lblNombreTitulo.Location = new System.Drawing.Point(330, 287);
            this.lblNombreTitulo.Name = "lblNombreTitulo";
            this.lblNombreTitulo.Size = new System.Drawing.Size(47, 20);
            this.lblNombreTitulo.TabIndex = 29;
            this.lblNombreTitulo.Text = "Titulo";
            // 
            // txtEstablecimiento
            // 
            this.txtEstablecimiento.Enabled = false;
            this.txtEstablecimiento.Location = new System.Drawing.Point(444, 194);
            this.txtEstablecimiento.Name = "txtEstablecimiento";
            this.txtEstablecimiento.Size = new System.Drawing.Size(143, 27);
            this.txtEstablecimiento.TabIndex = 30;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Enabled = false;
            this.txtTitulo.Location = new System.Drawing.Point(444, 284);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(143, 27);
            this.txtTitulo.TabIndex = 32;
            // 
            // lblAnioJubilacion
            // 
            this.lblAnioJubilacion.AutoSize = true;
            this.lblAnioJubilacion.Location = new System.Drawing.Point(330, 332);
            this.lblAnioJubilacion.Name = "lblAnioJubilacion";
            this.lblAnioJubilacion.Size = new System.Drawing.Size(105, 20);
            this.lblAnioJubilacion.TabIndex = 33;
            this.lblAnioJubilacion.Text = "Año jubilacion";
            // 
            // chkSigueTrabajando
            // 
            this.chkSigueTrabajando.AutoSize = true;
            this.chkSigueTrabajando.Enabled = false;
            this.chkSigueTrabajando.Location = new System.Drawing.Point(330, 370);
            this.chkSigueTrabajando.Name = "chkSigueTrabajando";
            this.chkSigueTrabajando.Size = new System.Drawing.Size(145, 24);
            this.chkSigueTrabajando.TabIndex = 35;
            this.chkSigueTrabajando.Text = "Sigue trabajando";
            this.chkSigueTrabajando.UseVisualStyleBackColor = true;
            // 
            // chkAyudaEstatal
            // 
            this.chkAyudaEstatal.AutoSize = true;
            this.chkAyudaEstatal.Enabled = false;
            this.chkAyudaEstatal.Location = new System.Drawing.Point(330, 459);
            this.chkAyudaEstatal.Name = "chkAyudaEstatal";
            this.chkAyudaEstatal.Size = new System.Drawing.Size(168, 24);
            this.chkAyudaEstatal.TabIndex = 38;
            this.chkAyudaEstatal.Text = "Recibe ayuda estatal";
            this.chkAyudaEstatal.UseVisualStyleBackColor = true;
            // 
            // cmbAnioJubilacion
            // 
            this.cmbAnioJubilacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAnioJubilacion.FormattingEnabled = true;
            this.cmbAnioJubilacion.Items.AddRange(new object[] {
            "1980",
            "1981",
            "1982",
            "1983",
            "1984",
            "1985",
            "1986",
            "1987",
            "1988",
            "1989",
            "1990",
            "1991",
            "1992",
            "1993",
            "1994",
            "1995",
            "1996",
            "1997",
            "1998",
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021"});
            this.cmbAnioJubilacion.Location = new System.Drawing.Point(444, 324);
            this.cmbAnioJubilacion.Name = "cmbAnioJubilacion";
            this.cmbAnioJubilacion.Size = new System.Drawing.Size(151, 28);
            this.cmbAnioJubilacion.TabIndex = 39;
            // 
            // cmbNivelCarrera
            // 
            this.cmbNivelCarrera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNivelCarrera.Enabled = false;
            this.cmbNivelCarrera.FormattingEnabled = true;
            this.cmbNivelCarrera.Items.AddRange(new object[] {
            "Secundario",
            "Terciario",
            "Universitario"});
            this.cmbNivelCarrera.Location = new System.Drawing.Point(444, 237);
            this.cmbNivelCarrera.Name = "cmbNivelCarrera";
            this.cmbNivelCarrera.Size = new System.Drawing.Size(151, 28);
            this.cmbNivelCarrera.TabIndex = 40;
            // 
            // dtpFechaUltimoTrabajo
            // 
            this.dtpFechaUltimoTrabajo.Location = new System.Drawing.Point(481, 411);
            this.dtpFechaUltimoTrabajo.Name = "dtpFechaUltimoTrabajo";
            this.dtpFechaUltimoTrabajo.Size = new System.Drawing.Size(250, 27);
            this.dtpFechaUltimoTrabajo.TabIndex = 41;
            // 
            // lblUltimoTrabajo
            // 
            this.lblUltimoTrabajo.AutoSize = true;
            this.lblUltimoTrabajo.Location = new System.Drawing.Point(329, 418);
            this.lblUltimoTrabajo.Name = "lblUltimoTrabajo";
            this.lblUltimoTrabajo.Size = new System.Drawing.Size(146, 20);
            this.lblUltimoTrabajo.TabIndex = 42;
            this.lblUltimoTrabajo.Text = "Fecha ultimo trabajo";
            // 
            // lblAltaExitosa
            // 
            this.lblAltaExitosa.AutoSize = true;
            this.lblAltaExitosa.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAltaExitosa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblAltaExitosa.Location = new System.Drawing.Point(598, 374);
            this.lblAltaExitosa.Name = "lblAltaExitosa";
            this.lblAltaExitosa.Size = new System.Drawing.Size(256, 23);
            this.lblAltaExitosa.TabIndex = 43;
            this.lblAltaExitosa.Text = "Datos guardados correctamente";
            this.lblAltaExitosa.Visible = false;
            // 
            // FrmAlta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 497);
            this.Controls.Add(this.lblAltaExitosa);
            this.Controls.Add(this.lblUltimoTrabajo);
            this.Controls.Add(this.dtpFechaUltimoTrabajo);
            this.Controls.Add(this.cmbNivelCarrera);
            this.Controls.Add(this.cmbAnioJubilacion);
            this.Controls.Add(this.chkAyudaEstatal);
            this.Controls.Add(this.chkSigueTrabajando);
            this.Controls.Add(this.lblAnioJubilacion);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.txtEstablecimiento);
            this.Controls.Add(this.lblNombreTitulo);
            this.Controls.Add(this.lblNivelCarrera);
            this.Controls.Add(this.lblEstablecimiento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHorasTrabajadas);
            this.Controls.Add(this.chkRelacionDependencia);
            this.Controls.Add(this.chkTrabajoRegistrado);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cmbEstudioCompleto);
            this.Controls.Add(this.txtCantidadHijos);
            this.Controls.Add(this.cmbEstadoCivil);
            this.Controls.Add(this.txtLocalidad);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.cmbSexo);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblEstudioCompleto);
            this.Controls.Add(this.lblCantidadHijos);
            this.Controls.Add(this.lblEstadoCivil);
            this.Controls.Add(this.lblLocalidad);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblActividad);
            this.Controls.Add(this.cmbActividad);
            this.Name = "FrmAlta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAlta";
            this.Load += new System.EventHandler(this.FrmAlta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbActividad;
        private System.Windows.Forms.Label lblActividad;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.Label lblEstadoCivil;
        private System.Windows.Forms.Label lblCantidadHijos;
        private System.Windows.Forms.Label lblEstudioCompleto;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtLocalidad;
        private System.Windows.Forms.ComboBox cmbEstadoCivil;
        private System.Windows.Forms.TextBox txtCantidadHijos;
        private System.Windows.Forms.ComboBox cmbEstudioCompleto;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.CheckBox chkTrabajoRegistrado;
        private System.Windows.Forms.CheckBox chkRelacionDependencia;
        private System.Windows.Forms.TextBox txtHorasTrabajadas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEstablecimiento;
        private System.Windows.Forms.Label lblNivelCarrera;
        private System.Windows.Forms.Label lblNombreTitulo;
        private System.Windows.Forms.TextBox txtEstablecimiento;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblAnioJubilacion;
        private System.Windows.Forms.CheckBox chkSigueTrabajando;
        private System.Windows.Forms.CheckBox chkAyudaEstatal;
        private System.Windows.Forms.ComboBox cmbAnioJubilacion;
        private System.Windows.Forms.ComboBox cmbNivelCarrera;
        private System.Windows.Forms.DateTimePicker dtpFechaUltimoTrabajo;
        private System.Windows.Forms.Label lblUltimoTrabajo;
        private System.Windows.Forms.Label lblAltaExitosa;
    }
}