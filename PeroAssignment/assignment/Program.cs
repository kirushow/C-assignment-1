using System.Drawing;
using System.Linq.Expressions;

namespace assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ct("Hello");
            ct("i'm gonna to ask you a few questions");
            ct("every question you answer wrong");
            ct("i'll take 3 amount of life from you");
            ct("do you understand?");
        }
        static void ct(string text)
        {
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(text);
           
        }
    }
}
