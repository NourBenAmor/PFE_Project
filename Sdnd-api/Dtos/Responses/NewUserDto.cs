namespace Sdnd_api.Dtos.Responses;

public class NewUserDto
{
    public Guid Id { get; set; }
    public string  Username { get; set; }
    public string Email { get; set; }
    public string Token { get; set; }
    
}