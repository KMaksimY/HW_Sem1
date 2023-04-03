// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


using System;

class Program {
    static void Main(string[] args) {
        Console.Write("Введите трехзначное число: ");
        int number = int.Parse(Console.ReadLine());
        if (number>99) {

          int thirdDigit = (number/10) % 10;
      
        Console.WriteLine("3nd number is: " + thirdDigit);      
          
        }
        else{
        Console.WriteLine("Put the number more then 99");
    }
}
}