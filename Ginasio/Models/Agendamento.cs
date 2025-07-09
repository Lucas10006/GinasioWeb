namespace Ginasio.Models
{
    public class Agendamento
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public int AulaId { get; set; }
        public DateTime DataHora { get; set; }
        public StatusAgendamento Status { get; set; }
    }

    public enum StatusAgendamento
    {
        Pendente,
        Confirmado,
        Cancelado
    }
}
