using System;
// Métodos que reotrnam objetos

class Galinacio{
    private string nomeGalinha;
    private int qntDeOvos;
    public Galinacio(string Galinacio){
        this.nomeGalinha=nomeGalinha;
        qntDeOvos=0;
    }
    public Ovo botar(){
        qntDeOvos++;
    return new Ovo(qntDeOvos, nomeGalinha);
}
}
class Ovo{
    private int qntDeOvos;
    private string qualFoiAGalinha;
    public Ovo(int qntDeOvos, string qualFoiAGalinha){
        this.qntDeOvos=qntDeOvos;
        this.qualFoiAGalinha=qualFoiAGalinha;

        Console.WriteLine("{0} ovo foi posto por {1}",this.qntDeOvos,this.qualFoiAGalinha);
    }
}

class Aula46{
    static void Main(){

        Galinacio frango1=new Galinacio("Lilica");
        Galinacio frango2=new Galinacio("Zazá");
        Galinacio frango3=new Galinacio("Lola");

        frango1.botar();
        frango2.botar();
    }
}