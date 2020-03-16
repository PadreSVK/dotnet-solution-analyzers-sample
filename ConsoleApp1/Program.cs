using System;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
#pragma warning disable VSTHRD200
        private static async Task Main(string[] args)
        {
            await Task.CompletedTask;
            Console.WriteLine("Hello World!");
        }
#pragma warning restore VSTHRD200

        private async Task BadNameAsync()
        {
            await Task.CompletedTask;
        }

        private async Task GoodNameAsync()
        {
            await Task.CompletedTask;
        }
    }
}