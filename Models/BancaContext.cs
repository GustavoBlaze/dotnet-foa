using Microsoft.EntityFrameworkCore;

namespace banca.Model
{
  public class BancaContext : DbContext
  {
    public BancaContext(DbContextOptions<BancaContext> options) : base(options) { }
    public DbSet<Aluno>? Alunos { get; set; }
    public DbSet<Curso>? Cursos { get; set; }
    public DbSet<Turma>? Turmas { get; set; }
  }
}