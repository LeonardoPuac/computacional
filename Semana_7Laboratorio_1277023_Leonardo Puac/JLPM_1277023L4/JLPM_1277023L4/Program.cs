namespace JLPM_1277023L4;

{
    internal class Program
{
    static void Main(string[] args)

    {
        //Operaciones Aritmeticas 
        Console.WriteLine("Ejercicio 1: Operaciones aritmeticas ");
        Console.WriteLine("ingrese un numero entero");
        string numero1 = Console.ReadLine();
        int num1 = Convert.ToInt32(numero1);

        Console.WriteLine("ingrese otro numero entero");
        string numero2 = Console.ReadLine();
        int num2 = Convert.ToInt32(numero2);

        Console.WriteLine("ingrese otro numero entero");
        string numero3 = Console.ReadLine();
        int num3 = Convert.ToInt32(numero3);

        Console.WriteLine("Suma" + num1 + "+" + num2 + " = " + (num1 + num2));
        Console.WriteLine("Resta" + num1 + "-" + num2 + " = " + (num1 - num2));
        Console.WriteLine("Multiplicacion" + num1 + "*" + num2 + " = " + (num1 * num2));
        Console.WriteLine("Divicion" + num1 + "/" + num2 + " = " + (num1 / num2));
        Console.WriteLine("Residuo" + num1 + "%" + num2 + " = " + (num1 % num2));


        Console.WriteLine("Ejercicio 2: Operaciones booleanas ");


        if (num1 > num2)
        {
            Console.WriteLine(num1 + " es mayor que " + num2);
        }
        else if (num1 < num2)
        {
            Console.WriteLine(num1 + " es menor que " + num2);
        }
        else
            Console.WriteLine("Los numeros son iguales");



        Console.WriteLine("Ejercicio 3: Jerarquia de operaciones ");


        Console.WriteLine("Operacion 2 " + " = " + ((num2 * num3) + num1));
        Console.WriteLine("Operacion3 " + " =" + (num1 / (num2 * num3)));
        Console.ReadLine();



    }

}

}

