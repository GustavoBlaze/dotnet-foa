namespace banca.Model {
  public class Turma {
    public int id {get; set;}
    public string? Nome {get; set;}
    public int CursoId {get; set;}
    public Curso? Curso {get; set;}
  }
}