namespace Umfg.Programacao.Assincrona._2023
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine(Environment.CurrentManagedThreadId);

            await AguardarEmMilisegundosTaskAsync(5);

            Console.WriteLine(Environment.CurrentManagedThreadId);

            AguardarEmMilisegundosAsync(5);

            for(var i = 0; i < 1000; i++)
            {
                Console.WriteLine($"Valor e i: {i}");
            }

            Console.ReadLine();
        }

        static async void AguardarEmMilisegundosAsync(int milisegundos)
        {
            Console.WriteLine("Inicio aguardar processamento ASYNC");
            await Task.Delay(TimeSpan.FromMilliseconds(milisegundos));
            Console.WriteLine($"Fim processamento ASYNC, aguardou {milisegundos} milisegundos");
        }

        static async Task AguardarEmMilisegundosTaskAsync(int milisegundos)
        {
            Console.WriteLine("Inicio aguardar processamento TASK ASYNC");
            await Task.Delay(TimeSpan.FromMilliseconds(milisegundos));
            Console.WriteLine($"Fim processamento TASK ASYNC, aguardou {milisegundos} milisegundos {Environment.CurrentManagedThreadId}");
        }
    }
}