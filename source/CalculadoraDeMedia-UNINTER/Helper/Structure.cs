using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDeMedia_UNINTER.Helper
{
    public class Structure
    {
        public readonly static string[] resultsText = 
        {
            "Aprovado!",
            "Ficou para exame",
            "Reprovado"
        };

        public readonly static Color[] resultsColors =
        {
            //green
            Color.FromArgb(76,175,80),
            
            //orange
            Color.FromArgb(234, 165, 16),

            //red
            Color.FromArgb(244, 67, 54)


        };

    }
}
