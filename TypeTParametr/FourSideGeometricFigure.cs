using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TypeTParametr
{
    public class FourSideGeometricFigure
    {
        //Sukurkite klasę FourSideGeometricFigure
        //Properties: name base height
        //Funkcijos: GetArea()
//Taip pat override’inti funkcija ToString() kad grąžintų aprašytą objektą.
//Tada sukurti Generator<T> klasę turinčią metodą Show kuris
//atspausdins perduoto objekto ToString() grąžintą reikšmę.
        public string Name { get; set; }
        public int Base { get; set; }
        public int Height { get; set; }
       
        public int GetArea()
        {
            return Base * Height;
        }
        public override string ToString()
        {
            return $"{Name} area is equal to {GetArea()}";
        }
    }
}
