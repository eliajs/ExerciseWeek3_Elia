using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseWeek3_Elia
{
    class LayangLayang
    {
        public int DiagonalLayangLayang1, DiagonalLayangLayang2, SisiLayangLayang1, SisiLayangLayang2;

        public int luasLayangLayang()
        {
            return 1 / 2 * DiagonalLayangLayang1 * DiagonalLayangLayang2;
        }

        public int kelilingLayangLayang()
        {
            return 2 * (SisiLayangLayang1 + SisiLayangLayang2);
        }
    }
}
