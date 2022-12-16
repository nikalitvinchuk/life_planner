using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace life_planner
{
    public class dodanie
    {
        [PrimaryKey, AutoIncrement]
        public string ID { get; set; }
        public string Data { get; set; }
        public string Tresc { get; set; }
        public string Wybor{ get; set; }
        public string Typ{ get; set; }
    }
}
