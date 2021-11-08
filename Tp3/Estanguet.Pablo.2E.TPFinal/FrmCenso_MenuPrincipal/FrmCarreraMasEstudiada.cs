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
    public partial class FrmCarreraMasEstudiada : FrmBase
    {
        List<Estudiante> listaEstudiantes;
        List<string> carreras;
        

        public FrmCarreraMasEstudiada()
        {
            InitializeComponent();
            listaEstudiantes = new List<Estudiante>();
            carreras = new List<string>();
            
        }

        private void FrmCarreraMasEstudiada_Load(object sender, EventArgs e)
        {
            this.lblTitulo.Text = "Carrera mas estudiada";
            this.lblSubTitulo.Text = $"Listado de personas que estudian la carrera ";

            listaEstudiantes.AddRange(Censo<Estudiante>.Registros);
            listaEstudiantes.AddRange(Censo<Estudiante_Trabajador>.Registros);

            listaEstudiantes = Censo<Estudiante>.Filtrar_CarreraMasEstudiada(listaEstudiantes, out carreras);
            
            dgvLista.DataSource = listaEstudiantes;

            lblInforme.Text = "La o las carreras mas estudiadas son: ";
            foreach (string item in carreras)
            {
                lblInforme.Text += $"{item}, ";
                lblSubTitulo.Text += $"{item}, ";
            }

            
        }

        private void btnExportarCsv_Click(object sender, EventArgs e)
        {
            this.lblSoloLetras.Visible = false;

            if (!string.IsNullOrEmpty(txtNombreArchivo.Text) && FrmInformes.VerificarNombreArchivo(txtNombreArchivo.Text))
            {
                Censo<Estudiante>.ExportarDatosEstudiantes_Csv(listaEstudiantes, txtNombreArchivo.Text);
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
