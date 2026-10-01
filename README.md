# Avaliação Individual — Módulo 11 — Tecnologias Emergentes e IA

**Data de entrega:** DD/MM/AAAA
**Formato:** individual, de consulta aberta — use slides, anotações e a própria IA à vontade para pesquisar e testar suas respostas.

## Como participar

1. Faça um **fork** deste repositório.
2. Clone o seu fork localmente.
3. Responda as questões teóricas **direto neste README**, abaixo de cada uma.
4. Complete a parte prática (veja abaixo) editando `CLAUDE.md`, `.claude/skills/minha-skill/SKILL.md` e `EVIDENCIAS.md`.
5. Abra um **Pull Request** do seu fork de volta para este repositório.

> O PR não será mergeado — ele existe só para eu avaliar o seu diff. Pode deixar aberto depois de enviar.

O objetivo não é decorar definições, e sim demonstrar que você entende os conceitos e sabe aplicá-los para ganhar eficiência ao usar IA no seu projeto de TCC. Responda com suas próprias palavras — copiar e colar resposta pronta de IA sem entender não demonstra o aprendizado esperado.

---

## Questões dissertativas

### Questão 1 — O que é um "agent"?
O que é um "agent" (agente de IA)? Explique com suas próprias palavras e dê um exemplo de situação em que faz mais sentido usar um agente do que um chat comum.

**Sua resposta:**
Um agente de IA é um sistema que não apenas gera textos, mas também consegue executar ações autônomas dentro de um ambiente para atingir um objetivo (como navegar em diretórios, ler arquivos, rodar comandos no terminal e editar código). Em vez de usar um chat comum onde eu precisaria copiar um erro do terminal, colar no chat, pedir a correção e depois colar a resposta de volta na minha IDE, faz muito mais sentido usar um agente para que ele mesmo leia o log de erro de compilação do C#, encontre o arquivo problemático e aplique a correção diretamente no código.

### Questão 2 — O que são guidelines?
O que são "guidelines" (diretrizes) ao usar uma IA generativa? Qual é o papel delas na qualidade das respostas geradas pelo modelo?

**Sua resposta:**
Guidelines são regras e padrões pré-estabelecidos que definimos para a IA seguir durante a interação. O papel delas é garantir consistência e aderência técnica, evitando que a IA dê respostas genéricas. Por exemplo, ao estabelecer guidelines, posso forçar a IA a sempre usar nomenclatura em português para variáveis, aplicar boas práticas do .NET 8 e evitar pacotes de terceiros desnecessários, melhorando drasticamente a qualidade do código gerado para o meu projeto.

### Questão 4 — Escolha de modelo e nível de esforço
Qual modelo de IA utilizar para cada tipo de tarefa? Dê um exemplo de tarefa simples e outra mais complexa, explicando como você escolheria o modelo em cada caso. O que é o "nível de esforço" (effort level) e quando faz sentido aumentá-lo ou diminuí-lo?

**Sua resposta:**
A escolha do modelo depende da complexidade do problema. Para tarefas simples e repetitivas (como gerar propriedades get/set de uma classe ou formatar um bloco de comentários), um modelo menor e rápido, como o Claude 3.5 Haiku ou GPT-4o-mini, é ideal. Para tarefas complexas (como desenhar a arquitetura de um sistema de controle e automação ou refatorar lógicas de concorrência profunda), modelos robustos como o Claude 3.5 Sonnet ou OpenAI o1 são necessários. 
O "nível de esforço" (effort level) determina quanto tempo computacional o modelo investe "pensando" e raciocinando antes de entregar a resposta. Faz sentido aumentá-lo quando a precisão lógica for crítica (ex: cálculos, algoritmos complexos ou estruturação de banco de dados) e diminuí-lo em tarefas triviais para economizar recursos e tempo.

### Questão 5 — Como estruturar um bom prompt
Descreva os elementos que tornam um prompt mais eficaz (ex.: contexto, objetivo, formato esperado, exemplos, restrições).

**Sua resposta:**
Um bom prompt deve minimizar as ambiguidades. Ele precisa conter:
1. **Contexto:** Cenário atual (ex: "Estou desenvolvendo um projeto C# console para gerenciamento de tarefas...").
2. **Objetivo:** A ação exata a ser feita.
3. **Restrições:** O que a IA está proibida de fazer (ex: "Não utilize a biblioteca LINQ neste método").
4. **Formato esperado:** Como a resposta deve ser entregue (ex: "Retorne apenas o bloco de código, sem explicações adicionais").
5. **Exemplos (opcional mas recomendado):** Mostrar um modelo do padrão desejado para a saída.

### Questão 6 — Iteração de prompt
O que significa "iterar" um prompt? Por que a primeira resposta de uma IA geralmente não é a versão final, e como você usaria a resposta recebida para melhorar o próximo prompt?

**Sua resposta:**
Iterar um prompt significa ajustar e refinar o seu pedido original com base na resposta que a IA acabou de dar. A primeira resposta raramente é perfeita porque a IA pode preencher lacunas de informação com suposições (alucinações) ou adotar abordagens que não se alinham 100% com as regras de negócio. Ao iterar, eu pego a resposta, indico o que funcionou e o que deve ser mudado (ex: "A lógica está correta, mas você usou um loop 'while' infinito. Refatore usando um laço 'for' com limite máximo de 10 iterações").

### Questão 7 — Zero-shot vs. few-shot
Qual é a diferença entre um prompt "zero-shot" e um prompt "few-shot"? Dê um exemplo de situação em que vale a pena incluir exemplos dentro do próprio prompt.

**Sua resposta:**
Zero-shot é pedir para a IA realizar uma tarefa sem mostrar nenhum exemplo prévio de como fazer. Few-shot é fornecer alguns exemplos do padrão de entrada e saída esperado diretamente no prompt. Vale muito a pena usar "few-shot" em tarefas de formatação rígida ou extração de dados. Por exemplo, se eu precisar extrair dados brutos de logs de sensores de equipamentos e transformá-los num formato JSON específico, mostro para a IA duas ou três linhas de log seguidas do JSON correspondente que espero receber.

### Questão 8 — Memória e contexto entre sessões
O que significa uma IA "ter memória" entre sessões diferentes de conversa? Por que, em um projeto longo como o TCC, é importante decidir o que precisa ser "lembrado" e como fornecer esse contexto para a IA a cada nova conversa?

**Sua resposta:**
Sistemas de IA geralmente não carregam o histórico de uma conversa antiga para uma conversa nova (iniciam em "folha em branco"). "Ter memória" significa criar um mecanismo (como o uso do arquivo `CLAUDE.md`) onde registramos todas as decisões técnicas importantes, regras do sistema e o estado atual do projeto. No desenvolvimento de um TCC de Engenharia de Controle e Automação, isso é vital; se eu não fornecer esse contexto centralizado a cada sessão, a IA pode sugerir implementações conflitantes com o que já foi decidido semanas atrás, quebrando a padronização do código.

### Questão 9 — Avaliar a resposta da IA
Antes de aplicar a sugestão de uma IA no seu projeto, como você verifica se ela está correta? Descreva pelo menos 2 formas práticas de checar a confiabilidade de uma resposta gerada por IA.

**Sua resposta:**
1. **Verificação Prática (Testes):** Colocar o código num ambiente isolado ou compilar o projeto para garantir que não há erros de sintaxe e rodar testes de unidade para validar a lógica de negócio (ex: o `dotnet run` funciona sem quebrar?).
2. **Checagem Cruzada (Documentação):** Consultar as documentações oficiais (como o portal Microsoft Learn para .NET/C#) para confirmar se os métodos sugeridos não estão depreciados e se representam as melhores práticas atuais.

### Questão 10 — Dividir tarefas complexas em etapas
Por que, em tarefas mais complexas, pode ser melhor dividir o trabalho em um fluxo de etapas (ex.: primeiro classificar/organizar, depois processar, depois revisar) em vez de pedir tudo em um único prompt? Dê um exemplo aplicado a uma tarefa do seu TCC.

**Sua resposta:**
Modelos de IA têm limites de atenção e contexto. Se pedirmos para construir um sistema gigante de uma só vez, a IA tende a esquecer instruções iniciais, perder o rigor nos detalhes ou gerar bugs profundos. Dividir em etapas garante validação contínua. Por exemplo, na modelagem de um sistema de automação para o TCC: primeiro eu pediria para a IA estruturar as classes base de sensores e atuadores. Após eu revisar e aprovar, faço um segundo prompt pedindo para implementar a camada de lógica e controle; e por último, peço para ela gerar os testes unitários daquela camada específica.


> **Questão 3** (como escrever um bom CLAUDE.md) e a **Questão 11** (prática, evidência de uso real da IA) são respondidas nos próprios arquivos `CLAUDE.md` e `EVIDENCIAS.md` — veja a parte prática abaixo.

---

## Parte prática

1. **Complete o `CLAUDE.md`** na raiz deste repositório — é onde você responde a Questão 3, documentando o projeto para orientar um assistente de IA.
2. **Complete a Skill** em `.claude/skills/minha-skill/SKILL.md`, com instruções reutilizáveis para uma tarefa recorrente do projeto. Renomeie a pasta `minha-skill/` para o nome real da sua skill.
3. **Conecte um assistente de IA ao código local** (Claude Code, GitHub Copilot, Cursor, ou outro de sua escolha) e use-o pelo menos uma vez de verdade, aplicando o `CLAUDE.md` e/ou a Skill que você criou em uma tarefa real do projeto `GerenciadorDeTarefas`.
4. **Complete o `EVIDENCIAS.md`** — é onde você responde a Questão 11, documentando essa experiência (ferramenta usada, prompt exato, o que a IA fez, se seguiu suas instruções).

### O que NÃO fazer

- ❌ Copiar as respostas, o CLAUDE.md ou a Skill de um colega
- ❌ Inventar uma evidência que não aconteceu de verdade
- ❌ Alterar arquivos fora do escopo pedido

## Sobre o projeto de exemplo

Dentro de `GerenciadorDeTarefas/` tem um console app simples em C# — um gerenciador de tarefas fictício — que serve de base para você praticar. Não é necessário adicionar funcionalidades novas ao app; o foco é a configuração e o uso da IA em cima desse código.

Abra `GerenciadorDeTarefas.sln` no Visual Studio, ou rode pelo terminal:

```bash
cd GerenciadorDeTarefas
dotnet run
```

---

## Critérios de avaliação (10 pontos)

| Critério | Pontos |
|---|---|
| Questões dissertativas (conjunto) | 4 |
| `CLAUDE.md` bem estruturado e específico ao projeto (Questão 3) | 2 |
| Skill funcional e realmente reutilizável | 2 |
| `EVIDENCIAS.md` — uso real da IA, seguindo (ou não) o CLAUDE.md/Skill (Questão 11) | 1 |
| Qualidade do Pull Request (descrição clara, organizado, dentro do escopo) | 1 |

## Entrega

Envie o **link do seu Pull Request** pelo Akademos até a data acima.
