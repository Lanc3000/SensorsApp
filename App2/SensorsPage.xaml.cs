using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SensorsPage : ContentPage
    {
        public SensorsPage()
        {
            InitializeComponent();
        }

        private async void p116_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new P116_Page());
        }

        private async void tempSensor_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new tempSensorPage());
        }
    }
}