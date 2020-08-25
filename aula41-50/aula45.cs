using System;
//Array de estruturas

struct Carro{
    public string marca, modelo, cor;

    public void info(){
        Console.WriteLine(" {0}\n {1}\n {2}\n",this.marca,this.modelo,this.cor);
    }

    public Carro(string marca, string modelo, string cor){
    this.marca=marca;
    this.modelo=modelo;
    this.cor=cor;
}
}

class Aula45{
    static void Main(){
        Carro[] carros=new Carro[5];

        carros[0].marca="GM";
        carros[0].modelo="Celta";
        carros[0].cor="Prata";
        carros[1].marca="GM";
        carros[1].modelo="Cobalt";
        carros[1].cor="Prata";
        carros[2].marca="GM";
        carros[2].modelo="Onix";
        carros[2].cor="Preto";
        carros[3].marca="GM";
        carros[3].modelo="Kadett";
        carros[3].cor="Verde";
        carros[4].marca="GM";
        carros[4].modelo="Astra";
        carros[4].cor="Prata";

        for(int i=0;i<carros.Length;i++){
            carros[i].info();
        }
    }
}