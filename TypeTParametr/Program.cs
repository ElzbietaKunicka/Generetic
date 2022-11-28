using System.Runtime.ConstrainedExecution;
using System;

namespace TypeTParametr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Type T parametrai gali būti nurodyti ne tik vienas, pvz ShowValues<T1, T2>
            //Sukurkite funkcija kuri prašo nurodyti 2 generic tipus
            //Per parametrus pasiima 2 kintamuosius vieną pirmojo generic tipo,
            //antrą antrojo generic tipo
            //Juos abu išspausdina į konsolę.
            //Kviečiant šias funkcijas perduokit skirtingus tipus.

            var value = new ShowValues();
            value.ShowItem(12, "labas");


            // Generator

            var fourSideGeometricFigure = new FourSideGeometricFigure()
            {
                Name = "Vardas",
                Base = 10,
                Height = 11
            };
            var generator = new Generator<FourSideGeometricFigure>();
            generator.Show(fourSideGeometricFigure);

            // Type

            var type = new Type<FourSideGeometricFigure, string>();
            type.GetType(fourSideGeometricFigure);

            //Sportas

            var zalgiris = new Krepsinis
            {
                Name = "Zalgiris"
            };

            var rytas = new Krepsinis
            {
                Name = "Rytas"
            };
            var ekranas = new Futbolas
            {
                Name = "Ekranas"
            };
            var suduva = new Futbolas
            {
                Name = "Suduva"
            };


            var Lygos = new SportoLygos();
            Lygos.PridetiKomanda(zalgiris);
            Lygos.PridetiKomanda(rytas);
            Lygos.PridetiKomanda(ekranas);
            Lygos.PridetiKomanda(suduva);

            Lygos.AtspaudintiKomandas();


        }
    }
}