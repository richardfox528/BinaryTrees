using BinaryTrees.Properties;
using BinaryTrees.Scenario2;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BinaryTrees
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogin());

            //Application.Run(new FormScenario2());
        }
    }
}
