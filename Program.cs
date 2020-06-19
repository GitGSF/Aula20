using System;

namespace Aula20
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente Gabriel = new Cliente();
            Restaurante restaurante = new Restaurante();
            Pedido pedido = new Pedido();

            Console.WriteLine("Cliente: ");
            Console.WriteLine(Gabriel.MostrarDados( "Gabriel", "Residencia Americanópolis" ));

            Console.WriteLine();

            Console.WriteLine("Restaurante: ");
            Console.WriteLine(restaurante.MostrarDados( "Restaurante Fulano123", "Diadema" ));  

            Console.WriteLine();

            pedido.Cliente = Gabriel.Nome;
            pedido.Restaurante = restaurante.nomeFantasia;
            Console.WriteLine(pedido.EntregarPedido("Feijoada", "Dinheiro", true ));
        }
    }
}
