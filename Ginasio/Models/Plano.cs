namespace Ginasio.Models
{
    public class Plano
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public int DuracaoMes { get; set; }

        public ICollection<Inscricao> Inscricoes { get; set; }
    }
}
