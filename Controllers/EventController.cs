using Juanfewi.Data;
using Juanfewi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Juanfewi.Controllers;

public class EventController : Controller
{
    private readonly DataContext _context;

    public EventController(DataContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var events = _context.Events.ToList(); 
        return View(events);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Store(Event events)
    {
        var eventDB = _context.Events.Add(events);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }

    public IActionResult Show(int id)
    {
        var events = _context.Events.Find(id);
        return View(events);
    }

    public IActionResult Edit(int id)
    {
        var events = _context.Events.Find(id);
        return View(events);
    }
    
    [HttpPost]
    public IActionResult Update(Event events)
    {
        _context.Events.Update(events);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }

    public IActionResult Destroy(int id)
    {
        var events = _context.Events.Find(id);
        _context.Events.Remove(events);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }
    
}