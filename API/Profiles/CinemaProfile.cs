using API.Models;
using API.Models.Dtos.CinemaDto;
using AutoMapper;
using FilmesAPI.Data.Dtos;
using FilmesAPI.Models;

namespace API.Profiles
{
    public class CinemaProfile : Profile
    {
        public CinemaProfile()
        {
            CreateMap<CreateCinemaDto, Cinema>();
            CreateMap<Cinema, ReadCinemaDto>();
            CreateMap<UpdateCinemaDto, Cinema>();
        }
    }
}
