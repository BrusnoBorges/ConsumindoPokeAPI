using ConsumindoPokeAPI;
using System;
using System.Threading.Tasks;

namespace UserInterface
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Digite um Numero: ");
            string parametro = Console.ReadLine();

            var repositorio = new PokeRepositorio();
            var PokeTask = repositorio.GetPokeAsync(parametro);

            await PokeTask.ContinueWith
            (poke =>
            {
                Console.WriteLine("\n" + poke.Result.name);

                Environment.Exit(0);
            },
                TaskContinuationOptions.OnlyOnRanToCompletion
            );

            Console.ReadLine();
        }
    }
}
