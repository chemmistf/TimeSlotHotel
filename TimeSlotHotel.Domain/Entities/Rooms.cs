namespace TimeSlotHotel.Domain.Entities;

public class Rooms
{
    public Guid Id { get; set; }
    public Guid HotelId { get; set; }
    
    public string Type { get; set; } = string.Empty;
    
    public decimal PricePerNight { get; set; }
    public string Status { get; set; } = string.Empty;
}