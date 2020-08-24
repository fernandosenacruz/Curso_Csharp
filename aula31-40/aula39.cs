using System;
//Classes e Métodos abstract


abstract class Veiculo{ // não podem ser instaciadas, somete herdadas.
     protected int velMax, velAtual;
     protected bool ligado;
     public Veiculo(){
         ligado=false;
         velMax=0;
     }
     public void setLigado(bool ligado){
         this.ligado=ligado;
     }
     public int getVelAtual(){
         return velAtual;
     }
     abstract public void aceleracao(int mult);
}

class Carro:Veiculo{
    public Carro(){
        velMax=160;
    }
    override public void aceleracao(int mult){
        velAtual+=10*mult;
    }
}
class Aula39{
    static void Main(){

        Carro fusca=new Carro();

        fusca.aceleracao(5);
        fusca.aceleracao(-1);

        Console.WriteLine(fusca.getVelAtual());
    }
}