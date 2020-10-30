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
    public partial class FrmCalcular : Form
    {
        Clases.Estudiante eolico = new Clases.Estudiante();
       
        public FrmCalcular()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TxtNombre .Text .Trim ().Length == 0)
            {
                eolico.MsgWarnig("EL NOMBRE ES NECESARIO");
                TxtNombre.Focus();
                return;
            }
            if (TxtE1 .Text .Trim ().Length == 0)
            {
                eolico.MsgWarnig("LA NOTA DEL PRIMER EXAMEN ES NECESARIO");
                TxtE1.Focus();
                return;
            }
            if (TxtE2 .Text .Trim ().Length == 0)
            {
                eolico.MsgWarnig("LA NOTA DEL SEGUNDO EXAMEN ES NECESARIO");
                TxtE2.Focus();
                return;
            }
            if (TxtE3 .Text .Trim ().Length == 0)
            {
                eolico.MsgWarnig("LA NOTA DEL TERCER EXAMEN ES NECESARIO");
                TxtE3.Focus();
                return;
            }

            if (eolico .Check (TxtE1 .Text .Trim())== "N")
            {
                eolico.MsgWarnig("ERROR AL PROCESAR");
                TxtE1.Focus();
                return;
            }
            if (eolico.Check(TxtE2.Text.Trim()) == "N")
            {
                eolico.MsgWarnig("ERROR AL PROCESAR");
                TxtE2.Focus();
                return;
            }
            if (eolico.Check(TxtE3.Text.Trim()) == "N")
            {
                eolico.MsgWarnig("ERROR AL PROCESAR");
                TxtE3.Focus();
                return;
            }


            double examen1, examen2, examen3;
            string estudiante;
            estudiante = TxtNombre.Text.Trim();
            examen1 = Convert.ToDouble(TxtE1 .Text .Trim ());
            examen2 = Convert.ToDouble(TxtE2 .Text .Trim ());
            examen3 = Convert.ToDouble(TxtE3 .Text .Trim ());

            TxtNameMostrar.Text = estudiante;
            TxtResultado.Text = "El estudiante necesita " + eolico.Resultado(examen1, examen2, examen3).ToString() + " puntos para poder aprobar la clase "; 

        }

        private void TxtE1_TextChanged(object sender, EventArgs e)
        {
            if (TxtE1 .Text .Trim ().Length >0)
            {
                eolico.Alert(TxtE1 .Text .Trim ());
            }


        }

        private void TxtE2_TextChanged(object sender, EventArgs e)
        {
            if (TxtE2.Text.Trim().Length >0)
            {
                eolico.Alert(TxtE2.Text.Trim());
            }
        }

        private void TxtE3_TextChanged(object sender, EventArgs e)
        {
            if (TxtE3.Text.Trim().Length >0)
            {
                eolico.Alert(TxtE3.Text.Trim());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (TextBox txt in this .Controls .OfType <TextBox >())
            {
                txt .Clear ();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
