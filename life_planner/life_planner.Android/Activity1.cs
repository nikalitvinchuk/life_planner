using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using AndroidX.AppCompat.App;
using System.Threading.Tasks;

namespace App1
{
    [Activity(Theme = "@style/MyTheme.Splash", MainLauncher = true, NoHistory = true)]
    public class SplashActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }
        protected override async void OnResume()
        {
            base.OnResume();
            await SimulateStartup();
        }
        async Task SimulateStartup()
        {
            await Task.Delay(TimeSpan.FromSeconds(8));
            StartActivity(new Intent(Application.Context, typeof(MainActivity)));
        }
    }
}