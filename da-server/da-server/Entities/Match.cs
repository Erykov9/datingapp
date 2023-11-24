namespace da_server.Entities
{
    public class Match
    {
        public Guid MatchId { get; set; }
        public string CreatedAt { get; set; } = string.Empty;
        public Guid UserId { get; set; }
        public Guid MatchedId { get; set; }
    }
}