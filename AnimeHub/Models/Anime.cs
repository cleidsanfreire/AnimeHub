namespace AnimeHub.Models
{
    public class Anime
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty; // Assistido / Para assisitr / Futuro
        public int? Nota { get; set; }

        public string? Descricao { get; set; } // Sinopse oficial do anime
        public string? Observacoes { get; set; } // Comentários pessoais do usuário

        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; } = null!;
    }
}
