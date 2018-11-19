using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BMI
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            float hei = float.Parse(height.Text);
            int wei = int.Parse(weight.Text);
            if (hei > 3)
            {
                hei = hei / 100;
            }
            float re = wei / hei / hei;
            label.Text = "BMI = " + re.ToString();
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            float hei = float.Parse(height.Text);
            int wei = int.Parse(weight.Text);
            Navigation.PushModalAsync(new NavigationPage(new BMIResult(hei, wei)));
        }
    }
}
