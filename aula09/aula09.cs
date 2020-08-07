using System;
// bitwise
class Aula09{
    static void Main(){
        int n=10, n2=20, n3=30, n4=40;
        n=n<<1; // dobra o n -> 10*2= 20
        Console.WriteLine(n);
        n2=n2>>1; // divide pela metade o n2 -> 20/2= 10
        Console.WriteLine(n2);
        n3=n3<<2; // dobra e depois dobra novamente o n3 -> (30*2)*2= 120
        Console.WriteLine(n3);
        n4=n4>>2; // divide e depois divide novamente o n4 -> (40/2)/2= 10
        Console.WriteLine(n4);
    }
}