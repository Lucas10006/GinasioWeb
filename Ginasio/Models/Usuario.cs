namespace Ginasio.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public int Telefone { get; set; }
        public int Cc { get; set; }
        public int Nif { get; set; }
        public TipoUsuario Tipo { get; set; }
        public DateTime DataInscricao { get; set; }

        public ICollection<Inscricao> Inscricoes { get; set; }
        public ICollection<Agendamento> Agendamentos { get; set; }
        public ICollection<Pagamento> Pagamentos { get; set; }
    }

    public enum TipoUsuario
    {
        Cliente,
        Instrutor,
        Admin
    }
}
