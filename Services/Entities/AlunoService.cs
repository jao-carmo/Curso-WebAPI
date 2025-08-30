using AutoMapper;
using StudentManager.WebAPI.Data.Interfaces;
using StudentManager.WebAPI.Objects.Dtos.Entities;
using StudentManager.WebAPI.Objects.Models;
using StudentManager.WebAPI.Services.Interfaces;

namespace StudentManager.WebAPI.Services.Entities;

public class AlunoService : GenericService<Aluno, AlunoDTO>, IAlunoService
{
    private readonly IAlunoRepository _alunoRepository;
    private readonly IMapper _mapper;

    public AlunoService(IAlunoRepository alunoRepository, IMapper mapper) : base(alunoRepository, mapper)
    {
        _alunoRepository = alunoRepository;
        _mapper = mapper;
    }
}