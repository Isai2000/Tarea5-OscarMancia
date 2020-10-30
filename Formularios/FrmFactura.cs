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
    public partial class FrmFactura : Form
    {
        Clases.Factura frigio = new Clases.Factura();
        double total = 0.0;
        public FrmFactura()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TxtCode .Text .Trim().Length == 0)
            {
                frigio.MsgWarnig("LA INFORMACION ES REQUERIDA");
                TxtCode.Focus();
                return;
            }
            if (TxtProducto.Text.Trim().Length == 0)
            {
                frigio.MsgWarnig("LA INFORMACION ES REQUERIDA");
                TxtProducto.Focus();
                return;
            }
            if (TxtDescrip.Text.Trim().Length == 0)
            {
                frigio.MsgWarnig("LA INFORMACION ES REQUERIDA");
                TxtDescrip.Focus();
                return;
            }
            if (TxtCant.Text.Trim().Length == 0)
            {
                frigio.MsgWarnig("LA INFORMACION ES REQUERIDA");
                TxtCant.Focus();
                return;
            }
            if (TxtPrecu.Text.Trim().Length == 0)
            {
                frigio.MsgWarnig("LA INFORMACION ES REQUERIDA");
                TxtPrecu.Focus();
                return;
            }

            if (frigio .Check (TxtCant .Text .Trim())=="N")
            {
                frigio.MsgWarnig("DATOS ERRONEOS");
                TxtCant.Focus();
                return;
            }
            if (frigio .Check (TxtPrecu .Text .Trim ())== "N")
            {
                frigio.MsgWarnig("DATOS ERRONEOS");
                TxtPrecu.Focus();
                return;
            }
            double totalp,isv,cant, precu;
            string code, producto, descrip;
            code = TxtCode.Text.Trim();
            producto = TxtProducto.Text.Trim();
            descrip = TxtDescrip.Text.Trim();
            cant = Convert.ToInt32(TxtCant .Text .Trim ());
            precu = Convert.ToInt32(TxtPrecu .Text .Trim ());

            ClearFomr();

            DtgDatos.Rows.Add(code , producto , descrip , cant , precu , (cant * precu));
            
            
            total += frigio .Total (cant, precu );
            isv = total * 0.15;
            totalp = total + isv;
            TxtSub.Text = total.ToString();
            TxtISV.Text = isv.ToString();
            TxtTotal.Text = totalp.ToString();
            

        }

        private void ClearFomr()
        {
            foreach (TextBox txt in this.Controls.OfType<TextBox>())
            {
                txt.Clear();
            }

            TxtCode.Focus();
        }

        private void TxtCant_TextChanged(object sender, EventArgs e)
        {
            if (TxtCant .Text .Trim ().Length >0)
            {
                frigio.Alert(TxtCant .Text .Trim());
            }
        }

        private void TxtPrecu_TextChanged(object sender, EventArgs e)
        {
            if (TxtPrecu.Text.Trim().Length > 0)
            {
                frigio.Alert(TxtPrecu.Text.Trim());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           foreach (TextBox txt in this.Controls.OfType<TextBox>())
           {
                txt.Clear();
           }
            DtgDatos.Rows.Clear();
            TxtCode.Focus();            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
