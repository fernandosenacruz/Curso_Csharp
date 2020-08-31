using System;
// Namespace
//Serve para organizar em agrupamento 
namespace CalculoArea{class Area{
    public static double Quadrado(double b, double h){
        if(b==0 || h==0){
            throw new Exception("Base ou Altura devem ser diferentes de 0.");
        }
        return b*h;
    }
}}// class de mesmo nome podem ser criadas desde que em namespaces distintos.

class Aula54{
    static void Main(){
        double area=0;
        
        try{
        area=CalculoArea.Area.Quadrado(0,30.5);    
        Console.WriteLine("Área do quadrado é: {0}m2.",area);
        
        }catch(Exception e){
            Console.WriteLine("Error! \n{0}\n{1}",e.Message,e.GetType());
        }
        finally{// sera executado independentemente do resultado do Catch.
            Console.WriteLine("Fim do programa.");
        }
    }
}