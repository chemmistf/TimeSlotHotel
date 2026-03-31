namespace TimeSlotHotel.Domain.Entities;

public class Hotels
{
    public Guid Id { get; set; }
    
    public string Name { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    
    public float Rating { get; set; }
    
    public DateTimeOffset CreatedAt { get; set; }
}