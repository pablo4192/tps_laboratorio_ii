using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace FrmCenso
{
    public partial class FrmAlta : Form
    {
        public FrmAlta()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipal frmMenu = new FrmMenuPrincipal();
            frmMenu.Show();
            this.Close();
        }

        private void FrmAlta_Load(object sender, EventArgs e)
        {
            this.cmbActividad.DataSource = Enum.GetValues(typeof(EActividad));
            
        }

        private void cmbActividad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbActividad.Text == EActividad.Persona.ToString())
            {
                this.txtEstablecimiento.Enabled = false;
                this.cmbNivelCarrera.Enabled = false;
                this.txtTitulo.Enabled = false;
                this.cmbAnioJubilacion.Enabled = false;
                this.chkSigueTrabajando.Enabled = false;
                this.chkAyudaEstatal.Enabled = false;
                this.dtpFechaUltimoTrabajo.Enabled = false;
                this.chkTrabajoRegistrado.Enabled = false;
                this.chkRelacionDependencia.Enabled = false;
                this.txtHorasTrabajadas.Enabled = false;
                this.btnGuardar.Enabled = false;
            }
            else if (this.cmbActividad.Text == EActividad.Trabajador.ToString())
            {
                this.txtEstablecimiento.Enabled = false;
                this.cmbNivelCarrera.Enabled = false;
                this.txtTitulo.Enabled = false;
                this.cmbAnioJubilacion.Enabled = false;
                this.chkSigueTrabajando.Enabled = false;
                this.chkAyudaEstatal.Enabled = false;
                this.dtpFechaUltimoTrabajo.Enabled = false;
                this.chkTrabajoRegistrado.Enabled = true;
                this.chkRelacionDependencia.Enabled = true;
                this.txtHorasTrabajadas.Enabled = true;
                this.btnGuardar.Enabled = true;
            }
            else if (this.cmbActividad.Text == EActividad.Estudiante.ToString())
            {
                this.txtEstablecimiento.Enabled = true;
                this.cmbNivelCarrera.Enabled = true;
                this.txtTitulo.Enabled = true;
                this.cmbAnioJubilacion.Enabled = false;
                this.chkSigueTrabajando.Enabled = false;
                this.chkAyudaEstatal.Enabled = false;
                this.dtpFechaUltimoTrabajo.Enabled = false;
                this.chkTrabajoRegistrado.Enabled = false;
                this.chkRelacionDependencia.Enabled = false;
                this.txtHorasTrabajadas.Enabled = false;
                this.btnGuardar.Enabled = true;
            }
            else if (this.cmbActividad.Text == EActividad.Estudiante_Trabajador.ToString())
            {
                this.txtEstablecimiento.Enabled = true;
                this.cmbNivelCarrera.Enabled = true;
                this.txtTitulo.Enabled = true;
                this.cmbAnioJubilacion.Enabled = false;
                this.chkSigueTrabajando.Enabled = false;
                this.chkAyudaEstatal.Enabled = false;
                this.dtpFechaUltimoTrabajo.Enabled = false;
                this.chkTrabajoRegistrado.Enabled = true;
                this.chkRelacionDependencia.Enabled = true;
                this.txtHorasTrabajadas.Enabled = true;
                this.btnGuardar.Enabled = true;
            }
            else if (this.cmbActividad.Text == EActividad.Jubilado.ToString())
            {
                this.txtEstablecimiento.Enabled = false;
                this.cmbNivelCarrera.Enabled = false;
                this.txtTitulo.Enabled = false;
                this.cmbAnioJubilacion.Enabled = true;
                this.chkSigueTrabajando.Enabled = true;
                this.chkAyudaEstatal.Enabled = false;
                this.dtpFechaUltimoTrabajo.Enabled = false;
                this.chkTrabajoRegistrado.Enabled = false;
                this.chkRelacionDependencia.Enabled = false;
                this.txtHorasTrabajadas.Enabled = false;
                this.btnGuardar.Enabled = true;
            }
            else if (this.cmbActividad.Text == EActividad.Desocupado.ToString())
            {
                this.txtEstablecimiento.Enabled = false;
                this.cmbNivelCarrera.Enabled = false;
                this.txtTitulo.Enabled = false;
                this.cmbAnioJubilacion.Enabled = false;
                this.chkSigueTrabajando.Enabled = false;
                this.chkAyudaEstatal.Enabled = true;
                this.dtpFechaUltimoTrabajo.Enabled = true;
                this.chkTrabajoRegistrado.Enabled = false;
                this.chkRelacionDependencia.Enabled = false;
                this.txtHorasTrabajadas.Enabled = false;
                this.btnGuardar.Enabled = true;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int horasSemanalesInt;
            lblAltaExitosa.Visible = false;

            if(this.cmbActividad.Text == EActividad.Trabajador.ToString())
            {
                Trabajador trabajadorAux = new Trabajador();
                if(trabajadorAux.VerificarDatos(txtNombre.Text, txtApellido.Text, txtEdad.Text, txtDni.Text, txtLocalidad.Text, txtCantidadHijos.Text, txtHorasTrabajadas.Text, txtEstablecimiento.Text, txtTitulo.Text))
                {
                    Trabajador trabajadorNuevo = new Trabajador(txtNombre.Text, txtApellido.Text, int.Parse(txtEdad.Text), cmbSexo.Text, int.Parse(txtDni.Text), txtLocalidad.Text, cmbEstadoCivil.Text, int.Parse(txtCantidadHijos.Text), cmbEstudioCompleto.Text, chkTrabajoRegistrado.Checked, chkRelacionDependencia.Checked, int.Parse(txtHorasTrabajadas.Text));
                    Censo<Trabajador>.Registros.Add(trabajadorNuevo);
                    Censo<Persona>.RegistroCompleto.Add(trabajadorNuevo);

                    Limpiar();
                    lblAltaExitosa.Visible = true;
                    Censo<Trabajador>.SerializarXml();
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el registro, verifique los datos ingresados");
                }
            }
            else if(this.cmbActividad.Text == EActividad.Estudiante.ToString())
            {
                Estudiante estudianteAux = new Estudiante();
                if(estudianteAux.VerificarDatos(txtNombre.Text, txtApellido.Text, txtEdad.Text, txtDni.Text, txtLocalidad.Text, txtCantidadHijos.Text, txtHorasTrabajadas.Text, txtEstablecimiento.Text, txtTitulo.Text))
                {
                    Estudiante estudianteNuevo = new Estudiante(txtNombre.Text, txtApellido.Text, int.Parse(txtEdad.Text), cmbSexo.Text, int.Parse(txtDni.Text), txtLocalidad.Text, cmbEstadoCivil.Text, int.Parse(txtCantidadHijos.Text), cmbEstudioCompleto.Text, txtEstablecimiento.Text, cmbNivelCarrera.Text, txtTitulo.Text);
                    Censo<Estudiante>.Registros.Add(estudianteNuevo);
                    Censo<Persona>.RegistroCompleto.Add(estudianteNuevo);

                    Limpiar();
                    lblAltaExitosa.Visible = true;
                    Censo<Estudiante>.SerializarXml();
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el registro, verifique los datos ingresados");
                }
            }
            else if (this.cmbActividad.Text == EActividad.Estudiante_Trabajador.ToString())
            {
                Estudiante_Trabajador estudiante_TrabaAux = new Estudiante_Trabajador();
                if (estudiante_TrabaAux.VerificarDatos(txtNombre.Text, txtApellido.Text, txtEdad.Text, txtDni.Text, txtLocalidad.Text, txtCantidadHijos.Text, txtHorasTrabajadas.Text, txtEstablecimiento.Text, txtTitulo.Text))
                {
                    if(int.TryParse(txtHorasTrabajadas.Text, out horasSemanalesInt))
                    {
                        Estudiante_Trabajador estudiante_TrabaNuevo = new Estudiante_Trabajador(txtNombre.Text, txtApellido.Text, int.Parse(txtEdad.Text), cmbSexo.Text, int.Parse(txtDni.Text), txtLocalidad.Text, cmbEstadoCivil.Text, int.Parse(txtCantidadHijos.Text), cmbEstudioCompleto.Text, txtEstablecimiento.Text, cmbNivelCarrera.Text, txtTitulo.Text, chkTrabajoRegistrado.Checked, chkRelacionDependencia.Checked, horasSemanalesInt);
                        Censo<Estudiante_Trabajador>.Registros.Add(estudiante_TrabaNuevo);
                        Censo<Persona>.RegistroCompleto.Add(estudiante_TrabaNuevo);

                        Limpiar();
                        lblAltaExitosa.Visible = true;
                        Censo<Estudiante_Trabajador>.SerializarXml();
                    }
                    
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el registro, verifique los datos ingresados");
                }
            }
            else if (this.cmbActividad.Text == EActividad.Jubilado.ToString())
            {
                Jubilado jubiladoAux = new Jubilado();
                if (jubiladoAux.VerificarDatos(txtNombre.Text, txtApellido.Text, txtEdad.Text, txtDni.Text, txtLocalidad.Text, txtCantidadHijos.Text, txtHorasTrabajadas.Text, txtEstablecimiento.Text, txtTitulo.Text))
                {
                    Jubilado jubiladoNuevo = new Jubilado(txtNombre.Text, txtApellido.Text, int.Parse(txtEdad.Text), cmbSexo.Text, int.Parse(txtDni.Text), txtLocalidad.Text, cmbEstadoCivil.Text, int.Parse(txtCantidadHijos.Text), cmbEstudioCompleto.Text, int.Parse(cmbAnioJubilacion.Text), chkSigueTrabajando.Checked);
                    Censo<Jubilado>.Registros.Add(jubiladoNuevo);
                    Censo<Persona>.RegistroCompleto.Add(jubiladoNuevo);

                    Limpiar();
                    lblAltaExitosa.Visible = true;
                    Censo<Jubilado>.SerializarXml();
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el registro, verifique los datos ingresados");
                }
            }
            else if (this.cmbActividad.Text == EActividad.Desocupado.ToString())
            {
                Desocupado desocupadoAux = new Desocupado();
                if (desocupadoAux.VerificarDatos(txtNombre.Text, txtApellido.Text, txtEdad.Text, txtDni.Text, txtLocalidad.Text, txtCantidadHijos.Text, txtHorasTrabajadas.Text, txtEstablecimiento.Text, txtTitulo.Text))
                {
                    Desocupado desocupadoNuevo = new Desocupado(txtNombre.Text, txtApellido.Text, int.Parse(txtEdad.Text), cmbSexo.Text, int.Parse(txtDni.Text), txtLocalidad.Text, cmbEstadoCivil.Text, int.Parse(txtCantidadHijos.Text), cmbEstudioCompleto.Text, dtpFechaUltimoTrabajo.Value, chkAyudaEstatal.Checked);
                    Censo<Desocupado>.Registros.Add(desocupadoNuevo);
                    Censo<Persona>.RegistroCompleto.Add(desocupadoNuevo);

                    Limpiar();
                    lblAltaExitosa.Visible = true;
                    Censo<Desocupado>.SerializarXml();

                }
                else
                {
                    MessageBox.Show("No se pudo guardar el registro, verifique los datos ingresados");
                }
            }

            
            
            
            
            
        }

        private void Limpiar()
        {
            this.txtEstablecimiento.Text = string.Empty;
            this.cmbNivelCarrera.Text = string.Empty;
            this.txtTitulo.Text = string.Empty;
            this.cmbAnioJubilacion.Text = string.Empty;
            this.chkSigueTrabajando.Checked = false;
            this.chkAyudaEstatal.Checked = false;
            this.dtpFechaUltimoTrabajo.Value = DateTime.Today;
            this.chkTrabajoRegistrado.Checked = false;
            this.chkRelacionDependencia.Checked = false;
            this.txtHorasTrabajadas.Text = string.Empty;
            this.txtNombre.Text = string.Empty;
            this.txtApellido.Text = string.Empty;
            this.txtEdad.Text = string.Empty;
            this.cmbSexo.Text = string.Empty;
            this.txtDni.Text = string.Empty;
            this.txtLocalidad.Text = string.Empty;
            this.cmbEstadoCivil.Text = string.Empty;
            this.txtCantidadHijos.Text = string.Empty;
            this.cmbEstudioCompleto.Text = string.Empty;

        }

       
    }
}
