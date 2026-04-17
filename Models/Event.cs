using Microsoft.AspNetCore.Mvc;

namespace Juanfewi.Models;

using System.ComponentModel.DataAnnotations;

public class Event
{
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string Name { get; set; }

    [Required]
    public string Category { get; set; }

    [Required]
    public DateTime Date { get; set; }

    [Required]
    [MaxLength(500)]
    public string Description { get; set; }

    public string Location { get; set; }

    [Url]
    public string ImageUrl { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public bool IsActive { get; set; } = true;
}