using System;
// Sobrecarga de métodos

public class Calc{
    public int soma(int n1, int n2){
        return n1+n2;
    }
    public int soma(int n1, int n2,int n3){ //sobrecarga de método
        return n1+n2+n3;
    }
    public int soma(params int[]n){
        int s=0;
        for(int i=0;i<n.Length;i++){
            s+=n[i];
        }
        return s;
    }
}
class Aula47{
    static void Main(){
        int n1,n2,res;
        Calc somar=new Calc();

        Console.WriteLine("Digite 1 valor: ");
        n1=int.Parse(Console.ReadLine());
        Console.WriteLine("Digite 2 valor: ");
        n2=int.Parse(Console.ReadLine());
        res=somar.soma(n1,n2);
        Console.WriteLine("O resultado da soma de {0} e {1} foi: {2}.",n1,n2,res);

        res=somar.soma(50,10,1);
        Console.WriteLine("\nO resultado da sobrecarga do método soma foi: {0}.",res);

        res=somar.soma(10,33,14,75,80,-100,50);
        Console.WriteLine("\nO resultado da sobrecarga do método soma com número de argumento indefinidos foi: {0}.",res);
    }
}