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
    public partial class AddQuote : Form {

        //initialize Error Providers
         //   private System.Windows.Forms.ErrorProvider textWidthErrorProvider;
         //   private System.Windows.Forms.ErrorProvider textDepthErrorProvider;

        public AddQuote() {
            InitializeComponent();
        }

        private void backToMain_Click(object sender, EventArgs e) {
            MainMenu  mainMenuForm = new MainMenu();
            mainMenuForm.Tag = this;
            mainMenuForm.Show(this);
            Hide();
        }

        private void submit_Click(object sender, EventArgs e) {

            try {
                DeskQuote deskQuote = new DeskQuote();
                Desk desk = new Desk();
                List<DeskQuote> deskQuotes = Program.DeskQuotes;


                desk.Width = float.Parse(widthInput.Text);
                desk.Depth = float.Parse(depthInput.Text);
                desk.getArea();

                desk.DrawerNumber = int.Parse(drawerNumberInput.SelectedItem.ToString());
                desk.Material = materialInput.SelectedItem.ToString();
                desk.ShippingDays = int.Parse(shippingDaysInput.SelectedItem.ToString());

                deskQuote.Desk = desk;
                deskQuotes.Add(deskQuote);
                Program.DeskQuotes = deskQuotes;

                //navigate to view quotes
                DisplayQuotes addNewViewQuoteForm = new DisplayQuotes();
                addNewViewQuoteForm.Tag = this;
                addNewViewQuoteForm.Show(this);
                Hide();

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);

            }
        }

        private void widthInput_Validating(object sender, CancelEventArgs e) {

        }

        private void depthInput_Validating(object sender, CancelEventArgs e) {


            /*
            int fieldValue;
            //Check to see if user entered a valid integer value
            if (int.TryParse(depthInput.Text, out fieldValue)) {
                //The value is an integer
                if (fieldValue < 12 || fieldValue > 48) {
                    this.depthInput.Select(0, depthInput.Text.Length);

                    textDepthErrorProvider.SetError(this.depthInput, "Must be  between 12 and 48");
                }
                else {
                    textDepthErrorProvider.SetError(this.depthInput, String.Empty);
                }
            }
            else {
                //The value is not an integer

                textDepthErrorProvider.SetError(this.depthInput, "Not a valid integer.");
            }
            */

        }
    }
}
