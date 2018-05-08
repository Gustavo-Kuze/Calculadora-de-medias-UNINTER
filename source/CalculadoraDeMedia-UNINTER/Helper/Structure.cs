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
            Color.FromArgb(0,150,10),
            
            //orange
            Color.FromArgb(234, 165, 16),

            //red
            Color.FromKnownColor(KnownColor.Firebrick)


        };

    }
}
