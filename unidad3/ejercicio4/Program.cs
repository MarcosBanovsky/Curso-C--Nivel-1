/* 

4. Hacer un programa para ingresar cuatro números distintos 
y luego mostrar por pantalla el menor de ellos.

*/

int n1, n2, n3, n4, menor;

menor = 999999;

Console.WriteLine("Ingrese 4 numeros");
n1 = int.Parse(Console.ReadLine());
n2 = int.Parse(Console.ReadLine());
n3 = int.Parse(Console.ReadLine());
n4 = int.Parse(Console.ReadLine());

if (n1 < n2)
    menor = n1;
else
    menor = n2;
if (n3 < menor)
    menor = n3;

if (n4 < menor)
    menor = n4;
Console.WriteLine("el menor es: " + menor);




