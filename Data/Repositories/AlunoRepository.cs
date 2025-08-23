using StudentManager.WebAPI.Data.Interfaces;
using StudentManager.WebAPI.Objects.Models;

namespace StudentManager.WebAPI.Data.Repositories;

public class AlunoRepository : GenericRepository<Aluno>, IAlunoRepository
{
    private readonly AppDbContext _context;

    public AlunoRepository(AppDbContext context) : base(context)
    {
        _context = context;
    }
}