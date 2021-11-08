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
    public partial class FrmTrabajadoresNoRegistrados : FrmBase
    {
        List<Trabajador> listaAux;

        public FrmTrabajadoresNoRegistrados()
        {
            InitializeComponent();
            listaAux = new List<Trabajador>();
        }

        private void FrmTrabajadoresNoRegistrados_Load(object sender, EventArgs e)
        {
            this.lblTitulo.Text = "Trabajadores no registrados";
            this.lblSubTitulo.Text = "Listado de trabajadores no registrados";

            listaAux = Censo<Trabajador>.Filtrar_TrabajadoresNoRegistrados();
            dgvLista.DataSource = listaAux;

            this.lblInforme.Text = $"La cantidad de trabajadores no registrados es: {listaAux.Count}";
        }

        private void btnExportarCsv_Click(object sender, EventArgs e)
        {
            this.lblSoloLetras.Visible = false;

            if (!string.IsNullOrEmpty(txtNombreArchivo.Text) && FrmInformes.VerificarNombreArchivo(txtNombreArchivo.Text))
            {
                Censo<Trabajador>.ExportarDatos(listaAux, txtNombreArchivo.Text);
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
