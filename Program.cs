using System;

namespace Aula20
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente Gabriel = new Cliente("Gabriel");
            Restaurante restaurante = new Restaurante("Fulano123");
            Pedido pedido = new Pedido();
            
            //Cliente
            Gabriel.Endereco = "Americanopolis";
            System.Console.WriteLine(Gabriel.MostrarDados());

            //Restaurante 
            restaurante.endereco = "Diadema, 9732";
            Console.WriteLine(restaurante.MostrarDados());

            Console.WriteLine();

            pedido.Cliente = Gabriel.NomeCliente;
            pedido.Restaurante = restaurante.nomeFantasia;
            Console.WriteLine(pedido.EntregarPedido("Feijoada", "Dinheiro", true ));
        }
    }
}
