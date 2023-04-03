// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


using System;

class Program {
    static void Main(string[] args) {
        Console.Write("Введите трехзначное число: ");
        int number = int.Parse(Console.ReadLine());
        int secondDigit = (number/10) % 10;
        Console.WriteLine("2nd number is: " + secondDigit);
    }
}
