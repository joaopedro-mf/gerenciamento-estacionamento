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

        public void AdicionarVeiculo(Veiculo veiculo) =>
            Veiculos.Add(veiculo);

        public List<Veiculo> BuscarVeiculosNoEstacionameto() => 
              Veiculos;

        public decimal RemoverVeiculo(string placaVeiculo)
        {
            Veiculo? veiculoDeSaida = Veiculos.FirstOrDefault(x => x.PlacaVeiculo == placaVeiculo);

            if (veiculoDeSaida is null)
                return 0;

            Veiculos.Remove(veiculoDeSaida);

            return veiculoDeSaida.CalcularHorasNoEstacionamento() * PrecoPorHora + PrecoInicial; 

        }
    }
}
