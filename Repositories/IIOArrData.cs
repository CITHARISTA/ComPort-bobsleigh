using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComPort.Repositories
{
    public interface IIOArrData<T>
    {
        void SaveData(IEnumerable<T> arr);

        List<T> GetData();
    }
}
