using System;
// Matrizes
class Aula18{
    static void Main(){
        int[,] n=new int[2,3]; // matriz
        int[,] num=new int[2,2]{{10,20},{30,40}}; // matriz com valores atribuidos
        int[,] numero={{100,200,300},{400,500,600}}; // matriz com valores atribuidos sem uso de "new".

        n[0,0]=1;
        n[0,1]=2;
        n[0,2]=3;
        n[1,0]=4;
        n[1,1]=5;
        n[1,2]=6;

        Console.WriteLine(n[1,0]);
        Console.WriteLine(num[1,1]);
        Console.WriteLine(numero[1,2]);

    }
}