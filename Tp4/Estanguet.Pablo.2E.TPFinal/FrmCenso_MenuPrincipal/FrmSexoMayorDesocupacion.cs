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
    public partial class FrmSexoMayorDesocupacion : FrmBase
    {
        List<Desocupado> listaAux;
        string sexo;

        public FrmSexoMayorDesocupacion()
        {
            InitializeComponent();
            listaAux = new List<Desocupado>(); 
        }

        private void FrmSexoMayorDesocupacion_Load(object sender, EventArgs e)
        {
            this.lblTitulo.Text = "Genero con mayor indice de desocupacion";
            

            this.listaAux = Censo<Desocupado>.Filtrar_SexoMasDesocupado(out sexo);
            this.dgvLista.DataSource = listaAux;

            this.lblInforme.Text = $"El genero {sexo} es el mas afectado por la desocupacion";
            this.lblSubTitulo.Text = $"Lista de persona del genero {sexo}";
        }

        private void btnExportarCsv_Click(object sender, EventArgs e)
        {
            ExportarInfo.ExportarDatos<Desocupado>(listaAux, txtNombreArchivo.Text);
            
        }
    }
}
