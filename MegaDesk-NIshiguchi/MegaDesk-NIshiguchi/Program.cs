using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Nishiguchi {
    static class Program {

        private static List<DeskQuote> deskQuotes = new List<DeskQuote>();

        internal static List<DeskQuote> DeskQuotes { get => deskQuotes; set => deskQuotes = value; }

        enum AttributeOrder {
            width = 0,
            depth = 1,
            area = 2,
            material = 3,
            prodTime = 4
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenu());
        }
    }
}
