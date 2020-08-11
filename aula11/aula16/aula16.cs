using System;
// go to
class Aula16{
    static void Main(){
        Double tempo=0.0;
        String transpote,continuar;

        inicio:
        Console.Clear();
                
        Console.WriteLine("Viagem de Jampa à Olinda.");
        Console.WriteLine("Qual o meio de transposte: ");
        transpote = Console.ReadLine();

        switch(transpote){
            case "Helicóptero":
            case "helicóptero":
                tempo= 0.35;
                break;
            case "Carro":
            case "carro":
                tempo= 1.40;
                break;
            case "Ônibus":
            case "ônibus":
                tempo= 2.30;
                break;
            case "Bicicleta":
            case "bicicleta":
                tempo= 4.30;
                break;
            case "Caminhada":
            case "caminhada":
                tempo= 14.0;
                break;
            default:
                tempo=-1.0;
                break;
        }
        if(tempo<0){
            Console.Write("\n\tTransporte indisponível.");
        }else{
            Console.WriteLine("O tempo estimado da viagem é de: {0} horas.", tempo);
        }
        Console.WriteLine("Deseja continuar?  ");
        continuar=Console.WriteLine();
        if(continuar=="sim"|| continuar=="Sim"|| continuar=="SIM"){
            goto inicio;
        }else{
            Console.Clear();
            Console.WriteLine("Fim da execução.");
        }
    }
}