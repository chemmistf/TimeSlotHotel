namespace TimeSlotHotel.Domain.Entities;

public class Notifications
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    
    public string? Type { get; set; }
    public string? Message { get; set; }
    
    public bool IsRead { get; set; }
    public DateTimeOffset CreatedAt { get; set; }
}