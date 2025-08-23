using StudentManager.WebAPI.Data.Interfaces;
using StudentManager.WebAPI.Objects.Models;

namespace StudentManager.WebAPI.Data.Repositories;

public class ProfessorRepository : GenericRepository<Professor>, IProfessorRepository
{
    private readonly AppDbContext _context;

    public ProfessorRepository(AppDbContext context) : base(context)
    {
        _context = context;
    }
}