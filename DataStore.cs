using Bogus;
using DojoDDD.Api.DojoDDD.Domain;
using System.Collections.Generic;
using System.Linq;

namespace DojoDDD.Api.Infrastructure
{
    public class DataStore
    {
        public List<OrdemCompra> OrdensCompras { get; set; } = new List<OrdemCompra>();

        public List<Cliente> Clientes { get; set; }
        public List<Produto> Produtos { get; set; }

        public DataStore()
        {
            LoadFakeData();
        }

        private void LoadFakeData()
        {
            Clientes = new Faker<Cliente>()
                .RuleFor(s => s.Id, f => f.UniqueIndex)
                .RuleFor(s => s.Nome, f => f.Name.FullName())
                .RuleFor(s => s.Endereco, f => f.Address.FullAddress())
                .RuleFor(s => s.Saldo, f => f.Finance.Amount(100, 1000))
                .Generate(10)
                .ToList();

            Produtos = new Faker<Produto>()
                .RuleFor(s => s.Id, f => f.UniqueIndex)
                .RuleFor(s => s.Descricao, f => f.Commerce.ProductName())
                .RuleFor(s => s.Estoque, 1000)
                .RuleFor(s => s.ValorMinimoDeCompra, 500)
                .RuleFor(s => s.PrecoUnitario, f => f.Finance.Amount(1, 100, 2))
                .Generate(5)
                .ToList();

            OrdensCompras = new Faker<OrdemCompra>()
                .RuleFor(s => s.DataOperacao, f => f.Date.Recent(10))
                .RuleFor(s => s.ProdutoId, Produtos.First().Id)
                .RuleFor(s => s.ClienteId, Clientes.First().Id)
                .RuleFor(s => s.QuantidadeSolicitada, 50)
                .RuleFor(s => s.ValorOperacao, f => f.Finance.Amount(1, 100, 2))
                .RuleFor(s => s.PrecoUnitario, f => f.Finance.Amount(1, 100, 2))
                .Generate(3)
                .ToList();
        }
    }
}