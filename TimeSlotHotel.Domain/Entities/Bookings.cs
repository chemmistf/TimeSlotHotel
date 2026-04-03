namespace TimeSlotHotel.Domain.Entities;

public class Bookings
{
    public Guid Id { get; set; }
    
    public Guid UserId { get; set; }
    public Guid RoomId { get; set; }
    
    public DateTimeOffset CheckIn { get; set; } 
    public DateTimeOffset CheckOut { get; set; }
    
    public string? Status { get; set; }
    
    public decimal TotalPrice { get; set; }
    
    public DateTimeOffset CreatedAt { get; set; }
}