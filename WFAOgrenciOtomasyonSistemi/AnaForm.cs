using OgrenciVeri.Koleksiyonlar;
using OgrenciVeri.Siniflar;
using OkulVeri.Koleksiyonlar;
using OkulVeri.Siniflar;

namespace WFAOgrenciOtomasyonSistemi
{
    public partial class AnaForm : Form
    {
        OgrenciVerileri veri = new OgrenciVerileri();
        public AnaForm()
        {
            InitializeComponent();
        }

        private void pbPersonelGiris_Click(object sender, EventArgs e)
        {
            new PersonelEkrani(veri).ShowDialog();
        }

        private void pbOgrenciGiris_Click(object sender, EventArgs e)
        {
            new OgrenciEkrani(veri).ShowDialog();
        }
    }
}