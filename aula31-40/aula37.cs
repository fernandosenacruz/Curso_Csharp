using System;
// Herança(oredem de execução dos construtores)

class Base{
    public Base(){
        Console.WriteLine("Contrutor da calsse base.");
    }
}
class Derivada:Base{
    public Derivada(){
        Console.WriteLine("Contrutor da calsse derivada.");
    }
}
class Derivada2:Derivada{
    public Derivada2(){
        Console.WriteLine("Contrutor da calsse derivada2.");
    }
}

class aula37{
    static void Main(){

        Derivada2 derivada2=new Derivada2();
    }
}