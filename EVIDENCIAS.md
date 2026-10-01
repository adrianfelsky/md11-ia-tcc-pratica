# Evidências da Parte Prática

## 1. Ferramenta Utilizada
Utilizei um assistente de IA via web (neste caso, o Gemini) atuando em conjunto com o meu projeto aberto no Visual Studio.

## 2. Tarefa Executada
Solicitei à IA para ler o código base do arquivo `Program.cs`, aplicar as diretrizes definidas no `CLAUDE.md`, utilizar a skill de documentação que criei em `SKILL.md` (na pasta `.claude/skills/gerar-comentarios/`) e implementar uma nova funcionalidade: um método chamado `ListarTarefasPendentes()`.

## 3. O Prompt Utilizado
O prompt exato que enviei para a IA foi o seguinte:

> "Aja como meu assistente de IA focado em C#. 
> 
> **1. Aqui estão as regras do meu projeto (CLAUDE.md):**
> - Todo o código fonte e comentários devem ser escritos estritamente em Português do Brasil.
> - Utilize `PascalCase` para Classes e Métodos, e `camelCase` para variáveis locais.
> - Aplique comentários XML (`/// <summary>`) antes de métodos.
> 
> **2. Aqui está a skill que você deve usar (SKILL.md):**
> - Identifique parâmetros de entrada e retornos.
> - Adicione o bloco de comentário XML padrão do C# explicando o que o método faz.
> - Crie comentários curtos (`//`) dentro da lógica se houver um trecho complexo (como laços de repetição).
> 
> **3. Aqui está o meu código atual do Program.cs:**
> [Colei todo o código original do projeto aqui]
> 
> **O que você deve fazer:**
> Crie um novo método chamado 'ListarTarefasPendentes' dentro desse código. Além disso, aplique a skill de documentação (comentários XML) em todos os métodos existentes do código. Me devolva apenas o código completo e refatorado."

## 4. Resultado e Avaliação
A IA seguiu as instruções com precisão e os resultados foram muito satisfatórios:

- **Aderência ao `CLAUDE.md`:** A IA gerou o novo método e a documentação estritamente em português, respeitando a regra do padrão de nomenclatura solicitada (`PascalCase` para o método `ListarTarefasPendentes`).
- **Aderência à Skill:** Como exigido na skill, a IA adicionou perfeitamente as tags `<summary>` e `<param>` acima dos métodos (`Adicionar`, `Concluir`, etc.) e inseriu comentários em linha (com `//`) para explicar os laços `for` e `foreach`.
- **Testes Práticos:** Substituí o conteúdo do meu `Program.cs` pelo código fornecido pela IA e executei o projeto no Visual Studio. O código compilou de primeira, sem erros, e a nova funcionalidade de listar apenas as tarefas não concluídas funcionou perfeitamente no terminal.
