using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BMI
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class BMIResult : ContentPage
	{
        private float hei;
        private int wei;

        public BMIResult ()
		{
			InitializeComponent ();
            buttonBack.Clicked += buttonBackClicked;
		}
        public BMIResult(float hei, int wei)
        {
            InitializeComponent();
            this.hei = hei;
            this.wei = wei;
            if (hei > 3)
            {
                hei = hei / 100;
            }
            float re = wei / hei / hei;
            label.Text = "BMI = " + re;
            buttonBack.Clicked += buttonBackClicked;
        }
        private void buttonBackClicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }
    }
}