﻿using OgrenciVeri.Siniflar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAOgrenciOtomasyonSistemi
{
    public partial class PersonelEkrani : Form
    {
        private readonly OgrenciVerileri _veri;

        public PersonelEkrani(OgrenciVerileri veri)
        {
            _veri = veri;
            InitializeComponent();
        }

        private void pbOgretmenGirisi_Click(object sender, EventArgs e)
        {
            new OgretmenEkrani(_veri).ShowDialog();
        }

        private void pbMemurGirisi_Click(object sender, EventArgs e)
        {
            new MemurEkrani(_veri).ShowDialog();
        }
    }
}
