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

        private TanuloModel bejelentkezett;

        private char feladatTipus;

        private static List<RandomModel> feladatok; 

        public JatekForm(int id, char tipus)
        {
            bejelentkezett = GlobalConfig.Connection.GetOneTanuloById(id);
            feladatTipus = tipus;
            if (tipus == 'R')
            {
                feladatok = GlobalConfig.Connection.FeladatGetAll();
            }
            InitializeComponent();
        }

        private void kep()
        {
            feladatPictureBox.ImageLocation = feladatok.First().KepUrl;
            
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            kep();
        }
    }
}
