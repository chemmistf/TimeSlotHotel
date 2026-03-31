namespace TimeSlotHotel.Domain.Entities;

public class Payments
{
    public Guid Id { get; set; }
    public Guid BookingId { get; set; }
    
    public decimal Amount { get; set; }
    public string? Currency { get; set; }
    public string? Status { get; set; }
    public DateTimeOffset PaidAt { get; set; }
}