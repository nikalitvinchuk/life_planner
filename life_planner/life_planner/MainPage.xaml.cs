using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;
using System.IO;

namespace life_planner
{
    public partial class MainPage : ContentPage
    {
        private object conn;

        public DateTime Data { get; private set; }
        public String Notatka { get; private set; }
        public MainPage()
        {
            InitializeComponent();

        }
        private async void Dodaj(object sender, EventArgs e)
        {
            var date = mojadata.Date.ToString("MM/dd/yyyy");
            var time = mojczas.Time.ToString();

            DependencyService.Get<IFileService>().CreateFile($"{date};{time};{mojanotatka.Text}");
            // await DisplayAlert("Alert", "Dodaną nową notatkę", "OK");
            await DisplayAlert("Information", "Dodaną nową notatkę", "OK");
        }
        private async void Lista(object sender, EventArgs e)
        {

            App.Current.MainPage = new Page1();

        }

        private async void Dodatki(object sender, EventArgs e)
        {

            App.Current.MainPage = new mojedodatki();

        }


        public class MapTest
        {
            public async Task NavigateToBuilding25()
            {
                var location = new Location(47.645160, -122.1306032);
                var options = new MapLaunchOptions { Name = "Microsoft Building 25" };

                try
                {
                    await Map.OpenAsync(location, options);
                }
                catch (Exception ex)
                {
                    // No map application available to open
                }
            }
        }

        

    }
}

