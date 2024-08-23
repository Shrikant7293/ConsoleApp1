using Microsoft.VisualBasic;
using System.Data;

public class program
{
    public static void Main()
    {
        // Function Call

  //      ShowFullName(); 

  //      CalculString(); 

  //      Vowels(); 

		//Spaces(); 

		//Consonent(); 

        CalculWord();

	}

    // Decalaration And Defination

    static void ShowFullName()
	{      
        //  Show Full Name By User

        Console.WriteLine("Enter Your First Name");
        string Fname = Console.ReadLine();

        Console.WriteLine("Enter Your Middle Name");
        string Mname = Console.ReadLine();

        Console.WriteLine("Enter Your Last Name");
        string Lname = Console.ReadLine();

        string Fullname = Fname + " " + Mname + " " + Lname;
        Console.WriteLine(Fullname);
    }

    static void CalculString()
    {
       // Calculate Length Of The String(Calculate Character With Space)


        Console.WriteLine("Enter Any Name");
        var name = Console.ReadLine();

        int count = 0;

        foreach (var item in name)
        {
            count++;
        }
        Console.WriteLine("Calculate Length Of The String= " + count);
    }

   static void Vowels()
    {
        // Calculate Length Of The Vowels
       
        Console.WriteLine("Enter Any Name");
        var Vowels = Console.ReadLine();

        int VowelsCount = 0;

        foreach (var item in Vowels)
        {
            if (item == 'a' || item == 'e' || item == 'i' || item == 'o' || item == 'u')
            {
                VowelsCount++;
            }
        }
        Console.WriteLine("length Of The Vowels= " + VowelsCount);
    }

    static void Spaces()
    {
        //Calculate Length Of The Spaces
        Console.WriteLine("Enter Any Name");
        var Space = Console.ReadLine();

        int SpaceCount = 0;

        foreach (var item in Space)
        {
            if (item == ' ')
            {
                SpaceCount++;
            }
        }
        Console.WriteLine("Number Of Spaces " + SpaceCount);
    }

    static void Consonent()
    {
		// Calculate How Many Consonent

		Console.WriteLine("Enter Any Name");
		var Consonent = Console.ReadLine();

		int ConsonentCount = 0;

		foreach (var item in Consonent)
		{
			if (!(item == 'a' || item == 'e' || item == 'i' || item == 'o' || item == 'u' || item == ' '))
			{
				ConsonentCount++;
			}
		}
		Console.WriteLine("Number Of Consonent " + ConsonentCount);
	}

    static void CalculWord()
    {
        // Calculate Word By Using Spaces

        Console.WriteLine("Enter Any Name"); 
        var CalculWord = Console.ReadLine();

        int CalculWordCount = 0;

        foreach(var item in CalculWord)
        {
            if (item == ' ')
            {
                CalculWordCount++;
            }
        }
        Console.WriteLine("Number Of The Word = " + (CalculWordCount + 1));
    }
}
