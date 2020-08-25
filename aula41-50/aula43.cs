using System;
//interfaces

public interface Veiculo{
    void on();
    void off();
    void info();
}
public interface Tunado{
    void nitro();
}
class Carro:Veiculo,Tunado{
    public bool ligado;
    public int velocidade;

    public Carro(){
        this.velocidade=0;
    }
    public void on(){
        this.ligado=true;
    }
    public void off(){
        this.ligado=false;
    }
    public void info(){}
    public void nitro(){
        this.velocidade=velocidade+10;
    }
}
class Aula43{
    static void Main(){
        Carro fusca=new Carro();

        fusca.velocidade=50;
        fusca.nitro();
        fusca.nitro();

        Console.WriteLine("Velocidade: {0}km/h.",fusca.velocidade);
    }
}