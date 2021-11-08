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

namespace FrmCenso
{
    public partial class FrmInformes : Form
    {
        List<Persona> listaAux;

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
            
            listaAux = new List<Persona>();
        }

        private void FrmInformes_Load(object sender, EventArgs e)
        {
            
            listaAux = Censo<Persona>.RegistroCompleto;
            dgvListadoCenso.DataSource = listaAux;
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

        public static bool VerificarNombreArchivo(string nombreArchivo)
        {
            for (int i = 0; i < nombreArchivo.Length; i++)
            {
                if (!char.IsLetter(nombreArchivo[i]))
                {
                    return false;
                }
            }
            return true;
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
            this.lblSoloLetras.Visible = false;

            if (!string.IsNullOrEmpty(txtNombreArchivo.Text) && FrmInformes.VerificarNombreArchivo(txtNombreArchivo.Text))
            {
                Censo<Persona>.ExportarDatosListaPersona_Csv( listaAux, txtNombreArchivo.Text);
                MessageBox.Show("Archivo guardado en Csv");
            }
            else
            {
                this.lblSoloLetras.Visible = true;
                this.lblSoloLetras.Text = "El nombre de archivo solo debe contener letras";
            }
        }

        private void btnExportarJson_Click(object sender, EventArgs e)
        {
            this.lblSoloLetras.Visible = false;

            if (!string.IsNullOrEmpty(txtNombreArchivo.Text) && FrmInformes.VerificarNombreArchivo(txtNombreArchivo.Text))
            {
                Censo<Persona>.ExportarDatosJson(txtNombreArchivo.Text);
                MessageBox.Show("Archivo guardado en Json");
            }
            else
            {
                this.lblSoloLetras.Visible = true;
                this.lblSoloLetras.Text = "El nombre de archivo solo debe contener letras";
            }


            
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipal frmMenu = new FrmMenuPrincipal();
            frmMenu.Show();
            this.Close();
        }
    }
}
