namespace TrybeHotel.Dto
{
    public class UserDto
    {
        public int UserId { get; set; }
        public string? Email { get; set; } = string.Empty;
        public string? Name { get; set; } = string.Empty;
        public string? UserType { get; set; } = string.Empty;

    }

    public class UserDtoInsert
    {
        public string? Name { get; set; } = string.Empty;
        public string? Password { get; set; } = string.Empty;
        public string? Email { get; set; } = string.Empty;
    }

    public class LoginDto
    {
        public string? Password { get; set; } = string.Empty;
        public string? Email { get; set; } = string.Empty;
    }
}