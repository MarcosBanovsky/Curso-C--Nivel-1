/*

1. Hacer un programa que solicite 10 números enteros y los guarde en un vector. 
    Luego recorrer los elementos y determinar e informar cuál es el valor máximo 
    y su posición dentro del vector.

*/



int[] numero = new int[10];

for (int i = 0; i <= 9; i++)
{
    Console.WriteLine("Ingrese un número: ");
    numero[i] = int.Parse(Console.ReadLine());
}

int mayor = 0;
int posición = 0;

for (int i = 0; i <= 9; i++)
{
    if (numero[i]>mayor)
    {
        mayor = numero[i];
        posición = i;
    }
}
Console.WriteLine("El maximo valor dentro del vector es: " + mayor + " y se encuentra en la posición: " + posición);
