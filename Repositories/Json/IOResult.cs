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
    class IOResult : IOJsonArr<Result>, IIOResult
    {
        protected override string MainPath { get; set; }
        public IOResult()
        {
            MainPath = Path.GetFullPath(@"..\..\") + @"DataStore\results.json";
        }
    }
}
