using System;
//Métodos Virtuais

class Base{
    public Base(){}
    virtual public void info(){
        Console.WriteLine("Base");
    }
}
class Derivada:Base{
    public Derivada(){
        Console.WriteLine("Contrutor da calsse derivada.");
    }
    override public void info(){
        Console.WriteLine("Derivada.");
    }
}
class Derivada2:Derivada{
    public Derivada2(){
        Console.WriteLine("Contrutor da calsse derivada2.");
    }
    override public void info(){
        Console.WriteLine("Derivada2.");
    }
}

class aula38{
    static void Main(){
        Base Ref;
        Derivada derivada=new Derivada();
        Derivada2 derivada2=new Derivada2();
        
        Ref=derivada;
        Ref.info();

        Ref=derivada2;
        Ref.info();
    }
}