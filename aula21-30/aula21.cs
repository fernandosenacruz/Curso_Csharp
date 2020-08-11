using System;
// Do While
class Aula21{
    static void Main(){
        string senha= "nandinha", senhaConsole;
        int tentativas=0;
       
        do{
            Console.WriteLine("Digite a senha: ");
            senhaConsole=Console.ReadLine();
            tentativas++;
            Console.WriteLine("Senha incorreta!\nTentativa: {0}", tentativas);            
        }while(senha!=senhaConsole && tentativas<=4);
        
        if(tentativas==4 && senha!=senhaConsole){
            Console.WriteLine("Você excedeu ao números de tentativas.");
        }else{
            Console.Clear();
            Console.WriteLine("Senha correta!\nTentativas: {0}", tentativas);
        }
    }
}