using gerenciamento_estacionamento.Dominio.Base;
using gerenciamento_estacionamento.Dominio.Entidades;
using gerenciamento_estacionamento.Dominio.Enum;

namespace gerenciamento_estacionamento.Dominio.Extensions
{
    public static class EstacionamentoExtensions
    {
        public static void ExecutarDecisao(this Estacionamento estacionamento, DecisaoUsuarioEnum decisao)
        {
            switch (decisao)
            {
                case DecisaoUsuarioEnum.CadastrarUsuario:
                    var veiculo  = new Veiculo(ConsoleSistemaEstacionamento.ObterInformacoesVeiculo());
                    estacionamento.AdicionarVeiculo(veiculo);
                    break;
                case DecisaoUsuarioEnum.RemoverVeiculo:
                    var placaVeiculo = ConsoleSistemaEstacionamento.ObterInformacoesVeiculo();
                    decimal veiculoPrecoRemocao = estacionamento.RemoverVeiculo(placaVeiculo);

                    if (veiculoPrecoRemocao == 0)
                        ConsoleSistemaEstacionamento.VeiculoSemTaxa();

                    ConsoleSistemaEstacionamento.FinalizarEntradaVeiculo(placaVeiculo, veiculoPrecoRemocao);
                    break;
                case DecisaoUsuarioEnum.ListarVeiculos:
                    var veiculos  = estacionamento.BuscarVeiculosNoEstacionameto() ;
                    ConsoleSistemaEstacionamento.MostrarVeiculos(veiculos);
                    break;
            }
        }
    }


}
