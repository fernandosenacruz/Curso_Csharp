using System;
// argumentos params
class Aula27{
    static void Main(){
        soma(5,6,7,55,1,0);
    }

    static void soma(params int[]n){
        int resultado=0;

        if(n.Length<1){
            Console.WriteLine("Nenhum valor foi informado.");
        }else if(n.Length<2){
            Console.WriteLine("Adicione outro valor ao numeral {0} para obter a soma.",n[0]);
        }else{
            for(int i=0;i<n.Length;i++){
                resultado+=n[i];
            }
            Console.WriteLine("A soma dos valores é: {0}",resultado);
        }
        
    }
}