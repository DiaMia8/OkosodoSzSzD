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

        public static int _adminId;

        private static List<RandomModel> _randomFeladatok;

        private static List<MatematikaiModel> _matekFeladatok;

        private static List<AbcModel> _abcFeladatok;

        private static List<IFeladatModel> _belsoLista = new List<IFeladatModel>();

        // leválogatáshoz használt szám, hány feladat legyen kiválogatva, plusz ellenőrzi, hogy van-e elég elem az adatbázisban
        public static int _osszesFeladatSzam = 4;

        // int a kiválasztott típusú lista countja
        public static int _listaCount;
        
        //ez an index növekszik gombnyomáskor ami megváltoztatja a feladatot
        private static int _kivalogatottListaIndexe = 0;

        //létező feladatokból kiválogat amellyit kell
        public static List<IFeladatModel> _kivalogatottLista = new List<IFeladatModel>();

        //számolja, hogy hány feladat van hétra, gomb if-jében
        private static int _elvegzendoFeladatokSzama;

        // visszaszámláló, hogy ne fussunk ki az adatokból, gombnyomásokkor vizsgáljuk
        private IFeladatModel _aktualisFeladat;

        // megoldott feladatok listába mentése
        private List<MegoldottFeladatokModel> _osszesMegoldott = new List<MegoldottFeladatokModel>();

        // itt állítjuk be hány feladatot szeretnénk futtatni és ezt csökkentve kap új indexet a feladat
        private int _feladatokSzama;

        public JatekForm(int id, char tipus, int adminId)
        {
            _bejelentkezett = GlobalConfig.Connection.GetOneTanuloById(id);
            _feladatTipus = tipus;
            _adminId = adminId;
            if (tipus == 'R')
            {
                _randomFeladatok = GlobalConfig.Connection.FeladatGetAll();
                _listaCount = _randomFeladatok.Count;
            }
            if (tipus == 'M')
            {
                _matekFeladatok = GlobalConfig.Connection.GetAllMatematikaiFeladat();
                _listaCount = _matekFeladatok.Count;
            }
            if (tipus == 'A')
            {
                _abcFeladatok = GlobalConfig.Connection.GetAllAbcFeladat();
                _listaCount = _abcFeladatok.Count;
            }

            InitializeComponent();

            if (_listaCount <= _osszesFeladatSzam)
            {
                // TODO - valamiért megjelenik üresen - kijavítani
                MessageBox.Show("Adatbázis hiba!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
                Hide();
                DiakMenuForm frm = new DiakMenuForm(_bejelentkezett.Id, _adminId);
                frm.Show();
               
            }
            else
            {

                //belső lista az aktuálisan választott feladat típust tartalmazza
                belsoListaFeltoltes(tipus);
                //random szám kialakításákoz használjuk feladatfeltöltés metódusban
                _feladatokSzama = _belsoLista.Count;
                //feltölti a játék feladatait
                feladatFeltolt();
                //első feladat inicializálása 0 indextől
                jatekErtekbeallitasKezdo(_kivalogatottListaIndexe); 
            }

        }
        

        
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


        /// <summary>
        /// A gomb megnyomásával a helyes válasz feltűnik egy labelen, majd menti a listába, hogy ne, sikerült megoldani a feladatot
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void helpButton_Click(object sender, EventArgs e)
        {
            // megmutatja a helyes megoldást, vár, majd növeli a játékot, elmenti, hogy nem sikerült megoldani
            megoldasLabel.Text = _aktualisFeladat.Megoldas;
            // frissíti a labelt
            megoldasLabel.Update();
            //két másodpercet vár, mielőtt tovább lépne a következő feladatra
            Thread.Sleep(2000);
            
            megoldasLabel.Text = "";
            if (_elvegzendoFeladatokSzama > 0)
            {
                elvegezedoFeladatokIndexCsokkentes();
                kivalogatottListaIndexNoveles();
                jatekErtekbeallitasIndexNovelessel(_kivalogatottListaIndexe);
                // helytelen megoldással hozzáadás a megoldott feladatok listájához
                MegoldottFeladatokModel model = new MegoldottFeladatokModel(
                    _bejelentkezett.Id,
                    _aktualisFeladat.Id,
                    1,
                    false
                    );

                _osszesMegoldott.Add(model);
            }
            else
            {
                //kilépőkép és becsukás
                //menti az adatokat
                foreach (var item in _osszesMegoldott)
                {
                    GlobalConfig.Connection.CreateMegoldottFeladatokModel(item);
                }

                feladatPictureBox.Refresh();
                feladatPictureBox.ImageLocation = $@".\Resources\gratulaAH.png";
                elkoszonoLabel.Visible = true;
                elkoszonoLabel.Text = $"Ügyes voltál! A helyesen megoldott feladataid: 5/{_osszesMegoldott.Count(x=>x.Megoldott == true).ToString()} !";
                elkoszonoLabel.Update();
                

                helpButton.Hide();
                valaszButton.Hide();
                valaszTextBox.Hide();
                Thread.Sleep(5000);
                DiakMenuForm frm = new DiakMenuForm(_bejelentkezett.Id, _adminId);
                frm.Show();
                this.Close();
            }

        }
       
        
        /// <summary>
        /// /első megjelenítendő kép adatai mindig 0 a kiválogatott listából válogat
        /// </summary>
        /// <param name="index">_kivalogatott lista indexe</param>
        private void jatekErtekbeallitasKezdo(int index)
        {
            _aktualisFeladat = _kivalogatottLista.ElementAt(index);
            feladatPictureBox.ImageLocation = $@"{_aktualisFeladat.KepUrl}";
        }

        
        /// <summary>
        /// Gomb nyomásra új feladat objektum 
        /// </summary>
        /// <param name="index">növelt index</param>
        private void jatekErtekbeallitasIndexNovelessel(int index)
        {
            
            _aktualisFeladat = _kivalogatottLista.ElementAt(index);

            feladatPictureBox.ImageLocation = $@"{_aktualisFeladat.KepUrl}";

        }

       
        /// <summary>
        /// válasz adásakor elindítja a következő feladatot és menti az adatokat
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void valaszButton_Click(object sender, EventArgs e)
        {
            bool szamBool = int.TryParse(valaszTextBox.Text, out int result);
            bool megoldasBool = int.TryParse(_aktualisFeladat.Megoldas, out int r);

            if (szamBool == true && megoldasBool == true)
            {

                if (int.Parse(valaszTextBox.Text) == int.Parse(_aktualisFeladat.Megoldas))
                {
                    MegoldottFeladatokModel model = new MegoldottFeladatokModel(
                   _bejelentkezett.Id,
                   _aktualisFeladat.Id,
                   _aktualisFeladat.MaxPont,
                   true
                   );

                    _osszesMegoldott.Add(model);
                }
                else
                {
                    
                    megoldasLabel.Text = _aktualisFeladat.Megoldas;
                    Thread.Sleep(2000);
                    MegoldottFeladatokModel model = new MegoldottFeladatokModel(
                   _bejelentkezett.Id,
                   _aktualisFeladat.Id,
                   1,
                   false
                   );

                    _osszesMegoldott.Add(model);
                }
            }
            
            if (szamBool == false && megoldasBool == false)
            {
                if (valaszTextBox.Text == _aktualisFeladat.Megoldas.ToLower() || valaszTextBox.Text == _aktualisFeladat.Megoldas)
                {

                    MegoldottFeladatokModel model = new MegoldottFeladatokModel(
                   _bejelentkezett.Id,
                   _aktualisFeladat.Id,
                   _aktualisFeladat.MaxPont,
                   true
                   );

                    _osszesMegoldott.Add(model);
                }
                else
                {
                    
                    megoldasLabel.Text = _aktualisFeladat.Megoldas;
                    Thread.Sleep(2000);
                    MegoldottFeladatokModel model = new MegoldottFeladatokModel(
                   _bejelentkezett.Id,
                   _aktualisFeladat.Id,
                   1,
                   false
                   );

                    _osszesMegoldott.Add(model);
                } 
            }
            if (szamBool == true && megoldasBool ==false || szamBool== false && megoldasBool == true)
            {
                
                megoldasLabel.Text = _aktualisFeladat.Megoldas;
                megoldasLabel.Update();
                Thread.Sleep(2000);
                MegoldottFeladatokModel model = new MegoldottFeladatokModel(
                   _bejelentkezett.Id,
                   _aktualisFeladat.Id,
                   1,
                   false
                   );

                _osszesMegoldott.Add(model);
            }
            megoldasLabel.Text = "";
            valaszTextBox.Clear();

            if (_elvegzendoFeladatokSzama > 0)
            {
                    elvegezedoFeladatokIndexCsokkentes();
                    kivalogatottListaIndexNoveles();
                    jatekErtekbeallitasIndexNovelessel(_kivalogatottListaIndexe);
               
            }
            else
            {
                foreach (var item in _osszesMegoldott)
                {
                    GlobalConfig.Connection.CreateMegoldottFeladatokModel(item);
                }
                valaszTextBox.Clear();
                
                feladatPictureBox.ImageLocation = $@".\Resources\gratulaAH.png";
                
                elkoszonoLabel.Visible = true;
                elkoszonoLabel.Text = $"Ügyes voltál! A helyesen megoldott feladataid: 5/{_osszesMegoldott.Count(x => x.Megoldott == true).ToString()} !";
                elkoszonoLabel.Update();
                
                valaszLabel.Hide();
                helpButton.Hide();
                valaszButton.Hide();
                valaszTextBox.Hide();
                Thread.Sleep(5000);

                DiakMenuForm frm = new DiakMenuForm(_bejelentkezett.Id, _adminId);
                frm.Show();
                this.Hide();
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
            while (szamlalo <= _osszesFeladatSzam)
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
