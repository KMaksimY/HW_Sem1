// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

class Program {
    static void Main(string[] args) {
        Console.Write("Put the number of the day of the week: ");
        int day = int.Parse(Console.ReadLine());
        if (day < 1 || day > 7) {
            Console.WriteLine("Errore: put the numbre between 1 and 7");
        }
        else if (day == 6 || day == 7) {
            Console.WriteLine("Weekend");
        }
        else {
            Console.WriteLine("Working day");
        }
    }
}