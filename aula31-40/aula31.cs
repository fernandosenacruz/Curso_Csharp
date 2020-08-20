using System;
// Static class
// classes staticas não permitem instaciação de objetos nem permitem contrutores.
// Todos os membros de uma classa static devem ser obrigatroriamente statics.
static public class Jogador{
    static public int hp;
    static public bool vivo;
    static public string nome;

    static public void iniciar(string n){
        hp=100;
        vivo=true;
        nome=n;
    }
    static public Jogador(string n){
        hp=100;
        vivo=true;
        nome=n;
    }
    static public void Info(){
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