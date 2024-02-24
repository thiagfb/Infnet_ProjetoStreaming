using Spotify.Application.Conta.Dto;
using SpotifyLike.Domain.Conta.Agreggates;
using SpotifyLike.Domain.Transacao.Agreggates;

namespace Spotify.Application.Conta.Profile
{
    public class UsuarioProfile : AutoMapper.Profile
    {
        public UsuarioProfile()
        {
            CreateMap<UsuarioDto, Usuario>();

            CreateMap<Usuario, UsuarioDto>()
            .AfterMap((s, d) =>
            {
                var plano = s.Assinaturas?.FirstOrDefault(a => a.Ativo)?.Plano;

                if (plano != null)
                    d.PlanoId = plano.Id;

                //Irá retornar mascarado
                d.Senha = "xxxxxxxx";
            });

            //Mapeamento entre o cartão DTO e o Cartao do Domain
            //Formember é a transformação do campo Limite de Monetario para Decimal
            //Usando o ReverseMap é o mesmo mapeamento usado do usuário.
            CreateMap<CartaoDto, Cartao>()
                .ForPath(x => x.Limite, m => m.MapFrom(f => f.Limite))
                .ReverseMap();
        }
    }
}
