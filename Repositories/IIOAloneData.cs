using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComPort.Repositories
{
    public interface IIOAloneData<T>
    {
        void SaveData(T item);

        T GetData();
    }
}
