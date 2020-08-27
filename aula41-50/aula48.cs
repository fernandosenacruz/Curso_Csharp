using System;
// Recursividade -> quando uma função chama ela mesma   

public class Calc{// uso da recursividade
    public int fatorial(int n){
        int res;
        if(n<=1){
            res=1;
        }else{
            res=n*fatorial(n-1);
        }
        return res;
    }
    
}
class Aula48{
    static void Main(){
        int n1,res;
        Calc somar=new Calc();

        Console.WriteLine("Digite fatorial: ");
        n1=int.Parse(Console.ReadLine());
        res=somar.fatorial(n1);
        Console.WriteLine("O fatorial de {0} é: {1}.",n1,res);
    }
}