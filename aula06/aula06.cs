using System;
class Aula06{
    static void Main(){
        int n1, n2, n3;
        n1=10; n2=20; n3=30;
        Console.WriteLine("n1=\a{0}\n\tn2=\a{1}\n\t\tn3={2}",n1,n2,n3);
        double valDeCompra= 5.50;
        double valDeVenda;
        double lucro=0.15;
        string produto= "Coca-Cola";
        valDeVenda=valDeCompra+(valDeCompra*lucro);
        Console.WriteLine("Produto........:{0,10}", produto);
        Console.WriteLine("Valor de compra:{0,10:c}", valDeCompra); // :c -> monetário
        Console.WriteLine("Lucro desejado.:{0,10:p}", lucro); // :p -> porcentágem
        Console.WriteLine("Venda..........:{0,10:c}",valDeVenda);
    }
}