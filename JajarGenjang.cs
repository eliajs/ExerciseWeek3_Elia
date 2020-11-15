using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseWeek3_Elia
{
    class JajarGenjang
    {
        public int AlasJajarGenjang, TinggiJajarGenjang, SisiJajarGenjang;

        public int luasJajarGenjang()
        {
            return AlasJajarGenjang * TinggiJajarGenjang;
        }

        public int kelilingJajarGenjang()
        {
            return 2 * (AlasJajarGenjang + SisiJajarGenjang);
        }
    }
}
