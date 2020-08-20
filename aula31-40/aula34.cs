using System;
// Herança

class Carro{ // classe base
    public int velMax, portas;
    public bool ligado;
    public void ligar(){
        ligado=true;
    }
    public void desligar(){
        ligado=false;
    }
    public string getLigado(){
        if(ligado){
            return "On";
        }else{
            return "Off";
        }
    }
}
class Citroen:Carro{
    public int ano;
    public string cor;
    public double motor;
    public Citroen(int ano,double motor,string cor,int portas){ // derivada(herdada)
        desligar();
        this.motor=motor;
        this.ano=ano;
        this.cor=cor;
        this.portas=portas;
        velMax=155;
    }
}
class aula34{
    static void Main(){
       Citroen c3 =new Citroen(2011,1.4,"cinza",4);

        Console.Write("Citroen c3 {0} {1} {2} {3}P atinge: {4}km/h.\t{5}\n",c3.ano,c3.motor,c3.cor,c3.portas,c3.velMax,c3.getLigado());
    }
}