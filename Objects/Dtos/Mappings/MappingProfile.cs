using AutoMapper;
using StudentManager.WebAPI.Objects.Dtos.Entities;
using StudentManager.WebAPI.Objects.Models;

namespace StudentManager.WebAPI.Objects.Dtos.Mappings;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Professor, ProfessorDTO>().ReverseMap();
        CreateMap<Aluno, AlunoDTO>().ReverseMap();
    }
}