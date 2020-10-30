using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea5_OscarMancia.Clases
{
    class Litros
    {
        public void MsgWarnig(String msg)
        {
            MessageBox.Show(msg, "ATENTION",MessageBoxButtons.OK , MessageBoxIcon.Error);
        }

        public void AlertNotNumber(string str)
        {
            double x;
            if (!double .TryParse (str , out x))
            {
                MsgWarnig("EL VALOR DEBE SER NUMERICO");
            }
        }

        public string CheckIfIsNumber(string str)
        {
            string resp = "";
            double x;
            if (double .TryParse (str , out x ))
            {
                resp = "S";
            }else
            {
                resp = "N";
            }

            return resp;
        }

        public double Calcular(double h, double l)
        {
            double litros;
            litros = (h*l) * 1000;
            return litros;
        }

    }
}
