using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DojoDDD.Api.DojoDDD.Domain
{
    public class ProdutoServico : IProdutoServico
    {
        private readonly IProdutoRepositorio _produtoRepositorio;

        public ProdutoServico(IProdutoRepositorio produtoRepositorio)
        {
            _produtoRepositorio = produtoRepositorio;
        }

        public async Task<Produto> ConsultarPorId(int idProduto)
        {
            return await _produtoRepositorio.ConsultarPorId(idProduto).ConfigureAwait(false);
        }

        public async Task<IEnumerable<Produto>> ConsultarTodosProdutos()
        {
            return await _produtoRepositorio.ConsultarTodosProdutos();
        }
    }
}
