using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace life_planner
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class mojedodatki : ContentPage
    {
        public mojedodatki()
        {
            InitializeComponent();
        }
        private async void Powrot(object sender, EventArgs e)
        {

            App.Current.MainPage = new MainPage();

        }
    }
}