using System;
using System.Windows.Forms;

namespace HaromszogekKoordinataRendszerben
{
    static class Program
    {
        /// <summary>
        /// Az alkalmaz�s bel�p�si pontja.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Magas DPI m�d enged�lyez�se a jobb felbont�s t�mogat�s�ra
            Application.SetHighDpiMode(HighDpiMode.SystemAware);

            // Vizu�lis st�lusok enged�lyez�se az alkalmaz�shoz
            Application.EnableVisualStyles();

            // Sz�vegrenderel�s kompatibilit�s be�ll�t�sa
            Application.SetCompatibleTextRenderingDefault(false);

            // Form1 (a f� ablak) elind�t�sa
            Application.Run(new Form1());
        }
    }
}
