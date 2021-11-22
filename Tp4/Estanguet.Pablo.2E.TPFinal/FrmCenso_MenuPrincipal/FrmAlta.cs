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
   
    public partial class FrmAlta: Form
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
            DatosInvalidosExcepcion datosInvalidos = new DatosInvalidosExcepcion();
            ProblemasDeConexionSqlExcepcion problemasDeConexion = new ProblemasDeConexionSqlExcepcion();

             

            lblAltaExitosa.Visible = false;

            

            if(this.cmbActividad.Text == EActividad.Trabajador.ToString())
            {
                try
                {
                    Trabajador trabajadorAux = new Trabajador();
                    GuardarCambiosDelegate<Trabajador> delegadoGuardar = Censo<Trabajador>.RetornarDelegado();
                    

                    if (trabajadorAux.VerificarDatosInt(txtEdad.Text, txtDni.Text, txtCantidadHijos.Text, txtHorasTrabajadas.Text))
                    {
                        Trabajador trabajadorNuevo = new Trabajador(txtNombre.Text, txtApellido.Text, int.Parse(txtEdad.Text), cmbSexo.Text, int.Parse(txtDni.Text), txtLocalidad.Text, cmbEstadoCivil.Text, int.Parse(txtCantidadHijos.Text), cmbEstudioCompleto.Text, chkTrabajoRegistrado.Checked, chkRelacionDependencia.Checked, int.Parse(txtHorasTrabajadas.Text));
                        Censo<Persona>.RegistroCompleto.Add(trabajadorNuevo);

                        Limpiar();
                        lblAltaExitosa.Visible = true;
                        //Censo<Trabajador>.SerializarXml();
                        delegadoGuardar.Invoke(trabajadorNuevo);
                    }
                    else
                    {
                        throw datosInvalidos;
                    }

                }
                catch(DatosInvalidosExcepcion)
                {
                    MessageBox.Show(datosInvalidos.Message);
                }
                catch(ProblemasDeConexionSqlExcepcion)
                {
                    MessageBox.Show(problemasDeConexion.Message);
                }


            }
            else if(this.cmbActividad.Text == EActividad.Estudiante.ToString())
            {
                try
                {
                    Estudiante estudianteAux = new Estudiante();
                    GuardarCambiosDelegate<Estudiante> delegadoGuardar = Censo<Estudiante>.RetornarDelegado();

                    if (estudianteAux.VerificarDatosInt(txtEdad.Text, txtDni.Text, txtCantidadHijos.Text, txtHorasTrabajadas.Text))
                    {
                        Estudiante estudianteNuevo = new Estudiante(txtNombre.Text, txtApellido.Text, int.Parse(txtEdad.Text), cmbSexo.Text, int.Parse(txtDni.Text), txtLocalidad.Text, cmbEstadoCivil.Text, int.Parse(txtCantidadHijos.Text), cmbEstudioCompleto.Text, txtEstablecimiento.Text, cmbNivelCarrera.Text, txtTitulo.Text);
                        Censo<Persona>.RegistroCompleto.Add(estudianteNuevo);

                        Limpiar();
                        lblAltaExitosa.Visible = true;
                        //Censo<Estudiante>.SerializarXml();
                        delegadoGuardar.Invoke(estudianteNuevo);
                        
                    }
                    else
                    {
                        throw datosInvalidos;
                    }
                    
                }
                catch(DatosInvalidosExcepcion)
                {
                    MessageBox.Show(datosInvalidos.Message);
                }
                catch(ProblemasDeConexionSqlExcepcion)
                {
                    MessageBox.Show(problemasDeConexion.Message);
                }
                   
                
            }
            else if (this.cmbActividad.Text == EActividad.Estudiante_Trabajador.ToString())
            {
                try
                {
                    Estudiante_Trabajador estudiante_TrabaAux = new Estudiante_Trabajador();
                    GuardarCambiosDelegate<Estudiante_Trabajador> delegadoGuardar = Censo<Estudiante_Trabajador>.RetornarDelegado();

                    if (estudiante_TrabaAux.VerificarDatosInt(txtEdad.Text, txtDni.Text, txtCantidadHijos.Text, txtHorasTrabajadas.Text))
                    {
                        Estudiante_Trabajador estudiante_TrabaNuevo = new Estudiante_Trabajador(txtNombre.Text, txtApellido.Text, int.Parse(txtEdad.Text), cmbSexo.Text, int.Parse(txtDni.Text), txtLocalidad.Text, cmbEstadoCivil.Text, int.Parse(txtCantidadHijos.Text), cmbEstudioCompleto.Text, txtEstablecimiento.Text, cmbNivelCarrera.Text, txtTitulo.Text, chkTrabajoRegistrado.Checked, chkRelacionDependencia.Checked, int.Parse(txtHorasTrabajadas.Text));
                        Censo<Persona>.RegistroCompleto.Add(estudiante_TrabaNuevo);

                        Limpiar();
                        lblAltaExitosa.Visible = true;
                        //Censo<Estudiante_Trabajador>.SerializarXml();
                        delegadoGuardar.Invoke(estudiante_TrabaNuevo);
                    }
                    else
                    {
                        throw datosInvalidos;
                    }
                    
                }
                catch (DatosInvalidosExcepcion)
                {
                    MessageBox.Show(datosInvalidos.Message);
                }
                catch (ProblemasDeConexionSqlExcepcion)
                {
                    MessageBox.Show(problemasDeConexion.Message);
                }

            }
            else if (this.cmbActividad.Text == EActividad.Jubilado.ToString())
            {
                try
                {
                    Jubilado jubiladoAux = new Jubilado();
                    GuardarCambiosDelegate<Jubilado> delegadoGuardar = Censo<Jubilado>.RetornarDelegado();

                    if (jubiladoAux.VerificarDatosInt(txtEdad.Text, txtDni.Text, txtCantidadHijos.Text, txtHorasTrabajadas.Text))
                    {
                        Jubilado jubiladoNuevo = new Jubilado(txtNombre.Text, txtApellido.Text, int.Parse(txtEdad.Text), cmbSexo.Text, int.Parse(txtDni.Text), txtLocalidad.Text, cmbEstadoCivil.Text, int.Parse(txtCantidadHijos.Text), cmbEstudioCompleto.Text, int.Parse(cmbAnioJubilacion.Text), chkSigueTrabajando.Checked);
                        Censo<Persona>.RegistroCompleto.Add(jubiladoNuevo);

                        Limpiar();
                        lblAltaExitosa.Visible = true;
                        //Censo<Jubilado>.SerializarXml();
                        delegadoGuardar.Invoke(jubiladoNuevo);
                    }
                    else
                    {
                        throw datosInvalidos;
                    }
                    
                }
                catch (DatosInvalidosExcepcion)
                {
                    MessageBox.Show(datosInvalidos.Message);
                }
                catch (ProblemasDeConexionSqlExcepcion)
                {
                    MessageBox.Show(problemasDeConexion.Message);
                }



            }
            else if (this.cmbActividad.Text == EActividad.Desocupado.ToString())
            {
                try
                {
                    Desocupado desocupadoAux = new Desocupado();
                    GuardarCambiosDelegate<Desocupado> delegadoGuardar = Censo<Desocupado>.RetornarDelegado();

                    if (desocupadoAux.VerificarDatosInt(txtEdad.Text, txtDni.Text, txtCantidadHijos.Text, txtHorasTrabajadas.Text))
                    {
                        Desocupado desocupadoNuevo = new Desocupado(txtNombre.Text, txtApellido.Text, int.Parse(txtEdad.Text), cmbSexo.Text, int.Parse(txtDni.Text), txtLocalidad.Text, cmbEstadoCivil.Text, int.Parse(txtCantidadHijos.Text), cmbEstudioCompleto.Text, dtpFechaUltimoTrabajo.Value, chkAyudaEstatal.Checked);
                        Censo<Persona>.RegistroCompleto.Add(desocupadoNuevo);

                        Limpiar();
                        lblAltaExitosa.Visible = true;
                        //Censo<Desocupado>.SerializarXml();
                        delegadoGuardar.Invoke(desocupadoNuevo);
                    }
                    else
                    {
                        throw datosInvalidos;
                    }
                    
                }
                catch (DatosInvalidosExcepcion)
                {
                    MessageBox.Show(datosInvalidos.Message);
                }
                catch (ProblemasDeConexionSqlExcepcion)
                {
                    MessageBox.Show(problemasDeConexion.Message);
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
