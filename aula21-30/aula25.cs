using System;
// passagem por valor e referência
class Aula25{
    static void Main(){
        int num=50, num2=50;
        dobrar(ref num);
        Console.WriteLine(num);
        dobra(num2);
        Console.WriteLine(num2);
    }

    static void dobrar(ref int valor){ //passagem por referencia altera o num
        valor*=2;
    }
    static void dobra(int valor2){// passagem por valor não açtere o num2
        valor2*=2;
    }
}