/*

3. Hacer un programa que solicite 20 edades y luego calcule el promedio de edad 
de aquellas personas mayores a 18 años.

*/

int edad = 0;
int acuEdad = 0;
int contMayores = 0;

for(int e = 0; e < 20; e++){
    Console.WriteLine("Ingrese una edad: ");
    edad = int.Parse(Console.ReadLine());
    if(edad > 18){
        acuEdad = acuEdad + edad;
        contMayores = contMayores + 1;
    }
}

Console.WriteLine("El promedio de edad de los mayores de 18 es: " + acuEdad/contMayores);