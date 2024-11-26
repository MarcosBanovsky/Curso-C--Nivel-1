
int num, con, conPrimos=0;

for (int i = 0; i < 10; i++)
{
    Console.Write("Ingrese un numero: ");
    num = int.Parse(Console.ReadLine());
    con = 0;
    for (int j = 0; j < num; i++)
    {
        if (num % j == 0){
            con++;
        }
    }
    if (con == 2)
    {
        conPrimos++;
    }
}
Console.WriteLine("La cantidad de numeros primos es: " + conPrimos);