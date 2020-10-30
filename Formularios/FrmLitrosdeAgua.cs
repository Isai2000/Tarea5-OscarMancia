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
    public partial class FrmLitrosdeAgua : Form
    {
        Clases.Litros jonico = new Clases.Litros();
        public FrmLitrosdeAgua()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TxtAltura .Text .Trim ().Length ==0)
            {
                jonico.MsgWarnig("EL CAMPO ES REQUERIDO");
                TxtAltura.Focus();
                return;
            }
            if (jonico .CheckIfIsNumber (TxtAltura .Text .Trim ())=="N")
            {
                jonico.MsgWarnig("ERROR AL PROCESAR");
                TxtAltura.Focus();
                return;
            }
            if (jonico.CheckIfIsNumber(TxtLongitud.Text.Trim()) == "N")
            {
                jonico.MsgWarnig("ERROR AL PROCESAR");
                TxtLongitud.Focus();
                return;
            }
            double h, l;
            h = Convert.ToDouble(TxtAltura .Text .Trim ());
            l = Convert.ToDouble(TxtLongitud .Text .Trim ());

            TxtMostrar.Text = "En el tanque caben " + jonico.Calcular(h,l).ToString () + " Litros";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtAltura.Clear();
            TxtLongitud.Clear();
            TxtMostrar.Clear();
            TxtAltura.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TxtAltura_TextChanged(object sender, EventArgs e)
        {
            if (TxtAltura .Text .Trim ().Length >0)
            {
                jonico.AlertNotNumber(TxtAltura .Text .Trim ());
            }
        }

        private void TxtLongitud_TextChanged(object sender, EventArgs e)
        {
            if (TxtLongitud.Text.Trim().Length > 0)
            {
                jonico.AlertNotNumber(TxtLongitud.Text.Trim());
            }
        }
    }
}
