using System;

namespace ejercicio
{
class Program
{

    static void Main(string[] args)
    {

    // Una casa de computación paga a sus empleados un sueldo fijo de ARS15000 más una comisión 
    // del 5% sobre el total facturado por cada empleado. Hacer un programa para ingresar el total 
    // facturado por un empleado y que luego calcule y emita por pantalla el sueldo total a cobrar por el mismo.

    double totalSold, finalPayment, totalComm;


    Console.WriteLine("Ingrese el total facturado: ");
    
    totalSold = Double.Parse(Console.ReadLine());

    totalComm = totalSold * 0.05;

    finalPayment = 15000 + totalComm;

    Console.WriteLine("El sueldo a cobrar es: $" + finalPayment);

    


    }
}

}
