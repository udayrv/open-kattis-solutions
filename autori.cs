using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Text; 

class MainClass
{
    public static void Main (string[] args)
    {
        string userName = Console.ReadLine();
        string [] words=userName.Split('-');
        string output="";
        foreach (var word in words)
        {
            output=output+word[0];
        }
        Console.WriteLine(output);
    }
}
 