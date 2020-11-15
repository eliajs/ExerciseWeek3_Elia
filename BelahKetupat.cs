using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseWeek3_Elia
{
    class BelahKetupat
    {
        public int DiagonalBelahKetupat1, DiagonalBelahKetupat2, SisiBelahKetupat;

        public int luasBelahKetupat()
        {
            return 1 / 2 * DiagonalBelahKetupat1 * DiagonalBelahKetupat2;
        }

        public int kelilinfBelahKetupat()
        {
            return 4 * SisiBelahKetupat;
        }
}
