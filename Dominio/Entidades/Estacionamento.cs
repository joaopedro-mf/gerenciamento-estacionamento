using gerenciamento_estacionamento.Dominio.Enum;
using gerenciamento_estacionamento.Dominio.Interfaces;

namespace gerenciamento_estacionamento.Dominio.Entidades
{
    public  class Estacionamento: IEstacionamento
    {
        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            PrecoInicial = precoInicial;
            PrecoPorHora = precoPorHora;
            Veiculos = new List<Veiculo>();
        }

        private decimal PrecoInicial { get; set; }
        private decimal PrecoPorHora { get; set; }
        private List<Veiculo> Veiculos { get; set; }

        public void AdicionarVeiculo(Veiculo veiculo)
        {
            throw new NotImplementedException();
        }

        public List<Veiculo> ListarVeiculos()
        {
            throw new NotImplementedException();
        }

        public void RemoverVeiculo()
        {
            throw new NotImplementedException();
        }

        public void Execute(DecisaoUsuarioEnum decisaoUsuario) 
        {
        
        }
    }
}
