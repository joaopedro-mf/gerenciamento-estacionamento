using gerenciamento_estacionamento.Dominio.Entidades;
using gerenciamento_estacionamento.Dominio.Enum;
using System.ComponentModel;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace gerenciamento_estacionamento.Dominio.Base
{
    public static class ConsoleSistemaEstacionamento
    {

        public static void IniciarSistema() 
        {
            Console.WriteLine("Sistema de Gerenciamento do Estacionamento");
            Console.WriteLine("Bem Vindo!");

        }

        public static (decimal precoInicial, decimal precoPorHora) ConfigurarPrecoDoSistema()
        {
            decimal precoInicial, precoPorHora;

            Console.WriteLine("Digite o preço inicial:");
            precoInicial = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Agora digite o preço por hora:");
            precoPorHora = Convert.ToDecimal(Console.ReadLine());

            return (precoInicial, precoPorHora);
        }

        public static DecisaoUsuarioEnum MenuOpcoes()
        {
            Console.WriteLine("Digite a sua opção:");
            Console.WriteLine("1 - Cadastrar veículo");
            Console.WriteLine("2 - Remover veículo");
            Console.WriteLine("3 - Listar veículos");
            Console.WriteLine("4 - Encerrar");

            return (DecisaoUsuarioEnum) Convert.ToInt32(Console.ReadLine());
        }

        public static void LimparConsole() => Console.Clear();

        public static string ObterInformacoesVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo:");
            return Console.ReadLine();
        }

        public static void ConfirmarNovaConsultaMenu()
        {
            Console.WriteLine("Aperte enter para continuar...");
            Console.ReadLine();

            LimparConsole();
        }

        public static void MostrarVeiculos(List<Veiculo> veiculos)
        {
            foreach (var veiculo in veiculos)
            {
                Console.WriteLine(veiculo.PlacaVeiculo);
            }
        }

        internal static void FinalizarEntradaVeiculo(string placa, decimal valorTotal) =>
            Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");

        public static void VeiculoSemTaxa() =>
            Console.WriteLine("Veiculo não ira pagar estacionamento");

    }
}
