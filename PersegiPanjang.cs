using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseWeek3_Elia
{
    class PersegiPanjang
    {
        public int PanjangPersegiPanjang, LebarPersegiPanjang;

        public int luasPersegiPanjang()
        {
            return PanjangPersegiPanjang * LebarPersegiPanjang;
        }

        public int kelilingPersegiPanjang()
        {
            return (PanjangPersegiPanjang + LebarPersegiPanjang) * 2;
        }
    }
}
