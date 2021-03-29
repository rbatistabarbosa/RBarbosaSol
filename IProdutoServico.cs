using System.Collections.Generic;
using System.Threading.Tasks;

namespace DojoDDD.Api.DojoDDD.Domain
{
    public interface IProdutoServico
    {
        Task<Produto> ConsultarPorId(int id);
        Task<IEnumerable<Produto>> ConsultarTodosProdutos();
    }
}