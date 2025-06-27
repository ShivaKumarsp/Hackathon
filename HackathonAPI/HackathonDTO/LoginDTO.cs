namespace HackathonAPI.HackathonDTO
{
    public class LoginDTO:LoginResponceModel
    {
        public int UserId { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public string? Success { get; set; }
        public bool Return { get; set; }
        public Array? loginList { get; set; }
        public Array? userList { get; set; }
    }
}
