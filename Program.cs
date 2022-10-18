using gerenciamento_estacionamento.Dominio.Base;
using gerenciamento_estacionamento.Dominio.Entidades;
using gerenciamento_estacionamento.Dominio.Enum;
using gerenciamento_estacionamento.Dominio.Extensions;

ConsoleSistemaEstacionamento.IniciarSistema();

(decimal precoInicial, decimal precoHora) tabelaPrecos = ConsoleSistemaEstacionamento.ConfigurarPrecoDoSistema();

Estacionamento estacionamennto = new Estacionamento(tabelaPrecos.precoInicial, tabelaPrecos.precoHora);

DecisaoUsuarioEnum decisaoUsuario;

do
{
    decisaoUsuario = ConsoleSistemaEstacionamento.MenuOpcoes();
    estacionamennto.ExecutarDecisao(decisaoUsuario);

    ConsoleSistemaEstacionamento.ConfirmarNovaConsultaMenu();
}
while(decisaoUsuario != DecisaoUsuarioEnum.EncerrarSistema);




