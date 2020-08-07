using System;
//typecast
class Aula11{
    static void Main(){
        float n1=10.5f;
        //int n2=n1; não é possível converter implicitamente. necessário typecast de float para int
        int n2=(int)n1; // com typecast
        Console.WriteLine(n2);

        //short varShort=n2;
        short varShort=(short)n2; // com typecast
        Console.WriteLine(n2);
    }
}