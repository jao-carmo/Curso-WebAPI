using AutoMapper;
using StudentManager.WebAPI.Data.Interfaces;
using StudentManager.WebAPI.Objects.Dtos.Entities;
using StudentManager.WebAPI.Objects.Models;
using StudentManager.WebAPI.Services.Interfaces;

namespace StudentManager.WebAPI.Services.Entities;

public class ProfessorService : GenericService<Professor, ProfessorDTO>, IProfessorService
{
    private readonly IProfessorRepository _professorRepository;
    private readonly IMapper _mapper;

    public ProfessorService(IProfessorRepository professorRepository, IMapper mapper) : base(professorRepository, mapper)
    {
        _professorRepository = professorRepository;
        _mapper = mapper;
    }
}