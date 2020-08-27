using System;
//métodos e variáveis Static

class Calculos{
    public static double pi=3.14;
    public static int dobro(int n){
        return n*2;
    }
    public static int triplo(int n){
        return n*3;
    }
    public static int quadruplo(int n){
        return n*4;
    }
    public static int quintuplo(int n){
        return n*5;
    }
}
class Aula49{
    static void Main(){
        double vpi=Calculos.pi;
        int n;

        Console.WriteLine("o valor de pi é: {0}",Calculos.pi);
        Console.WriteLine("\nDigite um número: ");
        n=int.Parse(Console.ReadLine());
        Console.WriteLine("O dobro de {0} é {1}, o triplo é {2}, o quádruplo é {3}, o quíntuplo é {4}.",n,Calculos.dobro(n),Calculos.triplo(n),Calculos.quadruplo(n),Calculos.quintuplo(n));
    }
}