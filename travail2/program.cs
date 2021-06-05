using System;
using System.Windows.Forms;

namespace travail2
{
    public static class program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        public static void Main ()
        {
            Application.EnableVisualStyles ();
            Application.SetCompatibleTextRenderingDefault (false);
            Application.Run (new FenetrePrincipale ());
        }
    }
}
