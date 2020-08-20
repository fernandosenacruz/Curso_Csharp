using System;
// Construtores e Destrutores

public class Alunos{
    public string nome;
    public Alunos(string nome){ // construtor
        nome=nome;
    }
    ~Alunos(){
        Console.WriteLine("Aluno {0} excluído", nome);
    }
}
class Aula29{
    static void Main(){
        string nome;
        Console.WriteLine("Digite o nome do(a) aluno(a): ");
        nome=Console.ReadLine();
        
        Alunos a1=new Alunos(nome);
        Alunos a2= new Alunos("Ximira");
        
        Console.WriteLine("{0} teve nota: {1}",a1.nome);
        Console.WriteLine("{0} teve nota: {1}",a2.nome);        
    }
}