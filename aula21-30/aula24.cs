using System;
// Métodos para array parte2
class Aula24{
    static void Main(){
        int v1, v2;
        
        Console.Write("Digite o primeiro valor: ");
        v1=Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite o segundo valor: ");
        v2=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("A soma de {0} e {1} é: {2}.",v1,v2,Soma(v1,v2));
    }
    static int Soma(int n1, int n2){
        int resultado=n1+n2;
        return resultado;
    }
}