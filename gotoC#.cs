namespace aulasC#;

public class gotoC#
{
    public static void Main(string[] args)
    {
        //goot trm funcao de retornar aopontador de um leibol em c#
            char escolha;
            int tempo=0;

        inicio:  //criar o label em goto e embaixo apontamos o laibel para o  proprio goto


            Console.Clear();

            Console.WriteLine("  maputo/Matola/manhica");
            Console.WriteLine ("escolha um meip de transporte para maputo:   [a]Avaiao | [c]carro |  [T]tmp");
            escolha=char.Parse(Console.ReadLine());
            switch (escolha)
            {
                case 'a':
                case 'A':
                tempo=50;
                    break;
                    case 'c':
                    case 'C':
                    tempo=200;
                    break;
                    case 'T':
                    case 't':
                    tempo=1000;
                default:
                Console.WriteLine (" hsaaaaaa caga la bro perdeste");
                    break;
            }
            

        Console.WriteLine("calcula outro carro [s/n]");
        escolha=char.Parse(Console.ReadLine);


        if (escolha== 's' ||  escolha='S')
        
        {
        goto inicio;   // o  label que  tem funcao de ser retornado 
        }else
        {
            Console.Clear();
            Console.WriteLine();
        }

    }

    //goto tem funcao de retornr os valores  ao seu inicio;
}
