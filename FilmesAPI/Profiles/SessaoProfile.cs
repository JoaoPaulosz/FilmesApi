using AutoMapper;
using FilmesAPI.Models;
using FilmesAPI.Data.Dtos;

namespace FilmesAPI.Profiles
{
    public class SessaoProfile : Profile
    {
        public SessaoProfile()
        {
            CreateMap<CreateSessaoDto, Sessao>();
            CreateMap<Sessao, ReadSessaoDto>()
                .ForMember(dto => dto.HorarioInico, opts => opts
                .MapFrom(dto => dto.HorarioEncerramento.AddMinutes(dto.Filme.Duracao * (-1))));
        }
    }
}
