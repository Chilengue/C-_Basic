namespace aulasC#;

public class ArrayBidimencionais
{
    public static void Main(string[] args)
    {
        ///matrizes em C#
        int [,] n = new int [3,5];
            n[0,0]=10;  n[0,1]=10;   n[0,2]=30; n[0,3]=50;  n[0,4]=44;
            n[1,0]=10;  n[1,1]=10;   n[1,2]=30; n[1,3]=50;  n[1,4]=44;
            n[1,0]=10;  n[1,1]=10;   n[1,2]=30; n[1,3]=50;  n[1,4]=44;
            n[2,0]=10;  n[2,1]=10;   n[2,2]=30; n[2,3]=50;  n[2,4]=44;

            Console.WriteLine (n[1,1]);

            int [,]num =new int [2,2] {{10,20}, {30,40}};
    }
}
