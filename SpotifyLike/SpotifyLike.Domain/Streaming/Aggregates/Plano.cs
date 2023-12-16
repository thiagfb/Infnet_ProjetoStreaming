using SpotifyLike.Domain.Core.ValueObject;

namespace SpotifyLike.Domain.Streaming.Aggregates
{
    public class Plano
    {
        public Guid Id { get; set; }

        public String Nome { get; set; }

        public String Descricao { get; set; }

        public Monetario Valor { get; set; }
    }
}
