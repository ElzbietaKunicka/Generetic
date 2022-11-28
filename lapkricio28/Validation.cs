using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace lapkricio28
{
    internal class Validation<T>
    {
        //Sukurkite generic klasę Validation, kuri turėtų funkciją pavadinimu Validate
        //Validate funkcijos paskirtis būtų patikrinti ar perduotas parametras yra null
//Jeigu jis yra null tai išmestų error’ą.
        public bool Validate(T param1)
        {
            if(param1 is null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
