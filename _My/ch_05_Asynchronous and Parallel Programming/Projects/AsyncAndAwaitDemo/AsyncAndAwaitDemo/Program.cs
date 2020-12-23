using System;
using System.Threading.Tasks;

namespace AsyncAndAwaitDemo
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("before DoAsync");
            Task task = DoAsync();
            Console.WriteLine("after DoAsync");
            Console.WriteLine("after DoAsync");
            Console.WriteLine("after DoAsync");
            await task;
            Console.WriteLine("end program");
        }

        static async Task DoAsync()
        {
            Console.WriteLine("start execute DoAsync");
            Console.WriteLine("before await in DoAsync");
            await Task.Delay(1000);
            //await mean : 1- : do not execute below instructions in the same function until this instruction end ,, 2- instead go to execute instructions in main function that called this function
            Console.WriteLine("after await in DoAsync");
            Console.WriteLine("end execute DoAsync");
        }
    }
}
