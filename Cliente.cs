namespace Aula20
{
    public class Cliente
    {
        public string NomeCliente { get; set; }
        public string Endereco { get; set; }
        public string Pedido { get; set; }

        public Cliente(string _nome){
            this.NomeCliente = _nome;
        }
        
        public string MostrarDados(){
            return $"Cliente : {NomeCliente} \nEndereço : {Endereco} \n";  

        
        }
        public void FazerPedido(){

            System.Console.WriteLine("Faça o pedido.");
            Pedido = System.Console.ReadLine();

        }
    }
}