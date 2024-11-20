namespace ejercicio
{
class Program
{

    static void Main(string[] args)
    {
        double num1;
        Console.WriteLine("Ingrese un número");
        num1 = double.Parse(Console.ReadLine());
        double qubeElevated = Math.Pow(num1, 3);
        Console.WriteLine("El numero ingresado " + num1 + " elevado al cubo es: " + qubeElevated);
    }
}

}
