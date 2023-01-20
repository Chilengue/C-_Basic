namespace aulasC#;

public class forEache
{
    public static void Main(string[] args)
    {
        int[] num= new int [3]{2,2,2};
        for (var i = 0; i < num.length; i++)
        {
                 Console.WriteLine (num[i]);
        }
        foreach (var n in num)
        {
                 Console.WriteLine (n);
        }
    }
}
