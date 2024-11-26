/* 

2. Hacer un programa que solicite el ingreso de 10 números y que muestre el mayor de ellos por pantalla. 
Solo se debe emitir UN valor por pantalla.

*/

int num = 0;
int mayor = 0;

for (int n = 0; n < 10; n++){
    Console.WriteLine("Ingrese un numero: ");
    num = int.Parse(Console.ReadLine());
    if(num > mayor){
        mayor = num;
    }

}

Console.WriteLine("El mayor de los numeros ingresados es: " + mayor);