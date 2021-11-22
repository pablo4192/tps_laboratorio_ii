using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using Entidades;
using System.Threading;

namespace FrmCenso
{
    public partial class FrmInformes : Form
    {
        List<Persona> listaExportada;
        Task tarea;
        Task tareaExportar;

        static FrmInformes()
        {
            Censo<Persona>.RegistroCompleto.AddRange(Censo<Trabajador>.Registros);
            Censo<Persona>.RegistroCompleto.AddRange(Censo<Estudiante>.Registros);
            Censo<Persona>.RegistroCompleto.AddRange(Censo<Estudiante_Trabajador>.Registros);
            Censo<Persona>.RegistroCompleto.AddRange(Censo<Jubilado>.Registros);
            Censo<Persona>.RegistroCompleto.AddRange(Censo<Desocupado>.Registros);

        }

        public FrmInformes()
        {
            InitializeComponent();

            listaExportada = new List<Persona>();
            ExportarInfo.avisarErrorDelegado += ErrorNombreArchivo;
            ExportarInfo.avisarExitoDelegado += ExitoAlGuardar;
            
            
           
        }

        private void FrmInformes_Load(object sender, EventArgs e)
        {
            dgvListadoCenso.DataSource = Censo<Persona>.RegistroCompleto; 
            this.cmbActividad.DataSource = Enum.GetValues(typeof(EActividad));
        }

        private void cmbActividad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.cmbActividad.Text == EActividad.Persona.ToString())
            {
                dgvListadoCenso.DataSource = null;
                dgvListadoCenso.DataSource = Censo<Persona>.RegistroCompleto;
            }
            else if (this.cmbActividad.Text == EActividad.Trabajador.ToString())
            {
                dgvListadoCenso.DataSource = null;
                dgvListadoCenso.DataSource = Censo<Trabajador>.Registros;
            }
            else if (this.cmbActividad.Text == EActividad.Estudiante.ToString())
            {
                dgvListadoCenso.DataSource = null;
                dgvListadoCenso.DataSource = Censo<Estudiante>.Registros;
            }
            else if (this.cmbActividad.Text == EActividad.Estudiante_Trabajador.ToString())
            {
                dgvListadoCenso.DataSource = null;
                dgvListadoCenso.DataSource = Censo<Estudiante_Trabajador>.Registros;
            }
            else if (this.cmbActividad.Text == EActividad.Jubilado.ToString())
            {
                dgvListadoCenso.DataSource = null;
                dgvListadoCenso.DataSource = Censo<Jubilado>.Registros;
            }
            else if (this.cmbActividad.Text == EActividad.Desocupado.ToString())
            {
                dgvListadoCenso.DataSource = null;
                dgvListadoCenso.DataSource = Censo<Desocupado>.Registros;
            }
        }

        private void btnFiltro_LocalidadMasDesoc_Click(object sender, EventArgs e)
        {
            FrmLocalidadMayorDesocupacion frmLoc_MayorDesoc = new FrmLocalidadMayorDesocupacion();
            frmLoc_MayorDesoc.ShowDialog();

        }

        private void btnFiltro_Menores30Deso_Click(object sender, EventArgs e)
        {
            FrmMenores30Desocupados frm_Menor30Desoc = new FrmMenores30Desocupados();
            frm_Menor30Desoc.ShowDialog();
        }

        private void btnFiltro_SexoMasDesoc_Click(object sender, EventArgs e)
        {
            FrmSexoMayorDesocupacion frmSexo = new FrmSexoMayorDesocupacion();
            frmSexo.ShowDialog();
        }

        private void btnFiltro_TrabajoNoRegistrado_Click(object sender, EventArgs e)
        {
            FrmTrabajadoresNoRegistrados frmTrabaNoRegistrado = new FrmTrabajadoresNoRegistrados();
            frmTrabaNoRegistrado.ShowDialog();
        }

        private void btnFiltro_CarreraMasEstudiada_Click(object sender, EventArgs e)
        {
            FrmCarreraMasEstudiada frmCarrera = new FrmCarreraMasEstudiada();
            frmCarrera.ShowDialog();
        }

        private void btnExportarCsv_Click(object sender, EventArgs e)
        {
            tareaExportar = new Task(ExportarInfo.ExportarDatosListaPersona_Csv, txtNombreArchivo.Text);
            tareaExportar.Start();
        }
            
        private void btnExportarJson_Click(object sender, EventArgs e)
        {
            tareaExportar = new Task(ExportarInfo.ExportarDatosJson, txtNombreArchivo.Text);
            tareaExportar.Start();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipal frmMenu = new FrmMenuPrincipal();
            frmMenu.Show();
            this.Close();
        }

        private void ExitoAlGuardar()
        {
            MessageBox.Show("Archivo guardado exitosamente");
        }

        private void ErrorNombreArchivo()
        {
            MessageBox.Show("El nombre de archivo solo debe contener letras");
        }

        private void cmbCriterio_SelectedIndexChanged(object sender, EventArgs e)
        {
            tarea = new Task(Censo<Persona>.OrdenarRegistroPorEdad, cmbCriterio.Text);

            tarea.Start();

            lblAvisoOrdenar.Visible = true;

            tarea.Wait();
            this.dgvListadoCenso.DataSource = null;
            this.dgvListadoCenso.DataSource = Censo<Persona>.RegistroCompleto;

            lblAvisoOrdenar.Visible = false;
        }

        
    }




    
}
