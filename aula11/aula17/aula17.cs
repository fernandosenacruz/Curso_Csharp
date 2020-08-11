using System;
// Array/ Vetor
class Aula17{
    static void Main(){
        //int n1,n2,n3,n4,n5; // variáveis tipo inteiro
        int[] n=new int[5]; // uma fomra de fazer um array
        int[] num=new int[2]{15,30}; // array com valores já declarados
        int[] numero={70,100,1000}; // array com valores atribuidos diretemente sem uso do "new".

        n[0]=110;
        n[1]=220;
        n[2]=330;
        n[3]=440;
        n[4]=550;

        Console.WriteLine(n[0]);
        Console.WriteLine(num[1]);
        Console.WriteLine(numero[2]);
    }
}