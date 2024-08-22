using Microsoft.VisualBasic;

public class program
{
    public static void Main()
    {
        //      Console.WriteLine("Enter Your First Name");
        //      string Fname= Console.ReadLine();

        //      Console.WriteLine("Enter Your Middle Name");
        //string Mname = Console.ReadLine();

        //      Console.WriteLine("Enter Your Last Name");
        //      string Lname = Console.ReadLine();

        //string Fullname = Fname + " " + Mname + " " + Lname;
        //      Console.WriteLine(Fullname);

        //Calculate Length Of The String
        //Console.WriteLine("Enter Any Name");
        //var name = Console.ReadLine();

        //int count = 0;

        //foreach (var item in name)
        //{
        //    count++;
        //}
        //Console.WriteLine("Calculate Length Of The String= "+count);

        //Calculate Length Of The Vowels
        Console.WriteLine("Enter Any Name");
        var Vowels = Console.ReadLine();

        int VowelsCount = 0;

        foreach(var item in Vowels)
        {
            if(item == 'a' || item == 'e' || item == 'i' || item == 'o' || item == 'u')
            {
                VowelsCount++;
            }
        }
        Console.WriteLine("length Of The Vowels= "+VowelsCount);
    }
}
