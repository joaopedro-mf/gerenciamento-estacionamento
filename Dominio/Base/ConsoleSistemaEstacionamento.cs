using gerenciamento_estacionamento.Dominio.Enum;
using System.ComponentModel;

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


    }
}
