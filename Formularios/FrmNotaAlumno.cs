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
    public partial class FrmNotaAlumno : Form
    {
        Clases.NotaAlumno mixolidio = new Clases.NotaAlumno();
        int prom = 0;
        int ap = 0;
        int rp = 0;
        public FrmNotaAlumno()
        {
            InitializeComponent();
        }

        private void FrmNotaAlumno_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TxtNombre .Text .Trim ().Length == 0)
            {
                mixolidio.MsgWarnig("ES NECESARIO LLENAR LA INFORMACION");
                TxtNombre.Focus();
                return;
            }
            if (TxtCal1.Text.Trim().Length == 0)
            {
                mixolidio.MsgWarnig("ES NECESARIO LLENAR LA INFORMACION");
                TxtCal1.Focus();
                return;
            }
            if (TxtCal2.Text.Trim().Length == 0)
            {
                mixolidio.MsgWarnig("ES NECESARIO LLENAR LA INFORMACION");
                TxtCal2.Focus();
                return;
            }
            if (TxtCal3.Text.Trim().Length == 0)
            {
                mixolidio.MsgWarnig("ES NECESARIO LLENAR LA INFORMACION");
                TxtCal3.Focus();
                return;
            }
            if (TxtCal4.Text.Trim().Length == 0)
            {
                mixolidio.MsgWarnig("ES NECESARIO LLENAR LA INFORMACION");
                TxtCal4.Focus();
                return;
            }
            
            if (mixolidio .Check (TxtCal1 .Text .Trim ())=="N")
            {
                mixolidio.MsgWarnig("DATOS ERRONEOS");
                TxtCal1.Focus();
                return;
            }
            if (mixolidio.Check(TxtCal2.Text.Trim()) == "N")
            {
                mixolidio.MsgWarnig("DATOS ERRONEOS");
                TxtCal2.Focus();
                return;
            }
            if (mixolidio.Check(TxtCal3.Text.Trim()) == "N")
            {
                mixolidio.MsgWarnig("DATOS ERRONEOS");
                TxtCal3.Focus();
                return;
            }
            if (mixolidio.Check(TxtCal4.Text.Trim()) == "N")
            {
                mixolidio.MsgWarnig("DATOS ERRONEOS");
                TxtCal4.Focus();
                return;
            }
            int n1, n2, n3, n4, rest;
            string nombre;
            nombre = TxtNombre.Text.Trim();
            n1 = Convert.ToInt16(TxtCal1 .Text .Trim ());
            n2 = Convert.ToInt16(TxtCal2 .Text .Trim ());
            n3 = Convert.ToInt16(TxtCal3 .Text .Trim ());
            n4 = Convert.ToInt16(TxtCal4.Text.Trim());    
            ClearFomr();

            DtvDatos.Rows.Add(nombre , n1 , n2 , n3 , n4, (n1 + n2 + n3 + n4 )/ 4);
                       
            prom += mixolidio .Nota (n1,n2 , n3 , n4);
            rest = prom / DtvDatos.Rows.Count;
            
            TxtPromGen.Text = rest .ToString ();
            
            if (mixolidio .Nota (n1,n2,n3,n4) >=65)
            {
                ap++;
            }else
            {
                rp++;
            }

            TxtAprobado.Text = ap.ToString ();
            TxtReprobado.Text = rp.ToString();
        }

        private void ClearFomr()
        {
            foreach (TextBox txt in this.Controls.OfType<TextBox>())
            {
                txt.Clear();
            }

            
            TxtNombre .Focus();
        }


        private void TxtCal1_TextChanged(object sender, EventArgs e)
        {
            if (TxtCal1 .Text .Trim ().Length >0)
            {
                mixolidio.Alert(TxtCal1 .Text .Trim ());
            }
        }

        private void TxtCal2_TextChanged(object sender, EventArgs e)
        {
            if (TxtCal2.Text.Trim().Length > 0)
            {
                mixolidio.Alert(TxtCal2.Text.Trim());
            }
        }

        private void TxtCal3_TextChanged(object sender, EventArgs e)
        {
            if (TxtCal3.Text.Trim().Length > 0)
            {
                mixolidio.Alert(TxtCal3.Text.Trim());
            }
        }

        private void TxtCal4_TextChanged(object sender, EventArgs e)
        {
            if (TxtCal4.Text.Trim().Length > 0)
            {
                mixolidio.Alert(TxtCal4.Text.Trim());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (TextBox Txt in this .Controls .OfType <TextBox >())
            {
                Txt.Clear();
            }
            DtvDatos.Rows.Clear();
            TxtNombre.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
