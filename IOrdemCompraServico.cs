using System.Threading.Tasks;

namespace DojoDDD.Api.DojoDDD.Domain
{
    public interface IOrdemCompraServico
    {
        Task<OrdemCompra> ConsultarPorId(string id);
        Task<bool> AlterarStatudOrdemDeCompraParaEmAnalise(string ordemDeCompraId);
        Task<string> RegistrarOrdemCompra(int clienteId, int produtoId, int quantidadeCompra);
    }
}