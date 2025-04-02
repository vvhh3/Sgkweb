using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ComputerService.Models;

public class RecordOfGame
{
    [Key] public int Id { get; set; }
    
    public int? GameId { get; set; }
    [ForeignKey("GameId")] public Game? Game { get; set; }
    
    public int? PlayerId { get; set; }
    [ForeignKey("PlayerId")] public Gamer? Player { get; set; }
    
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
}