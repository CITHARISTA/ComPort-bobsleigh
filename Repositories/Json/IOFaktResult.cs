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
    class IOFaktResult : IOJsonArr<FaktResult>, IIOFaktResult
    {
        protected override string MainPath { get; set; }
        public IOFaktResult()
        {
            MainPath = Path.GetFullPath(@"..\..\") + @"DataStore\faktResults.json";
        }
    }
}
