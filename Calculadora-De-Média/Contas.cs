using System;
using System.Globalization;
namespace Calculadora_De_Média
{
    internal class Contas
    {
        public double AV1 { get; set; }
        public double  AV2 { get; set; }
        public double Tab { get; set; }
        

        public Contas(double aV1, double aV2, double tab)
        {
            AV1 = aV1;
            AV2 = aV2;
            Tab = tab;

        }

        public double Media()
        {
            return (AV1 + AV2 + Tab) /3;
        }
    }




}
