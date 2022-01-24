public class Common
{
    static dynamic Validate(string type, string? read, string? failmessage, string? passmessage)
    {
        while (read == null)
        {
            Console.WriteLine(failmessage);
            read = Console.ReadLine();
        }
        switch (type)
        {
            case "str":
                while (read == null)
                {
                    Console.WriteLine(failmessage);
                    read = Console.ReadLine();
                }
                Console.WriteLine(passmessage);
                return read.ToString();

            case "int": //signed int
                while (!int.TryParse(read, out _))
                {
                    Console.WriteLine(failmessage);
                    read = Console.ReadLine();
                }
                Console.WriteLine(passmessage);
                return int.Parse(read);

            case "float":
                while (!float.TryParse(read, out _))
                {
                    Console.WriteLine(failmessage);
                    read = Console.ReadLine();
                }
                Console.WriteLine(passmessage);
                return float.Parse(read);

            case "bool":
                while (!float.TryParse(read, out _))
                {
                    Console.WriteLine(failmessage);
                    read = Console.ReadLine();
                }
                Console.WriteLine(passmessage);
                return float.Parse(read);

            case "double":
                while (!double.TryParse(read, out _))
                {
                    Console.WriteLine(failmessage);
                    read = Console.ReadLine();
                }
                Console.WriteLine(passmessage);
                return double.Parse(read);

            case "char":
                while (!char.TryParse(read, out _))
                {
                    Console.WriteLine(failmessage);
                    read = Console.ReadLine();
                }
                Console.WriteLine(passmessage);
                return char.Parse(read);

            case "byte": //unsigned byte
                while (!byte.TryParse(read, out _))
                {
                    Console.WriteLine(failmessage);
                    read = Console.ReadLine();
                }
                Console.WriteLine(passmessage);
                return byte.Parse(read);

            case "sbyte": //signed byte
                while (!sbyte.TryParse(read, out _))
                {
                    Console.WriteLine(failmessage);
                    read = Console.ReadLine();
                }
                Console.WriteLine(passmessage);
                return sbyte.Parse(read);


            default:

                Console.WriteLine("Error: 000000");
                return "Error: 000000";



        }
    }
    static void Setup()
    {
        //Planned
    }
    static string[] FileSetup()
    {
        //Planned
        return new string[];
    }
}
