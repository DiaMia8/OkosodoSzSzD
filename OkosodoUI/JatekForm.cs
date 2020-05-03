using OkosodoLibrary;
using OkosodoLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkosodoUI
{
    public partial class JatekForm : Form
    {

        private TanuloModel _bejelentkezett;

        private char _feladatTipus;

        private static List<RandomModel> _randomFeladatok;

        private static List<MatematikaiModel> _matekFeladatok;

        private static List<AbcModel> _abcFeladatok;

        private static List<IFeladatModel> _belsoLista = new List<IFeladatModel>();
       
        //ez an index növekszik gombnyomáskor ami megváltoztatja a feladatot
        private static int _kivalogatottListaIndexe = 0;

        //létező feladatokból kiválogat amellyit kell
        public static List<IFeladatModel> _kivalogatottLista = new List<IFeladatModel>();

        //számolja, hogy hány feladat van hétra, gomb if-jében
        private static int _elvegzendoFeladatokSzama;

        private IFeladatModel _aktualisFeladat;

        

        private static int egyFeladatId;

        // itt állítjuk be hány feladatot szeretnénk futtatni
        private int _feladatokSzama;

        public JatekForm(int id, char tipus)
        {
            _bejelentkezett = GlobalConfig.Connection.GetOneTanuloById(id);
            _feladatTipus = tipus;
            if (tipus == 'R')
            {
                _randomFeladatok = GlobalConfig.Connection.FeladatGetAll();
            }
            if (tipus == 'M')
            {
                _matekFeladatok = GlobalConfig.Connection.GetAllMatematikaiFeladat();
            }
            if (tipus == 'A')
            {
                _abcFeladatok = GlobalConfig.Connection.getAllAbcFeladat();
            }
            InitializeComponent();
            //belső lista az aktuálisan választott feladat típust tartalmazza
            belsoListaFeltoltes(tipus);
            //random szám kialakításákoz használjuk feladatfeltöltés metódusban
            _feladatokSzama = _belsoLista.Count;
            //feltölti a játék feladatait
            feladatFeltolt();
            //első feladat inicializálása 0 indextől
            jatekErtekbeallitasKezdo(_kivalogatottListaIndexe);

        }
        // kép url-re figyelni a sting ez legyen : .\Resources\Images\valami.jpg

        /// <summary>
        /// feltölt egy típusfüggetlen listát a játékhoz
        /// </summary>
        /// <param name="tipus">form paramétereként kapott karakter</param>
        private void belsoListaFeltoltes(char tipus)

        {
            if (tipus == 'R')
            {
                foreach (var item in _randomFeladatok)
                {
                    _belsoLista.Add(item);
                }
            }

            if (tipus == 'M')
            {
                foreach (var item in _matekFeladatok)
                {
                    _belsoLista.Add(item);
                }
            }

            if (tipus == 'A')
            {
                foreach (var item in _abcFeladatok)
                {
                    _belsoLista.Add(item);
                }
            }
            
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            //belsoListaFeltoltes('M');
            //megoldasLabel.Text = "";
            //feladatPictureBox.ImageLocation = $@".{matekFeladatok.First().KepUrl}";
        }
        /// <summary>
        /// /első megjelenítendő kép adatai mindig 0 a kiválogatott listából válogat
        /// </summary>
        /// <param name="index">_kivalogatott lista indexe</param>
        private void jatekErtekbeallitasKezdo(int index)
        {
            _aktualisFeladat = _kivalogatottLista.ElementAt(index);
            feladatPictureBox.ImageLocation = $@".{_aktualisFeladat.KepUrl}";
        }

        /// <summary>
        /// Gomb nyomásra új feladat objektum 
        /// </summary>
        /// <param name="index">növelt index</param>
        private void jatekErtekbeallitasIndexNovelessel(int index)
        {
            
            _aktualisFeladat = _kivalogatottLista.ElementAt(index);

            feladatPictureBox.ImageLocation = $@".{_aktualisFeladat.KepUrl}";

        }

        /// <summary>
        /// válasz adásakor elindítja a következő feladatot és menti az adatokat
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void valaszButton_Click(object sender, EventArgs e)
        {
            if (valaszTextBox.Text == _aktualisFeladat.Megoldas.ToLower() || valaszTextBox.Text == _aktualisFeladat.Megoldas || int.Parse(valaszTextBox.Text) == int.Parse(_aktualisFeladat.Megoldas))
            {
                //TODO - ide jon a mentés
                MessageBox.Show("jó válasz");
            }
            else
            {
                //ide is mentés jön
                megoldasLabel.Text = _aktualisFeladat.Megoldas;
            }

            megoldasLabel.Text = "";

            if (_elvegzendoFeladatokSzama > 0)
            {
                    elvegezedoFeladatokIndexCsokkentes();
                    kivalogatottListaIndexNoveles();
                    jatekErtekbeallitasIndexNovelessel(_kivalogatottListaIndexe);
               
            }
            else
            {
                //kilépőkép és becsukás
                MessageBox.Show("Vége");
                //TODO - gombok eltüntetése 
                //TODO - időzítés
            }
            
        }

        /// <summary>
        /// lehetséges feladatokbó leválaszt annyit amennyit kell
        /// </summary>
        private void feladatFeltolt()
        {
            Random r = new Random();
            int szamlalo = 0;
            int randomSzamlalo = _feladatokSzama - 1;
            //itt van meghatározva, hogy hány feladat lesz összesen
            while (szamlalo <= 4)
            {   // levesz egy random elemet, csökkenti a randomszamot, növeli a szamlalót
                var egyEgyed = _belsoLista.ElementAt(r.Next(randomSzamlalo));
                _belsoLista.Remove(egyEgyed);
                _kivalogatottLista.Add(egyEgyed);
                if (randomSzamlalo != 1)
                {
                    randomSzamlalo--;

                }
                szamlalo++;
            }

            _elvegzendoFeladatokSzama = _kivalogatottLista.Count-1;
        }

        /// <summary>
        /// gombnyomáskor meghívva növeli a statikus mező indexét
        /// </summary>
        private void kivalogatottListaIndexNoveles()
        {
            _kivalogatottListaIndexe += 1;
        }
       /// <summary>
       /// csökkenti az elvégezendő feladatok számát
       /// </summary>
        private void elvegezedoFeladatokIndexCsokkentes()
        {
            _elvegzendoFeladatokSzama -= 1;
        }
    }
}
