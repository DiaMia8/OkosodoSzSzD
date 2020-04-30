using OkosodoLibrary;
using OkosodoLibrary.DataAccess;
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
    public partial class AdminMenuForm : Form
    {
        public static int belepettAdminId;

        private static AdminModel bejelentkezett = GlobalConfig.Connection.GetOne_Admin(belepettAdminId);
        
        private List<TanuloModel> tanulok = GlobalConfig.Connection.GetTanuloByAdminId(bejelentkezett.Id);

        
        public AdminMenuForm()
        {
            
            InitializeComponent();
           
            DiakListaFeltoltes();
            Udvozlet();
        }

        private void Udvozlet()
        {
            udvozloNevLabel.Text = $"{bejelentkezett.KeresztNev.ToString()} !";
        }

        private void DiakListaFeltoltes()
        {
            //új diák létrehozása után frissíti a listBox elemeit
            diakListBox.DataSource = null;

            diakListBox.DataSource = tanulok;
            diakListBox.DisplayMember = "Becenev";

        

        }

        private void ujDiakRegisztralasButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                TanuloModel model = new TanuloModel(
                    ujDiakVezetekNevTextBox.Text,
                    ujDiakKeresztNevTextBox.Text,
                    ujDiakBecenevTextBox.Text,
                    ujDiakSzuloNeveTextBox.Text,
                    ujDiakSzuloEmailTextBox.Text,
                    ujDiakSzuletesiDatumdateTimePicker.Value,
                    1);

                GlobalConfig.Connection.CreateTanulo(model, bejelentkezett.Id);
                
                // ha lementette az adatokat, kitörli a korábban bevitt adatokat
                ujDiakVezetekNevTextBox.Text = "";
                ujDiakKeresztNevTextBox.Text = "";
                ujDiakBecenevTextBox.Text = "";
                ujDiakSzuloNeveTextBox.Text = "";
                ujDiakSzuloEmailTextBox.Text = "";
                ujDiakSzuletesiDatumdateTimePicker.Text = "";

                tanulok.Add(model);
                //diakListBox.Refresh();
            }
            else
            {
                MessageBox.Show("Hiányos kitöltés vagy hibás kitöltés! Kérlek ellenőrizd a bevitt adatokat!");
            }

            DiakListaFeltoltes();
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
