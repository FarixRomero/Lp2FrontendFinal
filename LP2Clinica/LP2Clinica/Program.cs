﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2Clinica
{
    internal static class Program
    {
        [STAThread]
        /*
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(true);

            Application.Run(new frmInicio());

        }
        */


        

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmInicio comienzo = new frmInicio();
            comienzo.FormClosed += INICIO_Closed;
            comienzo.Show();
            Application.Run();
        }
        private static void INICIO_Closed(object sender, FormClosedEventArgs e)
        {
            ((Form)sender).FormClosed -= INICIO_Closed;

            if (Application.OpenForms.Count == 0)
            {
                Application.ExitThread();
            }
            else
            {
                Application.OpenForms[0].FormClosed += INICIO_Closed;
            }
        }

    }
}
