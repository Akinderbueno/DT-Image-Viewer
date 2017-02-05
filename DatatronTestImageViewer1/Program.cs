using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatatronTestImageViewer1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DTImageViewer DTI = new DTImageViewer();
            DTI.Text = "Datatron 2017";
            Application.Run(DTI);
        }
    }
}
