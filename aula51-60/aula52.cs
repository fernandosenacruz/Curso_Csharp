using System;
// Tratamento de exceções por meio de Try Catch Finally

class Aula52{
    static void Main(){
        int n1,n2,res;
        res=n1=n2=0;

        n1=10;
        n2=0;
        
        try{
        res=n1/n2;
        }catch(Exception e){
            Console.WriteLine("Error! \n{0}\n{1}",e.Message,e.GetType());
        }

        Console.WriteLine("{0}/{1}={2}",n1,n2,res);
    }
}
//continua aula53