using gerenciamento_estacionamento.Dominio.Interfaces;

namespace gerenciamento_estacionamento.Dominio.Entidades
{
    public class Veiculo: IVeiculo
    {
        public Veiculo(string placaVeiculo)
        {
            if (!VerificarAutenticidadePlaca(placaVeiculo))
                throw new ArgumentException("Placa de veiculo invalida");

            PlacaVeiculo = placaVeiculo;
            HorarioEntrada = DateTime.Now;

        }
        public string PlacaVeiculo { get; set; }
        public DateTime HorarioEntrada { get; set; }

        public int CalcularHorasNoEstacionamento() =>
            (DateTime.Now - HorarioEntrada).Hours;

        private bool VerificarAutenticidadePlaca(string placaVeiculo) =>
            placaVeiculo.Length == 6; 

    }
}
