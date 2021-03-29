namespace DojoDDD.Api.DojoDDD.Domain
{
    public class Produto
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int Estoque { get; set; }
        public decimal PrecoUnitario { get; set; }
        public decimal ValorMinimoDeCompra { get; set; }
    }
}