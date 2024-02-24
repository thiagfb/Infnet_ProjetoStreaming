using Spotify.Application.Conta.Request;
using SpotifyLike.Domain.Conta.Agreggates;
using SpotifyLike.Domain.Transacao.Agreggates;

namespace Spotify.Application.Conta.Profile
{
    public class UsuarioProfile : AutoMapper.Profile
    {
        public UsuarioProfile()
        {
            CreateMap<UsuarioDto, Usuario>()
                .AfterMap((s, d) =>
                {
                    var plano = d.Assinaturas?.FirstOrDefault(a => a.Ativo)?.Plano;

                    if (plano != null)
                        s.PlanoId = plano.Id;
                })
                .ReverseMap();

            //Mapeamento entre o cartão DTO e o Cartao do Domain
            //Formember é a transformação do campo Limite de Monetario para Decimal
            //Usando o ReverseMap é o mesmo mapeamento usado do usuário.
            CreateMap<CartaoDto, Cartao>()
                .ForPath(x => x.Limite, m => m.MapFrom(f => f.Limite))
                .ReverseMap();
        }
    }
}
