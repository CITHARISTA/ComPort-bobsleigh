using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComPort.Repositories.Json
{
    public class IOJsonAlone<T> : IIOAloneData<T>
    {
        protected virtual string MainPath { get; set; }

        public T GetData()
        {
            using (StreamReader sr = new StreamReader(MainPath, System.Text.Encoding.Default))
            {
                return JsonConvert.DeserializeObject<T>(sr.ReadToEnd());
            }
        }

        public void SaveData(T item)
        {
            using (StreamWriter sw = new StreamWriter(MainPath, false, System.Text.Encoding.Default))
            {
                sw.WriteLine(JsonConvert.SerializeObject(item));
            }
        }
    }
}
