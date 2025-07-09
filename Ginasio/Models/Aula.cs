namespace Ginasio.Models
{
    public class Aula
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int InstrutorId { get; set; }
        public Usuario Instrutor { get; set; }
        public ICollection<Agendamento> Agendamentos { get; set; }
    }
}
