using Juanfewi.Data;
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
        return View();
    }

    public IActionResult Create()
    {
        return View();
    }
}