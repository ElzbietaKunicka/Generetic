using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace TypeTParametr
{
    internal class Type<T, T1>
    {
        //Sukurkite klasę Type, kuri priims du type T tipo kintamuosius
        //Turės funkciją GetType su parametru T input,
        //kuri atspausdins input kintamojo duomenų tipą.

        public void GetType(T input)
        {
            Console.WriteLine(typeof(T));
        }
    }
}
