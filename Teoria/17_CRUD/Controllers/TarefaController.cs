using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;


public class TarefaController : Controller
{

    private static List<Tarefa> _Tarefas = new List<Tarefa>();

    public IActionResult Index()
    {
        return View(_Tarefas);
    }

    public IActionResult Adicionar()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Adicionar(Tarefa novaTarefa)
    {
        novaTarefa.Id = _Tarefas.Count + 1;
        _Tarefas.Add(novaTarefa);
        return RedirectToAction("Index");
    }

    public IActionResult Editar(int id)
    {
        Tarefa NovaTarefa = _Tarefas.FirstOrDefault(t => t.Id == id);

        if (NovaTarefa == null)
        {
            return NotFound();
        }

        return View(NovaTarefa);

    }

    [HttpPost]
    public IActionResult Editar(Tarefa TarefaEditada)
    {
        Tarefa TarefaEncontrada = _Tarefas.FirstOrDefault(t => t.Id == TarefaEditada.Id);

        if (TarefaEncontrada == null)
        {
            return NotFound();
        }

        TarefaEncontrada.Descricao = TarefaEditada.Descricao;
        TarefaEncontrada.Concluido = TarefaEditada.Concluido;

        return RedirectToAction("Index");
    }

    [HttpPost]
    public IActionResult Deletar(int id)
    {
        Tarefa TarefaEncontrada = _Tarefas.FirstOrDefault(t => t.Id == id);

        if (TarefaEncontrada == null)
        {
            return NotFound();
        }

        return View(TarefaEncontrada);
    }

    [HttpPost]
    public IActionResult DeletarConfirmado(int id)
    {
        Tarefa TarefaEncontrada = _Tarefas.FirstOrDefault(t => t.Id == id);

        if (TarefaEncontrada == null)
        {
            return NotFound();
        }

        _Tarefas.Remove(TarefaEncontrada);
        return RedirectToAction("Index");
    }
}
