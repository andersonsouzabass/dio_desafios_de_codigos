using System;

namespace DIO
 {
   class Program
   {
    static void Main(string[] args)
    {
      string[] input = Console.ReadLine().Split(' ');
      double avg = double.Parse(input[0]) * 2;
       avg += double.Parse(input[1]) * 3;
       avg += double.Parse(input[2]) * 4;
       avg += double.Parse(input[3]);
       
       avg /= 10;
      
      Console.WriteLine("Media: " + avg.ToString("0.0"));
      
      if (avg >= 7) {
        Console.WriteLine("Aluno aprovado.");
      } else if (avg < 5) {
        Console.WriteLine("Aluno reprovado.");
      } else if (avg <= 6.9) {
        double e = double.Parse(Console.ReadLine());
        
        Console.WriteLine("Aluno em exame.");
        Console.WriteLine("Nota do exame: " + e.ToString("0.0"));
        avg = (avg + e) / 2;
        
        if (avg >= 5) {
          Console.WriteLine("Aluno aprovado.");
        } else {
          Console.WriteLine("Aluno reprovado");
        }
        Console.WriteLine("Media final: " + avg.ToString("0.0"));
      }
      Console.ReadKey();
    }
  }
}