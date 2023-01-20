namespace aulasC#;

public class enum
{
      enum diasemana
        {
            Domingo,
            segunda,
            Terca,
            Quarta,
            Quinta,
            Sexta,
            Sabado,,
        }
    public static void Main(string[] args)
    {
     diasemana ds= diasemana.Domingo;
     diasemana h =(diasemana)4;
     int  gh=(int)diasemana.Sexta;
     Console.WriteLine(ds);
    }
}
