/*
Para se preparar para os outros problemas, vamos fazer um teste. Dado um número X, retorne o menor número par maior do que X.

Entrada
Uma linha contendo um número  0 < X < 107.

Saída
Uma linha contendo a resposta do problema.
*/

using System; 

class SucessorPar {

    static void Main(string[] args) { 
        int x = int.Parse(Console.ReadLine());      
        if (x > 0 && x < 107) { if(x % 2 ==0) {x = x + 2;} else{x = x + 1;}Console.WriteLine(x);}
    }
}