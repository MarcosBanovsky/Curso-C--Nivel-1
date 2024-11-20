/* 
    3. Una casa de video juegos otorga un descuento dependiendo del importe de la 
    compra realizada según los siguientes valores:

    Si el importe es menor a ARS 1000, no hay descuento.
    Si el importe es ARS 1000 o más pero menor a ARS 5000, aplica un descuento del 10%.
    Si el importe es ARS 5000 o más, aplica un descuento del 18%.

    Hacer un programa para ingresar un importe de venta y luego muestre por pantalla 
    el importe final con el descuento que corresponda.
*/

double saleAmount = 0, saleDiscounted = 0;

Console.WriteLine("Ingrese monto de la venta: ");
saleAmount = double.Parse(Console.ReadLine());

if (saleAmount >= 5000){
    Console.WriteLine("Obtienes un descuento del 18%");
    saleDiscounted = (saleAmount*0.82);
    Console.WriteLine("El precio con descuento es de " + "$" + saleDiscounted);
}else if (saleAmount >=1000 & saleAmount < 5000){
    Console.WriteLine("Obtienes un descuento del 10%");
    saleDiscounted = (saleAmount*0.90);
    Console.WriteLine("El precio con descuento es de " + "$" + saleDiscounted);
}else{
    Console.WriteLine("No obtienes descuento");
    Console.WriteLine("El precio es de " + "$" + saleAmount);
}
    

