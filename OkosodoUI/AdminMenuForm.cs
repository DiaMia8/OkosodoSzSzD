using OkosodoLibrary;
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
    public partial class AdminMenuForm : Form
    {
        public AdminMenuForm()
        {
            InitializeComponent();
        }

        private void ujFelhasznaloRegisztralasButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                TanuloModel model = new TanuloModel(
                    ujDiakVezetekNevTextBox.Text,
                    ujDiakKeresztNevTextBox.Text,
                    ujDiakBecenevTextBox.Text,
                    ujDiakSzuloNeveTextBox.Text,
                    ujDiakSzuloEmailTextBox.Text,
                    ujDiakSzuletesiDatumdateTimePicker.Value);

                foreach (IDataConnection db in GlobalConfig.Connections)
                {
                    db.CreateTanulo(model);
                }
                // ha lementette az adatokat, kitörli a korábban bevitt adatokat
                ujDiakVezetekNevTextBox.Text = "";
                ujDiakKeresztNevTextBox.Text = "";
                ujDiakBecenevTextBox.Text = "";
                ujDiakSzuloNeveTextBox.Text = "";
                ujDiakSzuloEmailTextBox.Text = "";
                ujDiakSzuletesiDatumdateTimePicker.Text = "";


            }
            else
            {
                MessageBox.Show("Hiányos kitöltés!");
            }
        }

        private bool ValidateForm()
        {
            // TODO - Rendes validálást megcsinálni.
            bool output = true;

            if (ujDiakVezetekNevTextBox.Text.Length == 0)
            {
                return false;
            }
            if (ujDiakKeresztNevTextBox.Text.Length == 0)
            {
                return false;
            }
            if (ujDiakBecenevTextBox.Text.Length == 0)
            {
                return false;
            }
            if (ujDiakSzuloNeveTextBox.Text.Length == 0)
            {
                return false;
            }
            if (ujDiakSzuloEmailTextBox.Text.Length == 0)
            {
                return false;
            }
            if (ujDiakSzuletesiDatumdateTimePicker.Text.Length == 0)
            {
                return false;
            }

            return output;
        }
    }
}
