using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea5_OscarMancia.Clases
{
    class Porcentaje
    {
        public void MsgWarning(String msg)
        {
            MessageBox.Show(msg , "ATENTION", MessageBoxButtons.OK,MessageBoxIcon.Warning );
        }

        public void AlertNotNumber(String str)
        {
            double x;
            if (!double .TryParse (str , out x))
            {
                MsgWarning("EL VALOR DEBE SER NUMERICO");
            }
        }

        public string CheckIfIsNumber(string str)
        {
            string resp = "";
            double x;
            if (double .TryParse (str , out x))
            {
                resp = "S";
            }else
            {
                resp = "N";
            }

            return resp;
        }


        
        public double Mostrar(double costo, double venta)
        {
            double Porcentaje;
            Porcentaje = venta - costo;
            return Porcentaje;
        }
    }
}
