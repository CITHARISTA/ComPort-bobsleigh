using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComPort
{
    public static class Extensions
    {
        public static void AddHandlers<T>(this T tb, params Action[] actions) where T: Control
        {
            foreach (var a in actions)
                tb.TextChanged += (s, e) => a();
        }
    }
}
