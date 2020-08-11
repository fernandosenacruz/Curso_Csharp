using System;
// ForEach
class Aula22{
    static void Main(){
        int[] num=new int[5]{11,22,33,44,55};

        /**for(int i=0; i<num.Length;i++){
            Console.WriteLine(num[i]);
        }*/

        foreach(int i in num){ // foreach é indicado apenas para leitura dos elementos de um array. caso haja interação o for é a sulução.
            Console.WriteLine(i);
        }
    }
}