using ComPort.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ComPort.Repositories
{
    public class IOJsonArr<T>: IIOArrData<T>
    {
        protected virtual string MainPath { get; set; }

        public List<T> GetData()
        {
            using (StreamReader sr = new StreamReader(MainPath, System.Text.Encoding.Default))
            {
                 return JsonConvert.DeserializeObject<List<T>>(sr.ReadToEnd()) ?? 
                    new List<T>();
            }
        }

        public void SaveData(IEnumerable<T> arr)
        {
            using (StreamWriter sw = new StreamWriter(MainPath, false, System.Text.Encoding.Default))
            {
                 sw.WriteLine(JsonConvert.SerializeObject(arr));
            }
        }
    }
}
