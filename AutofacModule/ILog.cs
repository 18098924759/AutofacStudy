using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutofacModule
{
    public interface ILog
    {
        void Write(string msg);
    }

    public class ConsoleLog : ILog
    {
        public void Write(string msg)
        {
            System.Diagnostics.Debug.WriteLine(msg);
        }
    }
}
