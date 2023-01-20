using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace 
{
    public class viaTeclado
    {
        public static void Main(string[] args)
        {
            int  v1,v2,soma;
            string nome;

            Console.Write("digite seu nome : ");
            nome=Console.ReadLine();
            Console.Write ("digite n1");
            v1=int.Parse(Console.ReadLine());
             Console.Write ("digite n1");
            v2=Convert.ToInt32(Console.ReadLine());
            soma=v1+v2;
            Console.WriteLine("nome  dgitado: {0} mais {1} e  igual a {2}",v1,v2,soma);
        }
    }
}