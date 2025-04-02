using System.ComponentModel.DataAnnotations;

namespace ComputerService.Models;

public class Game
{
    [Key] public int Id { get; set; }
    public string NameGame { get; set; }
    public decimal Price { get; set; }
}