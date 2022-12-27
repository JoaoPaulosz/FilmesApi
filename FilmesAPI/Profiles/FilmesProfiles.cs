using AutoMapper;
using FilmesAPI.Data.Dtos.Filmes;
using FilmesAPI.Models;

namespace FilmesAPI.Profiles
{
    public class FilmesProfiles : Profile

    {
        public FilmesProfiles() 
        {
            CreateMap<CreateFilmeDto, Filme>();
            CreateMap<Filme, ReadFilmeDto>();
            CreateMap<UpdateFilmeDto, Filme>();
        }
    }
}
