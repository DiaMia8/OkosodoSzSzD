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
    public partial class JatekForm : Form
    {

        private static TanuloModel bejelentkezett = GlobalConfig.Connection.GetOneTanuloById(3);

        public JatekForm()
        {
            InitializeComponent();
        }

        private void kep()
        {
            feladatPictureBox.ImageLocation = @"Resources\profil.jpg";
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            kep();
        }
    }
}
