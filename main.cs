using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Digite o raio de um círculo: ");
    double n = double.Parse(Console.ReadLine());

    Console.WriteLine("Área é = " + (n*n) * 3.14 );
  }
}