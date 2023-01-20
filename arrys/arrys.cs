using Internal;
using System;
using System.Numerics;
namespace aulasC#;

public class arrys
{
    public static void Main(string[] args)
    {
        int [] Vector1= new int [5];
        int [] Vector2= new int [5];
        int [] Vector3= new int [5];
        int [,] matriz= new int [2,5] {{11,22,00,44,55}, {66,77,88,99,00}};
    
                Random _random= new Random();
                for (int i = 0; i < Vector1.length; i++)
                {
                    Vector1[i]=_random.Next(50); 
                }

                Console.WriteLine("elemeentos do vetoor1");
                foreach (var n in Vector1)
                {
                    Console.WriteLine(n);
                }

                //public static int BinaryySearch  (arrys, valor);
                Console.WriteLine("BinarySearch");
                int procurado=33;
                int pos=Array.BinarySearch(Vector1,procurado);
                Console.WriteLine("Valor {0} esta na posicapo {1}", procurado,pos);
                Console.WriteLine("----------------------------------------------------");
                

                // public staticn void  copy(Ar_orgem, Ar_destinoo,qtde_elementos);
                Console.WriteLine("copy");
                Array.Copy(Vector1,Vector2,Vector1.Length);
                foreach (var n in Vector2)
                {
                    Console.WriteLine(n);
                }
                Console.WriteLine("----------------------------------------------");


                // public  void CopyTo(Ar_destino, a_partir_edesta_pos);

                    Console.WriteLine("CopyTo");
                    Vector1.CopyTo(Vector3,0);
                    foreach(int n in Vector3)
                    {
                        Console.WriteLine(n);
                    }
                    Console.WriteLine("-----------------------------------------------------");

                //public long GetLongLenght(dimensao);
            Console.WriteLine("GetLongLenght");
            long qtddElementovetor=Vector1.GetLowerBound(0);
            Console.WriteLine("quantidade  de elementos {0}", qtddElementovetor);
                Console.WriteLine("--------------------------------------------");

                //public int GetUpperBound(dimensao);
                Console.WriteLine("GetUppBouf");
                int MaiorIndiceVector=Vector1.GetUpperBound(0);
                int MaiorIndiceMatriz=matriz.GetUpperBound(1);
                Console.WriteLine("Maior  indice  de vector1 {0} ", MaiorIndiceMatriz);
    }
}
