using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    internal class Problema4
    {
       public double CalcularPromedio(int? nota1, int? nota2, int? nota3)
        {
            var notasValidas = new List<int>();

            ValidarAgregar(nota1, notasValidas);
            ValidarAgregar(nota2, notasValidas);
            ValidarAgregar(nota3, notasValidas);

            if (notasValidas.Count == 0)
                return 0;
            double suma = 0;
            foreach (var n in notasValidas)
                suma += n;

            return suma / notasValidas.Count;
        }
        private void ValidarAgregar (int? nota, List<int> lista)
        {
            if (nota == null)
                return;

            if (nota.Value >= 0 && nota.Value <= 10)
                lista.Add(nota.Value); 
        }
    }
}
