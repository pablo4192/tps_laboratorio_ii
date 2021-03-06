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
    public partial class FrmMenuPrincipal : Form
    {
        

        public FrmMenuPrincipal()
        {
            InitializeComponent();
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Levanto datos de los archivos xml en el bin
            //Censo<Trabajador>.LeerDatosXml();
            //Censo<Estudiante>.LeerDatosXml();
            //Censo<Estudiante_Trabajador>.LeerDatosXml();
            //Censo<Jubilado>.LeerDatosXml();
            //Censo<Desocupado>.LeerDatosXml();

            //Levanto los datos de la base de datos Censo!
            Censo<Trabajador>.CargarInfoDb();
            Censo<Estudiante>.CargarInfoDb();
            Censo<Estudiante_Trabajador>.CargarInfoDb();
            Censo<Jubilado>.CargarInfoDb();
            Censo<Desocupado>.CargarInfoDb();


        }

        private void btnInformes_Click(object sender, EventArgs e)
        {
            FrmInformes frmInformes = new FrmInformes();
            frmInformes.Show();
            this.Hide();
        }

        private void btnIngresarDatos_Click(object sender, EventArgs e)
        {
            FrmAlta frmAlta = new FrmAlta();
            frmAlta.Show();
            this.Hide();
        }
    }
}
