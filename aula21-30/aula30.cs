using System;
// Sobrecarga de Construtores
public class Jogador{
    public int hp;
    public bool vivo;
    public string nome;

    public Jogador(){
        hp=100;
        vivo=true;
        nome="Renatófolis";
    }
    public Jogador(string n){
        hp=100;
        vivo=true;
        nome=n;
    }
    public Jogador(string n, int Hp){
        hp=Hp;
        vivo=true;
        nome=n;
    }
    public Jogador(string n, int Hp, bool live){
        hp=Hp;
        vivo=live;
        nome=n;
    }
    public void Info(){
        Console.WriteLine("Jogador: {0}", nome);
        Console.WriteLine("HP.....: {0}", hp);
        Console.WriteLine("Status.: {0}\n", vivo);
    }
}
class Aula30{
    static void Main(){
        Jogador p1=new Jogador();
        Jogador p2=new Jogador("Ximira");
        Jogador p3=new Jogador("Asdrubal",100);
        Jogador p4=new Jogador("Birunda",70,true);
        Jogador p5=new Jogador("Estáquio",0,false);

        p1.Info();
        p2.Info();
        p3.Info();
        p4.Info();
        p5.Info();

    }
}