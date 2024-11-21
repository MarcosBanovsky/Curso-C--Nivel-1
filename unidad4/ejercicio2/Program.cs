/*

2. Un importante negocio de desinfectante líquido realiza descuentos dependiendo de la cantidad de litros 
vendidos según la siguiente escala:

            Si vende menos de 100 litros, no hay descuento.
            Si vende entre 101 y 300 litros, el descuento es del 10%.
            Si vende entre 301 y 500 litros, el descuento es del 15%.
            Finalmente, si la venta es de más de 500 litros, el descuento es del 25%.

Hacer un programa que solicite el ingreso del importe total de la venta y la cantidad de litros vendidos 
y calcule y emita el importe con el descuento  aplicado..

*/

int litros;
float venta;
float precioDescuento;
Console.WriteLine("Ingrese importe de venta: ");
venta = float.Parse(Console.ReadLine());
Console.WriteLine("Ingrese Litros vendidos: ");
litros = int.Parse(Console.ReadLine());

if (litros > 100 && litros <=300) 
{
    precioDescuento = venta - ((venta * 10)/100);
    Console.WriteLine("El precio con descuento es: " + precioDescuento);
}else if (litros > 300 && litros <=500)
{
    precioDescuento = venta - ((venta * 15)/100);
    Console.WriteLine("El precio con descuento es: " + precioDescuento);

}else if (litros > 500)
{
    precioDescuento = venta - ((venta * 25)/100);
    Console.WriteLine("El precio con descuento es: " + precioDescuento);  
}else
{
    precioDescuento = venta;
    Console.WriteLine("El precio no tiene descuento: " + precioDescuento);  

}

