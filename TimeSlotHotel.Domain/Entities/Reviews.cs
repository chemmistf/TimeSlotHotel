namespace TimeSlotHotel.Domain.Entities;

public class Reviews
{
    public Guid Id { get; set; }
    
    public Guid UserId { get; set; }
    public Guid HotelId { get; set; }
    
    public int Rating { get; set; }
    public string Comment { get; set; } = string.Empty;
    public bool IsApproved { get; set; }
    
    public DateTimeOffset CreatedAt { get; set; }
}