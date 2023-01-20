namespace aulasC#;

public class typcast
{
   public static void Main(string[] args)
   {
    // tem funcao  de conveter um variavel em outra isso de int em string double em char  dentro varias convercoes em programacao
    
    int n1=10;
    float n2=n1;
    Console.WriteLine(n2);
    // conversoes implissita esta ten funcao de verficar os valores sao compativeis nomesmo tipo de dado  
    // convercoes plicitas quando nao sao compativri  na programacao 

    //exemplo


    float n3=10.6f;
    int n7=n3;
    Console.WriteLine(n7);
    //esta conversao da erro  porque nao ha conversao de valores fluantes para ineteiros
    int n7=(int)n3; //esta operacao areddonda os valores em programacao  quando colocamos entre parentes o tipo de dado   para exemplificar



    int  vInt=10;
     long  vlong=vInt;

    int h=10;
    short v=(short)h;
    Console.WriteLine(v);
   } 
}
