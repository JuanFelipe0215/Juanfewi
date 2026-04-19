using Microsoft.AspNetCore.Mvc;

namespace Juanfewi.Models;

using System.ComponentModel.DataAnnotations;

public class Event
{
    public int Id { get; set; }
    
    public string Name { get; set; }


    public string Category { get; set; }


    public DateTime Date { get; set; }


    public string Description { get; set; }

    public string Location { get; set; }

    [Url]
    public string ImageUrl { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public bool IsActive { get; set; } = true;
}