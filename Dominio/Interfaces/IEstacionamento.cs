using gerenciamento_estacionamento.Dominio.Entidades;

namespace gerenciamento_estacionamento.Dominio.Interfaces
{
    public interface IEstacionamento
    {
        public void AdicionarVeiculo(Veiculo veiculo);
        public void RemoverVeiculo( );
        public List<Veiculo> ListarVeiculos();
    }
}
