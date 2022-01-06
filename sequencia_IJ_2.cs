/*
Você deve fazer um programa que apresente a sequencia conforme o exemplo abaixo.

Entrada
Não há nenhuma entrada neste problema.

Saída
Imprima a sequencia conforme exemplo abaixo
*/

using System; 

class Sequencia_IJ_2 {
    static void Main(string[] args) { 
     for(int i = 1;i <= 9; i += 2)
      {
        for(int a = 7; a >= 5; a -= 1)    //escreva seu código nos espaços em branco
        {
          string b = "I=" + i + " J=" + a;
          Console.WriteLine(b);
        }
      }
    }
}