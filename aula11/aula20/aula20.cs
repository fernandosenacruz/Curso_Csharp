using System;
// While
class Aula20{
    static void Main(){
        int[] num= new int[10];
        
        int i=0;

        while(i<num.Length){
            num[i]=i+1;
            Console.WriteLine(num[i]);
            i++;
        }
        Console.WriteLine("Fim do Loop.");
    }
}