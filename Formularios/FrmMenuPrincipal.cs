using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea5_OscarMancia.Formularios
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void BtnPorcent_Click(object sender, EventArgs e)
        {
            Formularios.FrmPorcentaje light = new Formularios.FrmPorcentaje();
            light.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Formularios.FrmLitrosdeAgua red = new Formularios.FrmLitrosdeAgua();
            red.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Formularios.FrmCalcular oragne = new Formularios.FrmCalcular();
            oragne.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Formularios.FrmNotaAlumno green = new Formularios.FrmNotaAlumno();
            green.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Formularios.FrmFactura yellow = new Formularios.FrmFactura();
            yellow.ShowDialog();
        }
    }
}
