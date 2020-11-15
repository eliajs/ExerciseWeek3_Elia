using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseWeek3_Elia
{
    class Persegi
    {
        public int RusukPersegi;

        public int luasPersegi()
        {
            return RusukPersegi * RusukPersegi;
        }

        public int kelilingPersegi()
        {
            return 4 * RusukPersegi;
        }
    }
}
