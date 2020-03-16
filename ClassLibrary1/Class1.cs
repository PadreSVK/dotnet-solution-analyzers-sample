using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        public async Task BadNameAsync()
        {
            await Task.CompletedTask;
        }

        public async Task<int> BadName2Async()
        {
            await Task.CompletedTask;
            return 5;
        }
    }
}