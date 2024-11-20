/*

5. Hacer un programa para ingresar cuatro números y luego mostrar por pantalla cuáles son mayores a 100.

*/

int num1, num2, num3, num4, con = 0;
Console.WriteLine("Ingrese 4 numeros");
num1 = int.Parse(Console.ReadLine());
num2 = int.Parse(Console.ReadLine());
num3 = int.Parse(Console.ReadLine());
num4 = int.Parse(Console.ReadLine());

if (num1 > 100){
    Console.Write(num1+"\t");
    con++;
}
if (num2 > 100){
    Console.Write(num2+"\t");
    con++;
}
if (num3 > 100){
    Console.Write(num3+"\t");
    con++;
}
if (num4 > 100){
    Console.Write(num4+"\t");
    con++;
}

if (con !=0)
{
    Console.WriteLine("Son numeros mayores a 100");
}
