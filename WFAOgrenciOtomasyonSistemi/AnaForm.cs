using OgrenciVeri.Koleksiyonlar;
using OgrenciVeri.Siniflar;
using OkulVeri.Koleksiyonlar;
using OkulVeri.Siniflar;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace WFAOgrenciOtomasyonSistemi
{
    public partial class AnaForm : Form
    {
        OgrenciVerileri veri = new OgrenciVerileri();
        public AnaForm()
        {
            InitializeComponent();
            VerileriYukle();
        }

        private void VerileriYukle()
        {
            try
            {
                string json = File.ReadAllText("veriler.json");
                veri = JsonSerializer.Deserialize<OgrenciVerileri>(json)!;
            }
            catch (Exception)
            {

            }
        }

        private void pbPersonelGiris_Click(object sender, EventArgs e)
        {
            new PersonelEkrani(veri).ShowDialog();
        }

        private void pbOgrenciGiris_Click(object sender, EventArgs e)
        {
            new OgrenciEkrani(veri).ShowDialog();
        }

        private void AnaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            VerileriKaydet();
        }

        //Öðrenci eklendiðinde oluþmuyor.
        private void VerileriKaydet()
        {
            string json = JsonSerializer.Serialize(veri);
            File.WriteAllText("veriler.json", json);
        }
    }
}