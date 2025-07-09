namespace Ginasio.Models
{
    public class Inscricao
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
        public int PlanoId { get; set; }
        public Plano Plano { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public StatusInscricao Status { get; set; }
    }

    public enum StatusInscricao
    {
        Ativo,
        Cancelado,
        Expirado
    }
}
