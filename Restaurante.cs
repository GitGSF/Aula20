namespace Aula20
{
    public class Restaurante : Pedido
    {
        public string nomeFantasia {get; set ;}
        public string endereco { get; set; }

        public Restaurante(string _nome){
            this.nomeFantasia = _nome;
        }

        public string MostrarDados(){
           return $"Nome do restaurante : {nomeFantasia} \nEndereco : {endereco}";
     
        }
    }
}