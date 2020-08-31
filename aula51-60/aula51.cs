using System;
//Argumentos de entrada que são passados direto pelo prompt de comando

class Aula51{
    static void Main(string[] args){
        int res=0;
        
        if(args.Length>0){
            Console.WriteLine("Número de argumentos: {0}", args.Length);
            for(int i=0;i<args.Length;i++){
                res+=Int32.Parse(args[i]);
            }
            Console.WriteLine("Soma: {0}",res);
        }else{
            Console.WriteLine("Não foram passados arugumentos.");
        }
        
    }
}
