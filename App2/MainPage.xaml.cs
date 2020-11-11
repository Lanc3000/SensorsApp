using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            
        }

        private async void gpa12Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new SensorsPage());
        }

        private void gpa16Button_Clicked(object sender, EventArgs e)
        {

        }

        private void gpa16UButton_Clicked(object sender, EventArgs e)
        {

        }

        private void gpa10Button_Clicked(object sender, EventArgs e)
        {

        }
    }
}
