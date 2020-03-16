using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        public async Task BadName()
        {
            await Task.CompletedTask;
        }

        public async Task<int> BadName2()
        {
            await Task.CompletedTask;
            return 5;
        }
    }
}