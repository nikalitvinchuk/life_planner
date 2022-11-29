using System;
using System.Collections.Generic;
using System.Text;

namespace life_planner
{
    public interface IFileService
    {
        void CreateFile(string text);

        string[] ReadFile();
    }
}
