/*

4. Hacer un programa para ingresar tres números y emitir un cartel aclaratorio 
si la suma de los dos primeros es mayor al producto del segundo con el tercero.

*/
int num1, num2, num3, resultadoSuma, resultadoProducto;
Console.WriteLine("Ingrese el primer numero");
num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el segundo numero");
num2 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el tercer numero");
num3 = int.Parse(Console.ReadLine());

resultadoSuma = num1 + num2;
resultadoProducto = num2 * num3;

if (resultadoSuma > resultadoProducto){
    Console.WriteLine("La suma de los dos primeros es mayor al producto del segundo con el tercero");
}else{
    Console.WriteLine("La suma de los dos primeros no es mayor al producto del segundo con el tercero");
}