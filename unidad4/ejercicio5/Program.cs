﻿/*

5. Hacer un programa para ingresar 4 números. Luego analizar e informar por pantalla 
si los mismos se encuentran ordenados de forma decreciente . 

*/

int num1, num2, num3, num4;

Console.WriteLine("Ingrese un numero: ");
num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese un numero: ");
num2 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese un numero: ");
num3 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese un numero: ");
num4 = int.Parse(Console.ReadLine());

if (num1 > num2 && num2 > num3 && num3>num4)
{
    Console.WriteLine("Los numeros están ordenados de forma decreciente: " + num1 + " " + num2 + " " + num3 + " "+ num4);
 
}else{
    Console.WriteLine("Los números no están ordenados de forma decreciente ");
 
}

/* FORMA MAL

if (num1 > num2)
{
    if(num2 > num3)
    {
        if (num3 > num4)
        {
            Console.WriteLine("Los numeros están ordenados de forma decreciente: " + num1 + " " + num2 + " " + num3 + " "+ num4);
        }else{
            Console.WriteLine("Los números no están ordenados de forma decreciente ");
        }
    }else{
        Console.WriteLine("Los números no están ordenados de forma decreciente ");

    }
}else{
    Console.WriteLine("Los números no están ordenados de forma decreciente ");

}

*/

