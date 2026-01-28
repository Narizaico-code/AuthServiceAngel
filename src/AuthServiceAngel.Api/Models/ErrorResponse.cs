using System.Diagnostics;

namespace AuthServiceAngel.Api.Models;

public class ErrorResponse
{
    public string StatusCode { get; set; }
    public string Title { get; set; }
    public string Detail { get; set; }
    public string? ErrorCode { get; set; } 
    public string TraceId { get; set; } = Activity.Current?.Id ?? string.Empty;
    public DateTime Timestamp { get; set; } = DateTime.UtcNow;
}