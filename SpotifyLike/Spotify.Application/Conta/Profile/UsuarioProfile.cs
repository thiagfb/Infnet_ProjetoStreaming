using Spotify.Application.Conta.Request;
using SpotifyLike.Domain.Conta.Agreggates;
using SpotifyLike.Domain.Transacao.Agreggates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.Application.Conta.Profile
{
    public class UsuarioProfile : AutoMapper.Profile
    {
        public UsuarioProfile()
        {
            CreateMap<UsuarioDto, Usuario>();
            CreateMap<Usuario, UsuarioDto>();

            //Mapeamento entre o cartão DTO e o Cartao do Domain
            //Formember é a transformação do campo Limite de Monetario para Decimal
            //Usando o ReverseMap é o mesmo mapeamento usado do usuário.
            CreateMap<CartaoDto, Cartao>()
                .ForMember(x => x.Limite, m => m.MapFrom(f => f.Limite))
                .ReverseMap();
        }
    }
}
