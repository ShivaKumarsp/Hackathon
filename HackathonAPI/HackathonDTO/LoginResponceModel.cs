namespace HackathonAPI.HackathonDTO
{
    public class LoginResponceModel
    {
        public string? UserName { get; set; }
        public string? AccessToken { get; set; }
        public int ExpireIn { get; set; }
    }
}
