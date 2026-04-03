namespace TimeSlotHotel.Domain.Entities;

public class User
{
    public Guid Id { get; set; }

    public string? Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty; 
    public string PasswordHash { get; set; } = string.Empty;
    
    public string? Role { get; set; }
    public bool IsBlocked { get; set; } = false;
    
    public DateTimeOffset CreatedAt { get; set; }

    public List<Notifications> NotificationList { get; set; } = new();
    public List<Reviews> ReviewList { get; set; } = new();
}