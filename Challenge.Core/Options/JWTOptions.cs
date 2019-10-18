namespace Challenge.Core.Options
{
    public class JwtOptions
    {
        public string JwtKey { get; set; }
        public int JwtExpireMinutes { get; set; } = 120;
        public string JwtIssuer { get; set; }
    }
}