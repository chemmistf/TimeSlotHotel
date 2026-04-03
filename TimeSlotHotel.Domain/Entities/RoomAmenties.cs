namespace TimeSlotHotel.Domain.Entities;

public class RoomAmenties
{
    public Guid Id { get; set; }
    public Guid RoomId { get; set; }
    public string? Name { get; set; }
}