using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace life_planner
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();

            var tab = DependencyService.Get<IFileService>().ReadFile();
            List<Notes> note = new List<Notes>();
            foreach (string line in tab)
            {
                string _Date = line.Split(';')[0];
                string _Time = line.Split(';')[1];
                string _Text = line.Split(';')[2];
                note.Add(new Notes { Date = (_Date + " " + _Time), Text = _Text });
            }
            MyListView.ItemsSource = note;
        }

        private async void Powrot(object sender, EventArgs e)
        {

            App.Current.MainPage = new MainPage();

        }
    }

    class Notes
    {
        public string Date { get; set; }
        //public string Time { get; set; }
        public string Text { get; set; }
    }
}
