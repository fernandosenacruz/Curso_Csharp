using System;
// this
class Calc{
    public int v1;
    public int v2;
    public Calc(int v1, int v2){
        this.v1=v1;
        this.v2=v2;
    }

    public int Somar(){
        return v1+v2;
    }
}
class aula32{
    static void Main(){
    Calc calcular=new Calc(10,2);
    Console.WriteLine(calcular.Somar());
    }
}