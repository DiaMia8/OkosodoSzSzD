using OkosodoLibrary;
using OkosodoLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkosodoUI
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void ujFelhasznaloRegisztralasButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                AdminModel model = new AdminModel(
                    ujFelhasznaloVezetekNevTextBox.Text,
                    ujFelhasznaloKeresztNevTextBox.Text,
                    ujFelhasznaloEmailTextBox.Text,
                    ujFelhasznaloJelszoTextBox.Text
                    );


                GlobalConfig.Connection.CreateAdmin(model);
                // adatmentés után törli az adatokat

                ujFelhasznaloVezetekNevTextBox.Text = "";
                ujFelhasznaloKeresztNevTextBox.Text = "";
                ujFelhasznaloEmailTextBox.Text = "";
                ujFelhasznaloJelszoTextBox.Text = "";

            }
            else
            {
                MessageBox.Show("Hiányos kitöltés, kérlek ellenőrizd az adatokat!");
            }
        }

        private bool ValidateForm()
        {
            //TODO - Rendes validálást megcsinálni
            bool output = true;

           
            if (ujFelhasznaloVezetekNevTextBox.Text.Length == 0)
            {
                return false;
            }
            if (ujFelhasznaloKeresztNevTextBox.Text.Length == 0)
            {
                return false;
            }
            if (ujFelhasznaloEmailTextBox.Text.Length == 0)
            {
                return false;
            }
            if (ujFelhasznaloJelszoTextBox.Text.Length == 0)
            {
                return false;
            }

            return output;
        }
    }
}
