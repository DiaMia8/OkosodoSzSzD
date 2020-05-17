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


        private AdminModel bejelentkezett;

        private List<TanuloModel> tanulok;

        
        public AdminMenuForm(int adminId)
        {
            bejelentkezett = GlobalConfig.Connection.GetOne_Admin(adminId);
            tanulok = GlobalConfig.Connection.GetTanuloByAdminId(bejelentkezett.Id);

            InitializeComponent();
            
            Udvozlet();
            DiakListaFeltoltes();

            
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
                
            }
            else
            {
                MessageBox.Show("Hiányos kitöltés vagy hibás kitöltés! Kérlek ellenőrizd a bevitt adatokat!", "Figyelmeztetés!", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

            DiakListaFeltoltes();
        }

        private bool ValidateForm()
        {
           
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

            if (ValidEmail(ujDiakSzuloEmailTextBox.Text) == false)
            {
                return false;
            }

            if (ujDiakSzuletesiDatumdateTimePicker.Text.Length == 0)
            {
                return false;
            }

            return output;
        }

        private bool ValidEmail(string value)
        {
            bool output = false;

            if (value.Contains("@") && value.Length - value.LastIndexOf('.') < 5 && value.LastIndexOf('@') < value.LastIndexOf('.'))
            {
                output = true;
            }

            return output;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            MainMenuForm frm = new MainMenuForm();
            frm.Show();
            this.Close();
        }

        private void diakBeleptetesButton_Click(object sender, EventArgs e)
        {
            TanuloModel kivalasztott = (TanuloModel)diakListBox.SelectedItem;

            int kivalasztottId = kivalasztott.Id;

            DiakMenuForm frm = new DiakMenuForm(kivalasztottId, bejelentkezett.Id);
            frm.Show();
            this.Hide();
        }

        private void statisztikaButton_Click(object sender, EventArgs e)
        {
            TanuloModel kivalasztott = (TanuloModel)diakListBox.SelectedItem;

            int kivalasztottId = kivalasztott.Id;

            bool vanMegoldottFeladata = GlobalConfig.Connection.VanMegoldottFeladat(kivalasztottId);


            if (vanMegoldottFeladata == true && kivalasztottId != 0)
            {
                StatisztikaModel statisztika = new StatisztikaModel(
                      GlobalConfig.Connection.GetDiakBeceNev(kivalasztottId),
                      GlobalConfig.Connection.GetOsszesMegoldott(kivalasztottId),
                      GlobalConfig.Connection.GetOsszesMegoldottMatematikai(kivalasztottId),
                      GlobalConfig.Connection.GetOsszesHelyesMatematikai(kivalasztottId),
                      GlobalConfig.Connection.GetOsszesMegoldottAbc(kivalasztottId),
                      GlobalConfig.Connection.GetHelyesAbc(kivalasztottId),
                      GlobalConfig.Connection.GetOsszPontSzam(kivalasztottId));

                textBoxOsszMegoldott.Text = statisztika.OsszesMegoldott.ToString();
                textBoxHelyesMatek.Text = $"{statisztika.OsszesMegoldottMatematikai} / {statisztika.OsszesHelyesMatematikai}";
                textBoxHelyesAbc.Text = $"{statisztika.OsszesMegoldottAbc} / {statisztika.OsszesHelyesAbc}";
                textBoxOsszpont.Text = statisztika.OsszPontSzam.ToString(); 
            }
            else
            {
                MessageBox.Show("Még nem oldott meg feladatot a kiválsztott diák!", "Információ", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);

                textBoxOsszMegoldott.Text = "";
                textBoxHelyesMatek.Text = "";
                textBoxHelyesAbc.Text = "";
                textBoxOsszpont.Text = "";
            }
        }
    }
}
