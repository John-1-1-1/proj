using System.ComponentModel.DataAnnotations;

namespace BlazorApp6.Components.Tables;

public class OlympiadCards {

    [Key] public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Subject { get; set; } = string.Empty;
    public string Level { get; set; } = string.Empty;
    public int StartClass { get; set; }
    public int EndClass { get; set; }
    public DateTime StartRegDate { get; set; }
    public DateTime EndRegDate { get; set; }
    public string Url { get; set; } = string.Empty;
}
