using SpotifyLike.Domain.Conta.Agreggates;
using SpotifyLike.Domain.Streaming.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyLike.Domain.Streaming.Aggregates
{
    public class Musica
    {
        public Guid Id { get; set; }

        public String Nome { get; set; }

        /// <summary>
        /// A música tem duração de minutos ou segundos? 1 minuto é igual a 60 segundos.
        /// A classe Duracao então irá fazer a conversão de minutos para segundos.
        /// </summary>
        public Duracao Duracao { get; set; }

        public List<Playlist> Playlists { get; set; } = new List<Playlist>();
    }
}
