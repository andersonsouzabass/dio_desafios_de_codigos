using System;

namespace Start
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d,avg;
            double p1, p2, p3, p4;
            p1 = 2;
            p2 = 3;
            p3 = 4;
            p4 = 1;
            string[] values = Console.ReadLine().Split(' ');
            a = double.Parse(values[0]);
            b = double.Parse(values[1]);
            c = double.Parse(values[2]);
            d = double.Parse(values[3]);
            
            avg = ((a*p1)+(b*p2)+(c*p3)+(d*p4))/(p1+p2+p3+p4); // Cálculo da média ponderada
            
            Console.WriteLine("Media: " +avg.ToString("0.0"));
            if (avg >= 7)
            {
                Console.WriteLine("Aluno aprovado.");
            }
            if (avg < 5)
            {
                Console.WriteLine("Aluno reprovado.");
            }
            if (avg < 7 && avg >= 5)
            {
                Console.WriteLine("Aluno em exame.");
                double e = double.Parse(Console.ReadLine());
                Console.Write("Nota do exame: " +e.ToString("0.0"));
                
                avg = (avg + e) / 2;
                
                if (avg >=5)
                {
                    Console.WriteLine("Aluno aprovado.");
                }
                if (avg<5)
                {
                    Console.WriteLine("Aluno reprovado.");
                }
                Console.WriteLine("Media final: " +avg.ToString("0.0"));
            }

            Console.ReadKey();
        }
    }
}