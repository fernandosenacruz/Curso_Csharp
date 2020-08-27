using System;
// Delegates -> objeto que faz referência a um método.

delegate int Operacoes(int n1, int n2);
delegate double Operacoes2(double v1, double v2);

class Calculos{
    public static int somar(int n1, int n2){
        return n1+n2;
    }
    public static int multiplicar(int n1, int n2){
        return n1*n2;
    }
    public static double dividir(double v1, double v2){
        return v1/v2;
    }
}
class Aula50{
    static void Main(){
        int n1, n2, res;
        double v1,v2,res2;

        Operacoes op=new Operacoes(Calculos.somar);
        Console.WriteLine("Digite um valor: ");
        n1=int.Parse(Console.ReadLine());
        Console.WriteLine("Digite outro valor: ");
        n2=int.Parse(Console.ReadLine());
        res=op(n1,n2);
        Console.WriteLine("A soma de {0} e {1} é: {2}",n1,n2,res);

        op=new Operacoes(Calculos.multiplicar);
        Console.WriteLine("Digite um valor: ");
        n1=int.Parse(Console.ReadLine());
        Console.WriteLine("Digite outro valor: ");
        n2=int.Parse(Console.ReadLine());
        res=op(n1,n2);
        Console.WriteLine("A multiplicação entre {0} e {1} é: {2}",n1,n2,res);

        Operacoes2 op2=new Operacoes2(Calculos.dividir);
        Console.WriteLine("Digite um valor: ");
        v1=double.Parse(Console.ReadLine());
        Console.WriteLine("Digite outro valor: ");
        v2=double.Parse(Console.ReadLine());
        res2=op2(v1,v2);
        Console.WriteLine("A divisão entre {0} e {1} é: {2}",v1,v2,res2);
    }
}