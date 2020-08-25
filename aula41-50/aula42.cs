using System;
// Indexadores de classes
// permite o objeto ser utilizado como um array

class Carro{
    private int[] velMax=new int [5]{80,140,120,100,163};
    public Carro(){
        
    }
    public int this[int i]{
        get{
            return velMax[i];
        }
        set{
            if(value<=0){
                velMax[i]=0;
            }else if(value>=180){
                velMax[i]=180;
            }else{
                velMax[i]=value;
            }
        }
    }
}

class Aula42{
    static void Main(){

        Carro fusca=new Carro();

        fusca[0]=78;
        Console.WriteLine("Velocidade: {0}km/h.",fusca[0]);
    }
}