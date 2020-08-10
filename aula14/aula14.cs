using System;
// if aninhado( if dentro de if)
class Aula14{
        static void Main(){
        int av1, av2, av3, resultado;
        string situacao;
        
        Console.Write("Digite a nota da av1: ");
        av1=int.Parse(Console.ReadLine());
        Console.Write("Digite a nota da av2: ");
        av2=int.Parse(Console.ReadLine());
        Console.Write("Digite a nota da av3: ");
        av3=int.Parse(Console.ReadLine());
        
        resultado=(av1+av2+av3)/3;
        
        if(resultado>=7){
            if(resultado>=9){
                situacao="Laureado!";
            }else{
                situacao="Aprovado!";
            }
        }else{
            if(resultado>=4){
                situacao="Recuperação!";
            }else{
                situacao="Reprovado!";
            }
        }
        if(resultado>10){
            situacao="Nota inválida!";
        }

        Console.WriteLine("Resultado final: {0}. {1}", resultado,situacao);
    }
}