using System;

namespace CalculadoraDeMedias_UNINTER.Functional.Calculator
{
    public class Result
    {

        public static int check(Decimal nota,  Base.Calculator.SubjectUtils.Subject subject, bool isMF = false)
        {
            if (isMF)
            {
                if (nota >= 50)
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
                if (nota >= 70)
                {
                    return 0;
                }
                else if (nota >= 30)
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
