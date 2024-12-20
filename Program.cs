using System;
class Program{
    static void Main(){
        Console.WriteLine("Enter two numbers");
        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Sum:" + (num1 + num2));
        Console.WriteLine("Difference:" + (num1 - num2));
        Console.WriteLine("product :2" + (num1*num2));
        Console.WriteLine("Division:" + (num1 / num2));
    }
}
