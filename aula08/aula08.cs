using System;
class Aula08{
    static void Main(){
        double nota1, nota2, media;
        string nome;
        
        Console.Write("Digite seu nome do aluno: ");
        nome=Console.ReadLine();
        Console.WriteLine("O nome digitado foi: {0}", nome);
        
        Console.WriteLine("Digite a nota 1: ");
        nota1=double.Parse(Console.ReadLine()); // 1 forma de converter string em double
        Console.WriteLine("A nota digitada foi: {0}",nota1);
        
        Console.WriteLine("Digite a nota 2: ");
        nota2=Convert.ToDouble(Console.ReadLine()); // 2 forma de converter string em double
        media= (nota1+nota2)/2;
        Console.WriteLine("A média do aluno foi: {0} ", media);
    
        }
}