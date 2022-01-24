namespace Validate
{
    public class Validate
    {
        public static int Valint(string? r, string x) //input a console.readline and it will output a int
        {
            while (!int.TryParse(r, out _))
            {
                Console.WriteLine(x);
                r = Console.ReadLine();
            }
            return int.Parse(r);
        }

    }
}