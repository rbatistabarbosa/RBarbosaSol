using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DojoDDD.Api.DojoDDD.Domain
{
    public class ClienteServico : IClienteServico
    {
        private readonly IClienteRepositorio _clienteRepositorio;

        public ClienteServico(IClienteRepositorio clienteRepositorio)
        {
            _clienteRepositorio = clienteRepositorio;
        }

        public async Task<IEnumerable<Cliente>> ConsultarTodosClientes()
        {
            return await _clienteRepositorio.ConsultarTodosClientes();
        }

        public async Task<Cliente> ConsultarPorId(int idCliente)
        {
            return await _clienteRepositorio.ConsultarPorId(idCliente).ConfigureAwait(false);
        }
    }
}
