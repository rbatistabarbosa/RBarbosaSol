using System.Collections.Generic;
using System.Threading.Tasks;

namespace DojoDDD.Api.DojoDDD.Domain
{
    public interface IClienteRepositorio
    {
        Task<Cliente> ConsultarPorId(int id);
        Task<IEnumerable<Cliente>> ConsultarTodosClientes();
    }
}