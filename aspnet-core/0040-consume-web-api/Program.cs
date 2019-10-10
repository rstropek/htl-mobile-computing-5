using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ConsumeWebApiConsoleApp
{
    public static partial class Program
    {
        static async Task Main()
        {
            await Get();
            await Post();
        }
    }
}
