using System;
// Tratamento de exceções por meio de Try Catch Finally parte2

class Area{
    public static double Quadrado(double b, double h){
        if(b==0 || h==0){
            throw new Exception("Base ou Altura devem ser diferentes de 0.");
        }
        return b*h;
    }
}
class Aula53{
    static void Main(){
        double area=0;
        
        try{
        area=Area.Quadrado(0,30.5);    
        Console.WriteLine("Área do quadrado é: {0}m2.",area);
        
        }catch(Exception e){
            Console.WriteLine("Error! \n{0}\n{1}",e.Message,e.GetType());
        }
        finally{// sera executado independentemente do resultado do Catch.
            Console.WriteLine("Fim do programa.");
        }
    }
}