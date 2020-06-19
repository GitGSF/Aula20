namespace Aula20
{
    public class Restaurante : Pedido
    {
        public string nomeFantasia {get; set ;}
        public string endereco { get; set; }

        public void MostrarDados()
        {}
        public string MostrarDados (string _nomeFantasia, string _endereco){
           this.nomeFantasia = _nomeFantasia;
           this.endereco = _endereco;

           return $"Nome do restaurante: {_nomeFantasia}\nEndereço do restaurante: {_endereco}";
        
             
        }
    }
}