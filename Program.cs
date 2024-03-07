using System;
using System.Threading;

class Program
{
    internal static bool run = false;
    static void Main(string[] args)
    {
        // Criando uma nova thread e passando o método que ela executará
        Thread thread = new Thread(new ThreadStart(ExecutarTarefa));

        // Iniciando a execução da thread
        thread.Start();

        run = true;
        while (run)
        {
            Console.WriteLine("Escreva yes para continuar, no para parar: ");
            string action =  Console.ReadLine();
            if(action == "no")
            {
                run = false;
            }
        }

        // Espera a thread terminar antes de encerrar o programa
        thread.Join();

        Console.WriteLine("Programa principal terminou.");
    }

    static void ExecutarTarefa()
    {
        int i = 0;
        while(run)
        {
            Console.WriteLine("Marcius executando... " + i);
            Thread.Sleep(1000); // Espera 1 segundo antes de imprimir a próxima mensagem
            i++;
        }
    }
}
