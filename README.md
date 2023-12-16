# Infnet_ProjetoStreaming
Infnet - Projeto Streaming - Arquitetura

#MUNDO 1
Você tem a tarefa de implementar um aplicativo que autoriza uma transação (cartão de credito) para uma conta específica após um conjunto de regras predefinidas.
Operações O programa lida com tipos de operações, decidindo qual de acordo com a linha que está sendo processada:
1.	Criação de conta
2.	Autorização de transação
3.	Notificação de transação
4.	Relatório Gerencial
5.	Criação de conta Cria a conta com "availableLimit" e "activeCard" definidos.
Violações da lógica de negócios Uma vez criada, a conta não deve ser atualizada ou recriada
2.	Autorização de transação Tenta autorizar uma transação para um determinado comerciante, quantidade e tempo dado o estado da conta e último autorizado
3.	Notificação de transação Ao autorizar uma transação para um determinado comerciante, o comerciante e o dono do cartão devem ser avisados
Violações da lógica de negócios para antifraude Você deve implementar as seguintes regras, tendo em mente que novas regras aparecerão no futuro: O valor da transação não deve exceder o limite disponível: limite insuficiente Nenhuma transação deve ser aceita quando o cartão não está ativo: cartão não ativo Não deve haver mais de 3 transações em um intervalo de 2 minutos: alta-frequência-pequeno-intervalo Não deve haver mais de 2 transações semelhantes (mesmo valor e comerciante) em um intervalo de 2 minutos: transação duplicada

#MUNDO 2 (Complemento) --- Você tem a tarefa de implementar um aplicativo de streamer de video como o spotify com um conjunto de regras predefinidas
Operações O programa lida com tipos de operações, decidindo qual de acordo com a linha que está sendo processada:
1.	Criação de conta
2.	Favoritar Musicas
3.	Playlist
4.	Assinatura
5.	Criação de conta Cria da conta para o usuário que deseja utilizar o app de musica
6.	Favoritar músicas Usuário deve ser capaz de favoritar suas músicas e suas bandas favoritas
7.	Busca de Bandas e Musicas Usuário deve ser buscar suas bandas e músicas, perfomance de busca é importante
8.	Assinatura O usuário deverá escolher um plano para escutar suas musicas.
Violações da lógica de negócios para antifraude Você deve implementar as seguintes regras, tendo em mente que novas regras aparecerão no futuro:
•	O usuário somente pode ter um plano ativo
•	O usuário deve ter um cartão de credito valido
