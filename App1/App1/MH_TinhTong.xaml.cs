using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MH_TinhTong : ContentPage
    {
        public MH_TinhTong()
        {
            InitializeComponent();
        }

        private void CmdTinhTong_Clicked(object sender, EventArgs e)
        {
            double SoA, SoB, Tong;
            SoA = double.Parse(txtSoA.Text);
            SoB = double.Parse(txtSoB.Text);
            Tong = SoA + SoB;
            txtTong.Text = Tong.ToString();
        }

        private void CmdVeTrangChu_Clicked(object sender, EventArgs e)
        {

        }
    }
}