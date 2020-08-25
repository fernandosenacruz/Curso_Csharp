using System;
//Struct
// estrutura não é um classe, portanto nao pode ser herdada.
struct Carro{
    public string marca, modelo, cor;

    public Carro(string marca, string modelo, string cor){
    this.marca=marca;
    this.modelo=modelo;
    this.cor=cor;
}
}

class Aula44{
    static void Main(){
        Carro carro1;
        Carro carro2=new Carro("Chevrolet","Camaro","Amarelo");

        carro1.marca="Volkswagem";
        carro1.modelo="Fusca";
        carro1.cor="Vermelho Ferrari";

        

        Console.WriteLine("{0}\n {1}\n {2}\n Valor R$: 6.500,00\n",carro1.marca,carro1.modelo,carro1.cor);

        Console.WriteLine("{0}\n {1}\n {2}\n Valor R$: 150.500,00",carro2.marca,carro2.modelo,carro2.cor);
    }
}