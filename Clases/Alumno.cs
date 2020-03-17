using System;
using System.Collections.Generic;
using Nueva_carpeta;

class Alumno
{
    public Alumno ()
    {
        List<int> notasMa = new List<int>();
        List<int> notasLe = new List<int>();
        List<int> notasEF = new List<int>();
        List<int> notasMu = new List<int>();

        Materia eval = new Materia();
        for (int i=0; i<=3; i++)
        {
            notasEF.Add(eval.evaluar());
            notasLe.Add(eval.evaluar());
            notasMu.Add(eval.evaluar());
            notasMa.Add(eval.evaluar());
        }
    }
}