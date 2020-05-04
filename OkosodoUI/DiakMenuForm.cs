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
    public partial class DiakMenuForm : Form
    {

        private TanuloModel bejelentkezett;

        public static int _adminId;

        public DiakMenuForm(int id, int adminId)
        {
            bejelentkezett = GlobalConfig.Connection.GetOneTanuloById(id);
            _adminId = adminId;
            InitializeComponent();

            Udvozlet();
        }

        private void Udvozlet()
        {
            diakUdvozloNevLabel.Text = $"{bejelentkezett.Becenev.ToString()} !";
        }

        private void matekButton_Click(object sender, EventArgs e)
        {
            char tipus = 'M';
            JatekForm frm = new JatekForm(bejelentkezett.Id, tipus, _adminId);
            frm.Show();
            this.Hide();
        }

        private void abcButton_Click(object sender, EventArgs e)
        {
            //megnyitja a jatékformot
            char tipus = 'A';
            JatekForm frm = new JatekForm(bejelentkezett.Id, tipus, _adminId);
            frm.Show();
            this.Hide();
            //átküldi a diák id-ját és a feladat típusát
        }

        private void randomFeladatButton_Click(object sender, EventArgs e)
        {
            //megnyitja a játékformot
            char tipus = 'R';
            JatekForm frm = new JatekForm(bejelentkezett.Id, tipus, _adminId);
            frm.Show();
            this.Hide();
            //átküldi a diák id-ját a mentéshez és egy olyan feladat típust ami nem létezik, de kiszűrjük vagy nem használjuk
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            AdminMenuForm frm = new AdminMenuForm(_adminId);
            frm.Show();
            this.Hide();
        }
    }
}
