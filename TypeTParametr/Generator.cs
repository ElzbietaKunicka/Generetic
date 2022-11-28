using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeTParametr
{
    internal class Generator<T>
    {
        public void Show(T param)
        {
              Console.WriteLine(param.ToString());
        }
    }
}
