using System;

namespace ejercicio
{
class Program
{

    static void Main(string[] args)
    {

    // Hacer un programa para ingresar por teclado las tres notas de exámenes de un alumno y 
    // luego calcule y emita por pantalla el promedio final.
    
    double nota, promedio, acuNota;
    acuNota = 0;

    for (int i = 0; i < 3; i++)
    {
        Console.WriteLine("Ingrese la nota: ");
        nota = Double.Parse(Console.ReadLine());
    
        acuNota = nota + acuNota;
 
    }
    
    promedio = acuNota/3;

    Console.WriteLine("El promedio es: " + promedio);

    }
}

}
