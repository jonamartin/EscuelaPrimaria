using System;
using System.Collections.Generic;
using Nueva_carpeta;

class Grado : Program
{
    public List<Alumno> Alumnos {get; set;} = new List<Alumno>();
    public Grado(int grado)
    {
       
        for (int i = 0; i<20; i++)
        {
            Alumnos.Add(new Alumno());
        }
    }
}