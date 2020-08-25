using System;
// propriedade acessors get e set
// permite obter, alterar e acessar dados

class Carro{
    private int velMax;
    public Carro(){
        this.velMax=160;
    }
    public int vMax{
        get{
            return velMax;
        }
        set{
            if(value<=0){
                velMax=0;
            }else if(value>=180){
                velMax=180;
            }else{
                velMax=value;
            }
        }
    }
}

class Aula41{
    static void Main(){

        Carro fusca=new Carro();

        fusca.vMax=200;
        Console.WriteLine("Velocidade: {0}km/h.",fusca.vMax);
    }
}