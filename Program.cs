using gerenciamento_estacionamento.Dominio.Base;
using gerenciamento_estacionamento.Dominio.Entidades;
using gerenciamento_estacionamento.Dominio.Enum;

ConsoleSistemaEstacionamento.IniciarSistema();

(decimal precoInicial, decimal precoHora) tabelaPrecos = ConsoleSistemaEstacionamento.ConfigurarPrecoDoSistema();

var estacionamennto = new Estacionamento(tabelaPrecos.precoInicial, tabelaPrecos.precoHora);

DecisaoUsuarioEnum decisaoUsuario = ConsoleSistemaEstacionamento.MenuOpcoes();

while (decisaoUsuario != DecisaoUsuarioEnum.EncerrarSistema)
{

}


