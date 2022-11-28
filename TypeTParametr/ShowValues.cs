using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeTParametr
{
    internal class ShowValues//<T, T1>
    {
        public void ShowItem<T, T1>(T item, T1 item2)
        {
            Console.WriteLine(item);
            Console.WriteLine(item2);
        }
    }
}
