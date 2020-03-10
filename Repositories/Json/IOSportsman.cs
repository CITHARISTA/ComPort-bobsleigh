using ComPort.Models;
using ComPort.Repositories.Json.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComPort.Repositories.Json
{
    public class IOSportsman : IOJsonArr<Sportsman>, IIOSportsman
    {
        protected override string MainPath { get; set; }
        public IOSportsman()
        {
            MainPath = Path.GetFullPath(@"..\..\") + @"DataStore\sportsman.json";
        }
    }
}
