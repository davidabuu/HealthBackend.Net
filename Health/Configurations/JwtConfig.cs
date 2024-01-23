namespace Health.Configurations
{
    public class JwtConfig
    {
        public string? Secret { get; set; }
        public TimeSpan? ExpriryTimeFrame { get; set; }
    }
}
