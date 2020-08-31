using System;
using System.Collections.Generic;
// Ocleção Dictionary

class Aula55{
    static void Main(){

        Dictionary<int, string> veiculos=new Dictionary<int, string>();

        veiculos.Add(2011,"Celta");
        veiculos.Add(2020,"Duster");

        Console.WriteLine("Tamanho: {0}",veiculos.Count);

        foreach(KeyValuePair<int,string> v in veiculos){
            Console.WriteLine(v.Value,v.Key);
        }
        
        int ano=2011;
        if(veiculos.ContainsKey(ano)){
            Console.WriteLine("Carro do ano {0} está contido na coleção.",ano);
        }else{
            Console.WriteLine("Carro do ano {0} não está contido na coleção.",ano);
        }
        
        string carro="fusca";
        if(veiculos.ContainsValue(carro)){
            Console.WriteLine("Carro do modelo {0} está contido na coleção.",carro);
        }else{
            Console.WriteLine("Carro do modelo {0} não está contido na coleção.",carro);
        }
        veiculos.Remove(2020);
        Console.WriteLine("Carro do ano {0} foi removido da coleção.",ano);
        
    }
}