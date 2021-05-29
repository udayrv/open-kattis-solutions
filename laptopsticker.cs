using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Text; 

class MainClass
{
    public static void Main (string[] args)
    {
        string u = Console.ReadLine();
        string[] words=u.Split(' ');
        int w1=Int32.Parse(words[0]);
        int h1=Int32.Parse(words[1]);
        int w2=Int32.Parse(words[2]);
        int h2=Int32.Parse(words[3]);
        if((w1-w2>=2) && (h1-h2>=2))
        {
            Console.WriteLine(1); 
        }
        else
        {
            Console.WriteLine(0);
        }
    }
}