using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using life_planner.Droid;
using Path = System.IO.Path;

[assembly: Xamarin.Forms.Dependency(typeof(FileService))]
namespace life_planner.Droid
{
    public class FileService : IFileService
    {
        private const string filename = "notes.txt";

        public string GetRootPath()
        {
            return Application.Context.GetExternalFilesDir(null).ToString();
        }

        public void CreateFile(string text)
        {
            var rootPath = GetRootPath();

            var destination = Path.Combine(rootPath, filename);

            if (File.Exists(destination))
            {
                var fileContent = File.ReadAllText(destination);
                fileContent += $"\n{text}";
                File.WriteAllText(destination, fileContent);
            }
            else
            {
                File.WriteAllText(destination, text);
            }

        }

        public string[] ReadFile()
        {
            var rootPath = GetRootPath();

            var destination = Path.Combine(rootPath, filename);

            return File.ReadAllLines(destination);
        }
    }
}