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
    static public void Info(){
        Console.WriteLine("Jogador: {0}", nome);
        Console.WriteLine("HP.....: {0}", hp);
        Console.WriteLine("Status.: {0}\n", vivo);
        }
}
static class inimigo{
    public bool alerta;
    public string nome;
    public inimigo(string n){
        alerta=false;
        nome=n;
    }
    public void info(){
        Console.WriteLine(nome);
        Console.WriteLine(alerta);
        Console.WriteLine("\n");
        }
    }
class Aula30{
    static void Main(){
        Jogador.iniciar("Ximira");
        Jogador.Info(); 

        Inimigo vilao1=new Inimigo("Freezar");
        Inimigo vilao2=new Inimigo("Moro");
        Inimigo vilao3=new Inimigo("Maginboo");

        vilao1.info();
        vilao2.info();
        vilao3.info();  
    }
}