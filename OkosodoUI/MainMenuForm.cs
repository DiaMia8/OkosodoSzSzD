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
                    ujFelhasznaloNevTextBox.Text,
                    ujFelhasznaloVezetekNevTextBox.Text,
                    ujFelhasznaloKeresztNevTextBox.Text,
                    ujFelhasznaloEmailTextBox.Text,
                    ujFelhasznaloJelszoTextBox.Text
                    );


                GlobalConfig.Connection.CreateAdmin(model);
                // adatmentés után törli az adatokat

                ujFelhasznaloNevTextBox.Text = "";
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

            if (ujFelhasznaloNevTextBox.Text.Length == 0)
            {
                return false;
            }
            if (ujFelhasznaloVezetekNevTextBox.Text.Length == 0)
            {
                return false;
            }
            if (ujFelhasznaloKeresztNevTextBox.Text.Length == 0)
            {
                return false;
            }
            if (ujFelhasznaloEmailTextBox.Text.Length == 0 )
            {
                return false;
            }
            if (ValidEmail(ujFelhasznaloEmailTextBox.Text) == false)
            {
                return false;
            }
            if (ujFelhasznaloJelszoTextBox.Text.Length == 0)
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

        private void belepesButton_Click(object sender, EventArgs e)
        {
            if (ValidateLogin())
            {
            int belepettId = GlobalConfig.Connection.LoginAdmin(nevTextBox.Text, jelszoTextBox.Text);
                

                if (belepettId == 0)
                {
                    MessageBox.Show("Hibás felhasználó név vagy jelszó, kérlek próbáld újra!", "Figyelmeztetés!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    
                    jelszoTextBox.Text = "";
                }
                else
                {
                    AdminMenuForm f = new AdminMenuForm(belepettId);
                    f.Show();

                    this.Hide();
                    
                }
            }
            else
            {
                MessageBox.Show("Hibás felhasználó név vagy jelszó, kérlek próbáld újra!", "Figyelmeztetés!", MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
                nevTextBox.Text = " ";
                jelszoTextBox.Text = " ";
            }
        }

        private bool ValidateLogin()
        {
            bool output = true;

            if (nevTextBox.Text.Length == 0)
            {
                return false;
            }
            if (jelszoTextBox.Text.Length == 0)
            {
                return false;
            }

            return output;
        }

       
    }
}

