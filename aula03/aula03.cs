using System;
class Aula03{
    static void Main(){
        byte n1= 10; // valores entre 0 - 255
        int num= -1; // pode receber valor negativo
        char caractere= 'a';
        float valorQuebrado= 0.1f;
        string texto= "Ximira";

        var aux=texto; //seu tipo será compilado através de sua atribuição

        Console.WriteLine("texto concatenado com variálvel " +aux);

        int nun1, nun2, res;
        nun1= 10; nun2= 10; res= nun1+nun2;

        Console.WriteLine("A soma de "+nun1+" + "+nun2+ " é igual a: "+ res);

    }
}