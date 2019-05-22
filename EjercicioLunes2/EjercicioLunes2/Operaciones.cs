using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioLunes2
{
    class Operaciones
    {
        public long Sumar() {

            long val = 0;

            for (long i=0; i<1000000;i++)
            {
                val += i;
            }
            return val;
        }
    }
}
