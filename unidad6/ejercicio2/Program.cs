/*

2. Se dispone de una lista de 5 listas de números enteros separados entre ellos por ceros. 
Se pide determinar e informar:

    El número de grupo con mayor porcentaje de números impares respecto al total de números 
    que forman el grupo.
    
    Informar cuántos grupos están formados por todos números ordenados de mayor a menor.

*/

using System.Security.Cryptography.X509Certificates;

int n, contNumeros, contImpares, grupoImparesMaximo=0, min, conOrdenados=0;
double porcImpares, porcentajeMaximo=-1;
bool banderaOrdenados;

for (int i = 0; i < 5; i++)
{
    contNumeros = 0;
    contImpares = 0;
    banderaOrdenados = true;
    n = int.Parse(Console.ReadLine());
    min = n;
    while (n != 0)
    {
        contNumeros++;
        if (n % 2 != 0)
        {
            contImpares++;
        }

        if (n <= min)
        {
            min = n;
        }else{
            banderaOrdenados = false;
        }

        n = int.Parse(Console.ReadLine());

    }
    porcImpares = contImpares * 100 / contNumeros;
    if(porcImpares > porcentajeMaximo){
        porcentajeMaximo = porcImpares;
        grupoImparesMaximo = i + 1;
    }
    
    if (banderaOrdenados)
    {
        conOrdenados++;
    }
   Console.WriteLine("El grupo con mayor porcentaje de impares es: " + grupoImparesMaximo);
} 

