namespace AnimeHub.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Username { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;

        public List<Anime> Animes { get; set; } = new List<Anime>();
    }
}
