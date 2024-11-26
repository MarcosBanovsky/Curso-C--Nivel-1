/*

5. Hacer un programa que solicite 20 números y luego emitir por pantalla el máximo 
de los números pares y el mínimo de los números impares.

*/

int num = 0;
int mayorPares = 0;
int mayorImpares = 0;

for (int n = 0; n < 20; n++){
    Console.WriteLine("Ingrese un numero: ");
    num = int.Parse(Console.ReadLine()); 
    if (num % 2 == 0){
        if(num > mayorPares){
            mayorPares = num;
        }
    }else{
        mayorImpares = num;
    }
}

Console.WriteLine("El mayor de los números pares es: " + mayorPares);
Console.WriteLine("El mayor de los números impares es: " + mayorImpares);