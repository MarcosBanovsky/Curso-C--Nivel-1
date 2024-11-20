using System;

namespace ejercicio
{
class Program
{

    static void Main(string[] args)
    {
    //    Hacer un programa que permita ingresar los kilómetros existentes entre dos ciudades 
    //    y la velocidad promedio de un vehículo. Calcular y emitir por pantalla el 
    //    tiempo aproximado que demandará llegar de un punto a otro teniendo en cuenta los datos ingresados.

    int distInKm, speedVehicle;

    float estimatedTime;

    Console.WriteLine("Ingrese la distancia en Km entre dos ciudades :");
    
    distInKm = int.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese la velocidad en Km/h a la que va el vehiculo: ");

    speedVehicle = int.Parse(Console.ReadLine());

    estimatedTime = distInKm/speedVehicle;

    Console.WriteLine("El tiempo estimado para llegar es de: " + estimatedTime +"hs");


    }
}

}
