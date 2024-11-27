/*

3. Hacer un programa para recibir listas de números positivos que están separadas entre sí por un cero. 
El fin de la carga se notifica con un número negativo. Luego mostrar cuántos números tiene cada lista.

*/

int n, conNumLista;

n = int.Parse(Console.ReadLine());
while (n != 0)
{
    conNumLista = 0;
    while (n > 0)
    {
        n = int.Parse(Console.ReadLine());
        conNumLista++;
    }
    Console.WriteLine("Esta lista tiene: " + conNumLista + " numeros");
    n = int.Parse(Console.ReadLine());
}