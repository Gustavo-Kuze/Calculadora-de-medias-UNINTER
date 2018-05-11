using System.Drawing;

namespace CalculadoraDeMedias_UNINTER.Base.Calculator
{
    public class ResultUtils
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
            Color.FromArgb(255, 179, 0),

            //red
            Color.FromArgb(244, 67, 54)
        };

    }
}
