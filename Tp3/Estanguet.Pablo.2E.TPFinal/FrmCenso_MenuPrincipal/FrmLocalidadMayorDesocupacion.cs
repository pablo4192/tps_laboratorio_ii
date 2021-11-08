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
    public partial class FrmLocalidadMayorDesocupacion : FrmBase
    {
        List<Desocupado> listaAux;
        List<string> localidades;
       


        public FrmLocalidadMayorDesocupacion()
        {
            InitializeComponent();
            listaAux = new List<Desocupado>();
            localidades = new List<string>();
        }

        private void FrmLocalidadMayorDesocupacion_Load(object sender, EventArgs e)
        {
            this.lblTitulo.Text = "Localidad con mayor indice de desocupacion";
            this.lblSubTitulo.Text = "Listado de personas de las localidades antes mencionadas";

            listaAux = Censo<Desocupado>.Filtrar_LocalidadMayorDesocupacion(out localidades);
            dgvLista.DataSource = listaAux;

            this.lblInforme.Text = "Localidad/es con mas cantidad de desocupados: ";
            foreach (string item in localidades)
            {
                this.lblInforme.Text += $"{item}, ";
            }
        }

        private void btnExportarCsv_Click(object sender, EventArgs e)
        {
            this.lblSoloLetras.Visible = false;

            if (!string.IsNullOrEmpty(txtNombreArchivo.Text) && FrmInformes.VerificarNombreArchivo(txtNombreArchivo.Text))
            {
                Censo<Desocupado>.ExportarDatos(listaAux, txtNombreArchivo.Text);
                MessageBox.Show("Archivo guardado en Csv");
            }
            else
            {
                this.lblSoloLetras.Visible = true;
                this.lblSoloLetras.Text = "El nombre de archivo solo debe contener letras";
            }
        }
    }
}
