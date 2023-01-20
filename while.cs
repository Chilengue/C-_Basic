using System.Runtime.Serialization.Json;
namespace aulasC#;

public class while
{
    public static void Main(string[] args)
    {
        //usamos quando nao tmemos certeza o numero e vezes vezs que queres repetir

        ///  while enquanto => enquanto  for verdadeiro ele retorna true
            int[] num= new int[10];
       
       
        int i=0;
        while (i<num.Length)
        {
            num[i]=0;
            i++;
            Console.writeLine(num[i]);
        }
        Console.writeLine("");
    }
}
