/*

3. Una importante marca de computadoras permite elegir cierta configuración del equipo a comprar. 
Para ello existe la siguiente escala de precios:
	        i5 (1) 	    i7 (2) 	    i9 (3)
8 RAM (1) 	USD 800 	USD 900 	USD 1200
16 RAM (2) 	USD 900 	USD 1000 	USD 1400
32 RAM (3) 	USD 1000 	USD 1400 	USD 2000

Además, el equipo viene con un disco que permite almacenar 500 GB de información y que se puede ampliar 
a 1 TB si así lo desea, lo cual tiene un costo  adicional de USD 300. Hacer un programa que solicite 
la opción de procesador, la opción de memoria  RAM, y si extiende el disco o no (ingresa 1 para extender  
y 0 para no extender) y calcule y emita por pantalla el monto de la máquina seleccionada.

*/

int procesador, memoria, precio, opcion;
Console.WriteLine("Que procesador desea comprar. Opcion 1 i5 - Opcion 2 i7 - Opcion 3 i9");
procesador = int.Parse(Console.ReadLine());

switch (procesador)
{
    case 1:
        Console.WriteLine("Que memoria desea comprar. Opcion 1 8GB - Opcion 2 16GB - Opcion 3 32GB");
        memoria = int.Parse(Console.ReadLine());
        switch (memoria)
        {
            case 8:
                precio = 800;
                Console.WriteLine("Desea ampliar la memoria a 1TB? 1 - SI | 2 - NO");
                opcion = int.Parse(Console.ReadLine());
                if (opcion == 1)
                {
                    precio = precio + 300;
                    Console.WriteLine("El precio de su computadora es de: " + precio);

                }
                else
                {
                    Console.WriteLine("El precio de su computadora es de: " + precio);
                }
                break;

            case 16:
                precio = 900;
                Console.WriteLine("Desea ampliar la memoria a 1TB? 1 - SI | 2 - NO");
                opcion = int.Parse(Console.ReadLine());
                if (opcion == 1)
                {
                    precio = precio + 300;
                    Console.WriteLine("El precio de su computadora es de: " + precio);

                }
                else
                {
                    Console.WriteLine("El precio de su computadora es de: " + precio);
                }
                break;

            case 32:
                precio = 1000;
                Console.WriteLine("Desea ampliar la memoria a 1TB? 1 - SI | 2 - NO");
                opcion = int.Parse(Console.ReadLine());
                if (opcion == 1)
                {
                    precio = precio + 300;
                    Console.WriteLine("El precio de su computadora es de: " + precio);

                }
                else
                {
                    Console.WriteLine("El precio de su computadora es de: " + precio);
                }
                break;

            default:
                Console.WriteLine("La opción elegida es incorrecta");
                break;
        }
        break;

    case 2:
        Console.WriteLine("Que memoria desea comprar. Opcion 1 8GB - Opcion 2 16GB - Opcion 3 32GB");
        memoria = int.Parse(Console.ReadLine());
        switch (memoria)
        {
            case 8:
                precio = 900;
                Console.WriteLine("Desea ampliar la memoria a 1TB? 1 - SI | 2 - NO");
                opcion = int.Parse(Console.ReadLine());
                if (opcion == 1)
                {
                    precio = precio + 300;
                    Console.WriteLine("El precio de su computadora es de: " + precio);

                }
                else
                {
                    Console.WriteLine("El precio de su computadora es de: " + precio);
                }
                break;

            case 16:
                precio = 1000;
                Console.WriteLine("Desea ampliar la memoria a 1TB? 1 - SI | 2 - NO");
                opcion = int.Parse(Console.ReadLine());
                if (opcion == 1)
                {
                    precio = precio + 300;
                    Console.WriteLine("El precio de su computadora es de: " + precio);

                }
                else
                {
                    Console.WriteLine("El precio de su computadora es de: " + precio);
                }
                break;

            case 32:
                precio = 1400;
                Console.WriteLine("Desea ampliar la memoria a 1TB? 1 - SI | 2 - NO");
                opcion = int.Parse(Console.ReadLine());
                if (opcion == 1)
                {
                    precio = precio + 300;
                    Console.WriteLine("El precio de su computadora es de: " + precio);

                }
                else
                {
                    Console.WriteLine("El precio de su computadora es de: " + precio);
                }
                break;

            default:
                Console.WriteLine("La opción elegida es incorrecta");
                break;
        }
        break;

    case 3:
        Console.WriteLine("Que memoria desea comprar. Opcion 1 8GB - Opcion 2 16GB - Opcion 3 32GB");
        memoria = int.Parse(Console.ReadLine());
        switch (memoria)
        {
            case 8:
                precio = 1200;
                Console.WriteLine("Desea ampliar la memoria a 1TB? 1 - SI | 2 - NO");
                opcion = int.Parse(Console.ReadLine());
                if (opcion == 1)
                {
                    precio = precio + 300;
                    Console.WriteLine("El precio de su computadora es de: " + precio);

                }
                else
                {
                    Console.WriteLine("El precio de su computadora es de: " + precio);
                }
                break;

            case 16:
                precio = 1400;
                Console.WriteLine("Desea ampliar la memoria a 1TB? 1 - SI | 2 - NO");
                opcion = int.Parse(Console.ReadLine());
                if (opcion == 1)
                {
                    precio = precio + 300;
                    Console.WriteLine("El precio de su computadora es de: " + precio);

                }
                else
                {
                    Console.WriteLine("El precio de su computadora es de: " + precio);
                }
                break;

            case 32:
                precio = 2000;
                Console.WriteLine("Desea ampliar la memoria a 1TB? 1 - SI | 2 - NO");
                opcion = int.Parse(Console.ReadLine());
                if (opcion == 1)
                {
                    precio = precio + 300;
                    Console.WriteLine("El precio de su computadora es de: " + precio);

                }
                else
                {
                    Console.WriteLine("El precio de su computadora es de: " + precio);
                }
                break;

            default:
                Console.WriteLine("La opción elegida es incorrecta");
                break;
        }
        break;

    default:
        Console.WriteLine("La opción elegida es incorrecta");
        break;
}
