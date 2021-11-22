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
    public partial class FrmMenores30Desocupados : FrmBase
    {
        List<Desocupado> listaAux;

        public FrmMenores30Desocupados()
        {
            InitializeComponent();
            listaAux = new List<Desocupado>();
        }

        private void FrmMenores30Desocupados_Load(object sender, EventArgs e)
        {
            this.lblTitulo.Text = "Menores de 30 años desocupados";
            this.lblSubTitulo.Text = "Listado de personas menores de 30 años desocupadas";

            listaAux = Censo<Desocupado>.Filtrar_DesocupadosMenores30();
            dgvLista.DataSource = listaAux;

            this.lblInforme.Text = $"Cantidad de personas menores de 30 años desocupadas: {listaAux.Count}";
           
        }

        private void btnExportarCsv_Click(object sender, EventArgs e)
        {
           ExportarInfo.ExportarDatos<Desocupado>(listaAux, txtNombreArchivo.Text);
              
         }
    }
}
