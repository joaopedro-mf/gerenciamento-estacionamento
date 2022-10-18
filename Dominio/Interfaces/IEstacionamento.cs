using gerenciamento_estacionamento.Dominio.Entidades;

namespace gerenciamento_estacionamento.Dominio.Interfaces
{
    public interface IEstacionamento
    {
        public void AdicionarVeiculo(Veiculo veiculo);
        public decimal RemoverVeiculo( string placaVeiculo  );
        public List<Veiculo> BuscarVeiculosNoEstacionameto();
    }
}
