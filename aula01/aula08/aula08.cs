using System;
// retorno do console
class Aula08{
    static void Main(){
        double nota1, nota2, media;
        string nome, resultado;
        resultado="Situação: aprovado(a).";
        
        Console.Write("Digite seu nome do aluno: ");
        nome=Console.ReadLine();
        Console.WriteLine("O nome digitado foi: {0}", nome);
        
        Console.WriteLine("Digite a nota 1: ");
        nota1=double.Parse(Console.ReadLine()); // 1 forma de converter string em double
        Console.WriteLine("A nota digitada foi: {0}",nota1);
        
        Console.WriteLine("Digite a nota 2: ");
        nota2=Convert.ToDouble(Console.ReadLine()); // 2 forma de converter string em double
        media= (nota1+nota2)/2;
        if(media<=7.0){
            resultado="Situação: reprovado(a).";            
        }
        Console.WriteLine("A média do(a) aluno(a) foi: {0}\n{1} ", media,resultado);
    
        }
}