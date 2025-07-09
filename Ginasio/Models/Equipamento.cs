namespace Ginasio.Models
{
    public class Equipamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public StatusEquipamento Status { get; set; }
    }

    public enum StatusEquipamento
    {
        Disponivel,
        EmManutencao,
        Indisponivel
    }
}
