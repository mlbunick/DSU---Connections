using TesteLogicaBenner;

class Program
{
    static void Main(string[] args)
    {
        Network network = new Network(8); // Rede com 8 elementos

        network.Connect(1, 2); // Conecta 1 a 2
        network.Connect(6, 2); // Conecta 6 a 2
        network.Connect(2, 4); // Conecta 2 a 4
        network.Connect(5, 8); // Conecta 5 a 8

        //Execução de Test Cases informadas no Projeto
        Console.WriteLine(network.Query(1, 6)); // Esperado: True (1 e 6 estão conectados)
        Console.WriteLine(network.Query(6, 4)); // Esperado: True (6 e 4 estão conectados)
        Console.WriteLine(network.Query(7, 4)); // Esperado: False (7 e 4 não estão conectados)
        Console.WriteLine(network.Query(5, 6)); // Esperado: False (5 e 6 não estão conectados)
        Console.WriteLine(network.Query(1, 2)); // Esperado: True (1 e 2 estão conectados)
    }
}