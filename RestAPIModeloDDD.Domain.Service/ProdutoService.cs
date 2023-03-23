using RestAPIModeloDDD.Domain.Core.Interface.Repositories;
using RestAPIModeloDDD.Domain.Core.Interface.Services;
using RestAPIModeloDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestAPIModeloDDD.Domain.Service
{
    public class ProdutoService : BaseService<Produto>, IProdutoService
    {
        private readonly IProdutoRepository produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository)
            :base(produtoRepository)
        {
            this.produtoRepository = produtoRepository;
        }
    }
}
