using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea5_OscarMancia.Clases
{
    class NotaAlumno
    {
        public void MsgWarnig(String msg)
        {
            MessageBox.Show(msg , "ATENTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void Alert(string str)
        {
            double x;
            if (!double .TryParse (str ,out x ))
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


        public int Nota(int n1, int n2, int n3, int n4)
        {
            int nota;
            nota = (n1 + n2 + n3 + n4) / 4;
            return nota;
        }


    }
}
