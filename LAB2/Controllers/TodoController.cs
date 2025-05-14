using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

public class TodoController : Controller
{
    private static List<TodoModel> _todos = new List<TodoModel>();

    public IActionResult Index()
    {
        return View(_todos);
    }

    // GET: Todo/Add
    public IActionResult Add()
    {
        return View();
    }

    // POST: Todo/Add
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Add(TodoModel todo)
    {
        if (ModelState.IsValid)
        {
            // Gán ID tự động
            todo.Id = _todos.Count > 0 ? _todos.Max(t => t.Id) + 1 : 1;
            _todos.Add(todo);
            return RedirectToAction("Index");
        }

        return View(todo);
    }

    // GET: Todo/Edit/5
    public IActionResult Edit(int id)
    {
        var todo = _todos.FirstOrDefault(t => t.Id == id);
        if (todo == null)
            return NotFound();

        return View(todo);
    }

    // POST: Todo/Edit/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Edit(TodoModel todo)
    {
        if (ModelState.IsValid)
        {
            var existing = _todos.FirstOrDefault(t => t.Id == todo.Id);
            if (existing == null)
                return NotFound();

            existing.Title = todo.Title;
            existing.Description = todo.Description;
            return RedirectToAction("Index");
        }

        return View(todo);
    }
}
