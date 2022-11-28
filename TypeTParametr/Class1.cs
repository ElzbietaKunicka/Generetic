using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeTParametr
{
    //Generics parametrų galima naudoti daugiau negu vieną pvz Method<T1,T2>
    //Sukurkite klasę kuri priima du generic tipo parametrus.
    //Klasė turės du kintamuosius kurie atitiks tuos generic parametrus.
    //Turės keturias funkcijas, dvi iš jų bus atspausdinti T1 ir T2 properties
    //Kitos dvi funkcijos leis pakeisti reikšmę T1 ir T2 properties.
    internal class Class1<T, T1>
    {
        public T Klass1; // field

        public T1 Klass2; //field

        public void Atspaudinti1()
        {
            Console.WriteLine(Klass1);
        }
        public void Atspaudinti2()
        {
            Console.WriteLine(Klass2);
        }

        public void Pakeisti1(T param)
        {
            Klass1 = param;
        }
        public void Pakeisti2(T1 param)
        {
            Klass2 = param;

        }

    }
}
