using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Nishiguchi {
    public partial class MainMenu : Form {
        public MainMenu() {
            InitializeComponent();
        }

        private void AddQuoteButton_Click(object sender, EventArgs e) {
            AddQuote addNewQuoteForm = new AddQuote();
            addNewQuoteForm.Tag = this;
            addNewQuoteForm.Show(this);
            Hide();
        }

        private void ViewQuoteButton_Click(object sender, EventArgs e) {
            DisplayQuotes addNewViewQuoteForm = new DisplayQuotes();
            addNewViewQuoteForm.Tag = this;
            addNewViewQuoteForm.Show(this);
            Hide();
        }

        private void SearchQuoteButton_Click(object sender, EventArgs e) {
            SearchQuotes addNewSearchQuotesForm = new SearchQuotes();
            addNewSearchQuotesForm.Tag = this;
            addNewSearchQuotesForm.Show(this);
            Hide();
        }

        private void ExitButton_Click(object sender, EventArgs e) {
            Close();
            Application.Exit();
        }
    }
}
