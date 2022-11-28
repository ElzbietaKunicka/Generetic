using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeTParametr
{
    internal class SportoLygos
    {
        // Sukurkite generic klasę sporto žaidimų lygoms.
        //Klasė turi leisti pridėti naują komandą į jai priklausančios lygos sąrašą.
        //Klasė turi turėti metodą atspausdinti visas komandas.
        //Klasė turi leisti pridėti tik tos pačios sporto rūšies komandas,
        //jeigu pridedama komanda iš kito sporto, programa turi išmesti error.

        private List<Futbolas> FutboloSarasas = new List<Futbolas>(); //field
        private List<Krepsinis> KrepsinioSarasas = new List<Krepsinis>();

        public void PridetiKomanda<T>(T komanda)
        {
            if(komanda is Krepsinis)
            {
                KrepsinioSarasas.Add(komanda as Krepsinis);
            } else if (typeof(T) == typeof(Futbolas))
            {
                FutboloSarasas.Add(komanda as Futbolas);
            }
            else
            {
                throw new Exception();
            }
        }

        public void AtspaudintiKomanda<T>(List<T> komandos) where T : BazineKomanda
        {
            foreach(T komanda in komandos)
            {
                Console.WriteLine(komanda.Name);
            }
        }
        public void AtspaudintiKomandas()
        {
            AtspaudintiKomanda<Krepsinis>(KrepsinioSarasas);
            AtspaudintiKomanda<Futbolas>(FutboloSarasas);
        }
    }
}


