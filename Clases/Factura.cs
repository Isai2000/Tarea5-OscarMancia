using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea5_OscarMancia.Clases
{
    class Factura
    {
        public void MsgWarnig(string msg)
        {
            MessageBox.Show(msg , "ATENTION", MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        public void Alert(string str)
        {
            double x;
            if (!double .TryParse (str, out x))
            {
                MsgWarnig("EL VALOR DEBE SER NUMERICO");
            }
        }

        public string Check(string str)
        {
            string resp = "";
            double x;
            if (double .TryParse (str ,out x))
            {
                resp = "S";
            }else
            {
                resp = "N";
            }

            return resp;
        }

        
        public double Total(double cant, double precu)
        {
            double total;
            total = cant * precu;
            return total;
        }
    }
}
