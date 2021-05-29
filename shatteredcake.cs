using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Text; 

class MainClass
{
    public static void Main (string[] args)
    {
        string userWidth = Console.ReadLine();
        int width = Int32.Parse(userWidth);
        string nPieces = Console.ReadLine();
        int n = Int32.Parse(nPieces); 
        int total_area=0;
        for(int i=0;i<n;i++)
        {
            string u = Console.ReadLine();
            string[] words=u.Split(' ');
            total_area = total_area+(Int32.Parse(words[0]) * Int32.Parse(words[1])); 
        }
        Console.WriteLine(total_area/width);
    }
}