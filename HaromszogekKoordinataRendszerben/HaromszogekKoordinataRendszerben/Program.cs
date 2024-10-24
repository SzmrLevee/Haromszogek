using System;
using System.Windows.Forms;

namespace HaromszogekKoordinataRendszerben
{
    static class Program
    {
        /// <summary>
        /// Az alkalmazás belépési pontja.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Magas DPI mód engedélyezése a jobb felbontás támogatására
            Application.SetHighDpiMode(HighDpiMode.SystemAware);

            // Vizuális stílusok engedélyezése az alkalmazáshoz
            Application.EnableVisualStyles();

            // Szövegrenderelés kompatibilitás beállítása
            Application.SetCompatibleTextRenderingDefault(false);

            // Form1 (a fõ ablak) elindítása
            Application.Run(new Form1());
        }
    }
}
