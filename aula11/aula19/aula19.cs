using System;
// Loop For
class Aula19{
    static void Main(){
        int[] num= new int[5];

        for(int i=0; i<num.Length; i++){
            num[i]=i+1;
            Console.WriteLine(num[i]);
        }
    }
}