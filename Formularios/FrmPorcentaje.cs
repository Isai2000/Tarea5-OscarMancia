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
    public partial class FrmPorcentaje : Form
    {
        Clases.Porcentaje Dorico = new Clases.Porcentaje();
        public FrmPorcentaje()
        {
            InitializeComponent();
        }


        private void BtnCalc_Click(object sender, EventArgs e)
        {
            if (TxtDescrip .Text .Trim ().Length == 0)
            {
                Dorico.MsgWarning("EL CAMPO ES REQUERIDO");
                TxtDescrip.Focus();
                return;
            }
            if (TxtCosto .Text .Trim ().Length == 0)
            {
                Dorico.MsgWarning("EL CAMPO ES REQUERIDO");
                TxtCosto.Focus();
                return;
            }
            if (TxtVenta .Text .Trim ().Length == 0)
            {
                Dorico.MsgWarning("EL CAMPO ES REQUERIDO");
                TxtVenta.Focus();
                return;
            }
            if (Dorico .CheckIfIsNumber (TxtCosto .Text .Trim ())=="N")
            {
                Dorico.MsgWarning("ERROR AL PROCESAR DATOS");
                TxtCosto.Focus();
                return;
            }
            if (Dorico.CheckIfIsNumber(TxtVenta.Text.Trim()) == "N")
            {
                Dorico.MsgWarning("ERROR AL PROCESAR DATOS");
                TxtVenta.Focus();
                return;
            }

            double costo, venta;
            string nombre;
            nombre = TxtDescrip.Text.Trim();
            costo = Convert.ToDouble(TxtCosto .Text .Trim ());
            venta = Convert.ToDouble(TxtVenta .Text .Trim ());


           TxtMostrar .Text = nombre + " Ganancia: " + Dorico .Mostrar(costo ,venta ).ToString ();
        }

        private void FrmPorcentaje_Load(object sender, EventArgs e)
        {

        }

        private void TxtCosto_TextChanged(object sender, EventArgs e)
        {
            if (TxtCosto .Text .Trim ().Length > 0)
            {
                Dorico.AlertNotNumber(TxtCosto .Text .Trim ());
            }
        }

        private void TxtVenta_TextChanged(object sender, EventArgs e)
        {
            if (TxtVenta.Text.Trim().Length > 0)
            {
                Dorico.AlertNotNumber(TxtVenta.Text.Trim());
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            foreach (TextBox limp in this .Controls .OfType <TextBox>())
            {
                limp.Clear();
            }
            TxtDescrip.Focus();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
