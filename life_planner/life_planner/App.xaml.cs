﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace life_planner
{
    public partial class App : Application
    {

        public static string DB_PATH = String.Empty;


        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage()); ;
        }

        public App(string DB_Path)
        {
            InitializeComponent();
            DB_PATH = DB_Path;
            MainPage = new NavigationPage(new MainPage());
        }
        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
