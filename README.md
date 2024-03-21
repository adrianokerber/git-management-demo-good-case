# git-management-demo-good-case
Exemplo BOM de gestão de código no git


## Propósito

Este projeto demonstra um caso de má gestão de commits, onde não se segue uma padrão para as mensagens de commit e todo merge de uma branch de feature com uma branch de longa duração resulta em um merge sem fast-forward (Ex: `git merge feature/xyz --no-ff`).
Resultando em uma árvore de commits caótica onde é quase impossível identificar o que foi alterado em caso de necessidade de reversão de alterações.

De forma geral aqui usamos commits para pontos específicos de evolução porém sem relação clara com o quadro de tarefas.

## Problema

Temos um quadro do time onde gerenciamos as atividades no fluxo de trabalho, priorizações, etc.
Dado o quadro e histórico do git exibidos nas imagens abaixo o que você entende?

Quadro do time:
![Board do Time.png](.docs/assets/board_view.png)

Histórico do Git:
![Histórico GIT](.docs/assets/git_history.png)

Elaborando um pouco mais:

Neste exemplo utilizamos parte da essencia do git-flow, onde temos duas branches de longa duração `main` e `dev`, sendo a _main_ a branch que representa o código em ambiente de produção.
Também atrelado a _main_ temos `tags` onde cada tag representa uma release publicada em produção.
Também é importante destacar que como estratégia de unificação de branches utilizamos o `git merge <alvo> --no-ff` para forçar a criação de commits de merge.

Desta forma na imagem que exibe o histórico do git temos um emaranhado de commits com mensagens de pouco signnificado e branches bifurcando e se unindo novamente criando um histórico caótico.
> 💡Importante: o exemplo acima nem de longe representa um caso extremo do uso desta prática, porém serve ao propósito da demonstração.

## Questionamentos

Olhando novamente as imagens acima:
- Você conseguiria relacionar facilmente os 4 itens de trabalho do quadro com os commits do histórico?
- Se você se esforçar um pouco mais, consegue fazer a relação?
- Hiiii, deu problema em produção, como identificar qual feature deu problema olhando esse histórico? Para revertê-la poderíamos reverter só um commit?

A resposta é: "Com tempo infinito tudo é possível", porém sabemos que nosso tempo é finito, logo trabalhar com esse padrão caótico não é viável, pois requer uma carga cognitiva extrema.

## Conclusão

Pode-se perceber que este tipo de estratégia de gerenciamento de commits não deixa clara a relação entre o quadro de gestão de tarefas, além de dificultar a reversão de alterações pois necessitamos de uma composição de commits para entregar uma funcionalidade e talvez seja necessário reverter vários em caso de problema.

### Pontos negativos do modelo:

- Alta carga cognitiva
- Baixo rastreio de demandas
- Propósito de alterações ofuscado