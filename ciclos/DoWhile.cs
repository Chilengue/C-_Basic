using System;
namespace aulasC#;

public class DoWhile
{
    public static void Main(string[] args)
    {

        string senha="123";
        string senhauser;
        int tentativas;
         //  senhauser=Console.ReadLine();
        do
        {
            Console.Clear();
             Console.WriteLine ("digite a senha");
             senhauser=Console.ReadLine();
             tentativas ++;

        } while (senha!=senhauser)
             Console.WriteLine ("senha correta, tentativas:{0}",tentativas);
    }
}
//do while garabt que uma vez que os comandos serao executadod 
//while nao ha garantia  da saida por causa de seus valores logicos que vao sair
