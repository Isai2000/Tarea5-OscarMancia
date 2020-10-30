using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea5_OscarMancia.Clases
{
    class Estudiante
    {
        public void MsgWarnig(string msg)
        {
            MessageBox.Show(msg , "ATENTION",MessageBoxButtons.OK , MessageBoxIcon.Error);
        }

        public void Alert(string str)
        {
            double x;
            if (!double .TryParse (str ,out x))
            {
                MsgWarnig("SOLO SE ADMITEN DATOS NUMERICOS");
            }
        }

        public string Check(string str)
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


        public double Resultado(double e1, double e2, double e3)
        {
            double resultado;
            resultado = 65 - (e1 + e2 + e3);
            return resultado;
        }

    }
}
