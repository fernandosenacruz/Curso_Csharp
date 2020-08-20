using System;
// private
class Jogador{
    private int hp;
    private string nome;
    public Jogador(string nome){
        this.nome=nome;
        hp=100;
    }
    public int getHp(){
        return hp;
    }
    public string getNome(){
        return nome;
    }
    public void setHp(int Hp){
        if(hp<0){
            if(hp+Hp<0){
                hp=0;
            }else{
                hp+=Hp;
            }
        }else if(hp>0){
            if(hp+Hp>100){
                hp=100;
            }else{
                 hp+=Hp;
            }         
        }
    }
}

class aula33{
    static void Main(){
        Jogador player1=new Jogador("Ximira");

        player1.setHp(-30);
        player1.setHp(-40);
        player1.setHp(-50);


        Console.WriteLine("Nome do char: {0}",player1.getNome());
        Console.WriteLine("HP: {0}",player1.getHp());
    }
}