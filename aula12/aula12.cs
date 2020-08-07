using System;
class Aula12{
    static void Main(){
        int av1, av2, av3, resultado;
        string situacao;
        situacao="Reprovado!";

        Console.Write("Digite a nota da av1: ");
        av1=int.Parse(Console.ReadLine());
        Console.Write("Digite a nota da av2: ");
        av2=int.Parse(Console.ReadLine());
        Console.Write("Digite a nota da av3: ");
        av3=int.Parse(Console.ReadLine());
        
        resultado=(av1+av2+av3)/3;
        
        if(resultado>=7){
            situacao="Aprovado!";
        }
    
        Console.WriteLine("Resultado final: {0}. {1}", resultado,situacao);
    }
}