using System.Collections.Generic;
using System.Threading.Tasks;

namespace DojoDDD.Api.DojoDDD.Domain
{
    public interface IClienteServico
    {
        Task<Cliente> ConsultarPorId(int id);
        Task<IEnumerable<Cliente>> ConsultarTodosClientes();
    }
}