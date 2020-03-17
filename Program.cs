using System;
using System.Collections.Generic;

namespace Nueva_carpeta
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Grado> grados = new List<Grado>();
          for (int i = 1; i <= 7; i++)
          {
              grados.Add(new Grado(i));
          }
        }
    }
}
