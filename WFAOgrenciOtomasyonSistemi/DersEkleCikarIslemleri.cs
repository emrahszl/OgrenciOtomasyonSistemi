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
    public partial class DersEkleCikarIslemleri : Form
    {
        private readonly OgrenciVerileri _veri;

        public DersEkleCikarIslemleri(OgrenciVerileri veri)
        {
            _veri = veri;
            InitializeComponent();
        }
    }
}
