using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDeMedia_UNINTER.Utils
{
    public class Results
    {

        public static int check(Decimal nota, bool isMF = false)
        {

            if (isMF)
            {
                if (nota > 50)
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
            else
            {
                if (nota > 70)
                {
                    return 0;
                }
                else if (nota > 30)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }

            
        }

    }
}
