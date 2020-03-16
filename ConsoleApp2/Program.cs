using System;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        private async Task Console2BadName()
        {
            await Task.CompletedTask;
        }

        private async Task Console2GoodNameAsync()
        {
            await Task.CompletedTask;
        }
    }
}
