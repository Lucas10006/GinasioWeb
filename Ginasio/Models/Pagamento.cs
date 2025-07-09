namespace Ginasio.Models
{
    public class Pagamento
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; } 
        public decimal Valor { get; set; }
        public DateTime DataPagamento { get; set; }
        public MetodoPagamento MetodoPagamento { get; set; }
        public StatusPagamento Status { get; set; }
    }


    public enum MetodoPagamento
    {
        Cartao,
        Dinheiro,
        Transferencia
    }

    public enum StatusPagamento
    {
        Pendente,
        Pago,
        Cancelado
    }
}
