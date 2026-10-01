using System;
using System.Collections.Generic;

var tarefas = new List<(int Id, string Titulo, bool Concluida)>();
var proximoId = 1;

/// <summary>
/// Adiciona uma nova tarefa à lista de tarefas.
/// </summary>
/// <param name="titulo">O título descritivo da tarefa a ser adicionada.</param>
void Adicionar(string titulo)
{
    tarefas.Add((proximoId++, titulo, false));
}

/// <summary>
/// Marca uma tarefa específica como concluída buscando pelo seu identificador.
/// </summary>
/// <param name="id">O identificador único da tarefa que será concluída.</param>
void Concluir(int id)
{
    // Percorre a lista inteira para encontrar a tarefa correspondente ao ID informado e atualiza a tupla
    for (var i = 0; i < tarefas.Count; i++)
    {
        if (tarefas[i].Id == id)
        {
            tarefas[i] = (tarefas[i].Id, tarefas[i].Titulo, true);
        }
    }
}

/// <summary>
/// Lista todas as tarefas cadastradas no sistema, exibindo o status de conclusão de cada uma.
/// </summary>
void Listar()
{
    foreach (var t in tarefas)
    {
        var status = t.Concluida ? "[X]" : "[ ]";
        Console.WriteLine($"{status} #{t.Id} — {t.Titulo}");
    }
}

/// <summary>
/// Lista exclusivamente as tarefas que ainda estão pendentes (não concluídas).
/// </summary>
void ListarTarefasPendentes()
{
    // Itera sobre as tarefas e filtra verificando a propriedade booleana Concluida
    foreach (var t in tarefas)
    {
        if (!t.Concluida)
        {
            Console.WriteLine($"[ ] #{t.Id} — {t.Titulo}");
        }
    }
}

Adicionar("Estudar para a avaliação do Módulo 11");
Adicionar("Configurar o CLAUDE.md do projeto");
Adicionar("Criar uma Skill reutilizável");

Console.WriteLine("=== Gerenciador de Tarefas ===");
Listar();

Concluir(1);

Console.WriteLine();
Console.WriteLine("=== Depois de concluir a tarefa #1 ===");
Listar();

Console.WriteLine();
Console.WriteLine("=== Tarefas Pendentes ===");
ListarTarefasPendentes();

Console.ReadLine();
