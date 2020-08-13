using System;
// argumento out
class Aula26{
    static void Main(){
        int valor1, valor2, resultado, restante;
        
        Console.Write("Digite dividendo: ");
        valor1=Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite divisor: ");
        valor2=Convert.ToInt32(Console.ReadLine());
        
        resultado=divide(valor1,valor2,out restante);

        Console.WriteLine("{0}/{1}= {2} resto={3}.",valor1,valor2,resultado,restante);

    }

    static int divide(int dividendo, int divisor, out int resto){
        int quociente;
        quociente=dividendo/divisor;
        resto=dividendo%divisor; // é possível ter mais de 1 retorno através do argumento out
        return quociente;
    }
}