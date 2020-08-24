using System;
// membro protected

class Veiculo{ // classe base   
    public int velAtual;
    private int velMax; // acessível dentro da própria classe
    protected bool ligado; // acessível dentro da própria classe bem como nas derivadas

    public Veiculo(int velMax){
        velAtual=0;
        this.velMax=velMax;
        ligado=false;
    }
    public bool getLigado(){
        return ligado;
    }
    public int getVelMax(){
        return velMax;
    }
}
class Carro:Veiculo{ // classe derivada de veículo
    public string nome;
    public Carro(string nome, int vm):base(vm){
        this.nome=nome;
        ligado=true;
    }
}

class aula36{
    static void Main(){
        
        Carro fusca=new Carro("Fuscão Preto",120);

        Console.WriteLine("Carro: {0} atinge {1} em 20 segundos. Ligado: {2}.",fusca.nome,fusca.getVelMax(),fusca.getLigado());
    }
}