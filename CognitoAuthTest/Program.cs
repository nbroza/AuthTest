using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BigBoyPrototype
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        
        public static Home home = new Home();
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();


            LogIn logIn = new LogIn();
            Point loginPoint = new Point(282, 106);

            logIn.Location = loginPoint;
            logIn.Show();
            home.Controls.Add(logIn);

            home.ShowDialog();
        }
    }
}
