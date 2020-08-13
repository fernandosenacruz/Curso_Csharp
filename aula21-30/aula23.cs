using System;
// Métodos para array parte1
class Aula23{
    static void Main(){
        int[] vetor1=new int[2];
        int[] vetor2=new int[2];
        int[] vetor3=new int[2];
        int[,] matriz=new int[2,2]{{10,20},{30,40}};

        Random random=new Random();
        for(int i=0; i<vetor1.Length;i++);{
            vetor1[i]=random.Next(1,100);
        }

        Console.WriteLine("Elementos do Vetor1:");
        foreach(int n in vetor1){
            Console.WriteLine(n);
        }

        // publict static void BinarySearch(array, valor);
        Console.WriteLine("BinarySearch");
        int procurado=30;
        int posicao=Array.BinarySearch(vetor1,procurado);
        Console.WriteLine("Valor {0} está na posição {1}\n", procurado,posicao);

        // public static void Copy(Array_origem, Array_destino, nun_de_elementos);
        Console.WriteLine("Copy");
        Array.Copy(vetor1, vetor2, vetor1.Length);
        foreach(int n in vetor2){
            Console.WriteLine(n);
        }

        // public static void CopyTo(Array_desitno, a_partir_desta_posição);
        Console.WriteLine("\nCopyTo");
        vetor1.CopyTo(vetor3,0);
        foreach(int n in vetor3){
            Console.WriteLine(n);
        }

        //public long GetLongLenght(dimensão);
        Console.WriteLine("\nGetLongLenght");
        long nDeElementosVetor=vetor1.LongLength(0);
        Console.WriteLine("Quantidade de elementos {0}", nDeElementosVetor);

        // public int GetLowerBound(dimensão);
        Console.WriteLine("\nGetLowerBound");
        int menorIndiceVetor=vetor1.GetLowerBound(0);
        int menorIndiceMatriz=matriz.GetLowerBound(0);
        Console.WriteLine("Menor índice do vetor1 é {0} e da matriz é {0}",menorIndiceVetor,menorIndiceMatriz);

        // public int GetUpperBound(dimensão);
        Console.WriteLine("\nGetUpperBound");
        int maiorIndiceVetor=vetor1.GetUpperBound(0);
        int maiorIndiceMatriz=matriz.GetUpperBound(0);
        Console.WriteLine("Maior índice do vetor1 é {0} e da matriz é {1}",maiorIndiceVetor, maiorIndiceMatriz);

        // public object GetValue(long índice);
        Console.WriteLine("\nGetValue");
        int valor0=Convert.ToInt32(vetor1.GetValue(1));
        int valor1=Convert.ToInt32(matriz.GetValue(0,1));
        Console.WriteLine("O valor da posição 1 do vetor1 é {0} e da matriz é{1} ", valor0, valor1);

        // public static int IndexOf(array, valor);
        Console.WriteLine("\nIndexOf");
        int indice1=Array.IndexOf(vetor1,1);
        Console.WriteLine("O índice do prmeiro valor 1: {0}", indice1);

        // public static int LastIndexOf(array, valor);
        Console.WriteLine("\nLastIndexOf");
        int indice2=Array.LastIndexOf(vetor1,1);
        Console.WriteLine("O índice do último valor 1: {0}\n", indice2);

        // public static void Reverse(array);
        Array.Reverse(vetor1);
        foreach(int n in vetor1){
            Console.WriteLine(n);
        }

        // public static void SetValue(object valor, long posição);
        vetor2.SetValue(99,0);
        for(int i=0; i<vetor2.Length; i++){
            vetor2.SetValue(0,i);
        }
        Console.WriteLine("\nVetor 2");
        foreach(int n in vetor2){
            Console.WriteLine(n);
        }

        // public static void Sort(array);
        Array.Sort(vetor1);
        Array.Sort(vetor2);
        Array.Sort(vetor3);
        Console.WriteLine("\nVetor1");
        foreach(int n in vetor1){
            Console.WriteLine(n);
        }
        Console.WriteLine("\nVetor2");
        foreach(int n in vetor2){
            Console.WriteLine(n);
        }
        Console.WriteLine("\nVetor3");
        foreach(int n in vetor3){
            Console.WriteLine(n);
        }
    }
}