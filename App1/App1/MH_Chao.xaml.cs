﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MH_Chao : ContentPage
    {
        public MH_Chao()
        {
            InitializeComponent();
        }

        private void CmdChao_Clicked(object sender, EventArgs e)
        {
            string Hoten = txtHoten.Text;
            DisplayAlert("Chào", "Chào bạn: " + Hoten, "Thoát");
        }
    }
}