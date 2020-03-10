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
    public class IOBean: IOJsonArr<Bean>, IIOBean
    {
        protected override string MainPath { get; set; }
        public IOBean()
        {
            MainPath = Path.GetFullPath(@"..\..\") + @"DataStore\beans.json";
        }
    }
}
