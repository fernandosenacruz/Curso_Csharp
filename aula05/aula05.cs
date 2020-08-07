using System;
class Aula05{
    static void Main(){
        int res=(10+5)*2;
        // & = and
        // | = or
        bool relacionais=(10<5)|(10==10);
        Console.WriteLine(res);
        Console.WriteLine(relacionais);
        int num=10;
        num++; num*=2; num/=2; num-=5; //realiza cada operação antes de imprir o num.
        Console.WriteLine(num);
    }
}