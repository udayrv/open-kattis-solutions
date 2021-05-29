using System; 
using System.Collections.Generic; 
using System.Linq;
using System.Text; 

class MainClass
{
    public static void Main (string[] args)
    {
        string userName = Console.ReadLine();
        int mega = Int32.Parse(userName);
        string user = Console.ReadLine();
        int n = Int32.Parse(user);
        int sum=0;
        for (int i=0;i<n;i++)
        {
            string u = Console.ReadLine();
            int temp = Int32.Parse(u);
            sum=sum+(mega-temp);
        }
        Console.WriteLine(mega+sum);
    }
}
