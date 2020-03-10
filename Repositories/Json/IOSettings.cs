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
    public class IOSettings: IOJsonAlone<Settings>, IIOSettings
    {
        protected override string MainPath { get; set; }
        public IOSettings()
        {
            MainPath = Path.GetFullPath(@"..\..\") + @"DataStore\settings.json";
        }
    }
}
