using System;
// Classes e Objetos

public class Player{ // por padrão as classes são publicas a não ser que se especifique.
    public int hp=0;
    public string vivo, morto;
}
class Aula28{
    static void Main(){
        Player p1=new Player();

        if(p1.hp<1){
            p1.morto="morto";
            Console.WriteLine("Hp do player 1 é de: {0}%. Ele está {1}.",p1.hp, p1.morto);
        }else{
            p1.vivo="vivo";
            Console.WriteLine("Hp do player 1 é de: {0}%. Ele está {1}.",p1.hp, p1.vivo);
        }              
    }
}