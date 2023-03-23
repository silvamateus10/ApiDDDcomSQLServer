using RestAPIModeloDDD.application.Dtos;
using RestAPIModeloDDD.application.Interfaces;
using RestAPIModeloDDD.Domain.Core.Interface.Services;
using RestAPIModeloDDD.Infrastructure.CrossCutting.Interface;

namespace RestAPIModeloDDD.application
{
    public class ProdutoApplicationService : IProdutoApplicationService
    {
        private readonly IProdutoService produtoService;
        private readonly IProdutoMapper produtoMapper;

        public ProdutoApplicationService(IProdutoService produtoService, IProdutoMapper produtoMapper)
        {
            this.produtoService = produtoService;
            this.produtoMapper = produtoMapper;
        }

        public void Add(ProdutoDto produtoDto)
        {
            var produto = produtoMapper.MapperDtoToEntity(produtoDto);
            produtoService.Add(produto);
        }

        public IEnumerable<ProdutoDto> GetAll()
        {
            var produtos = produtoService.GetAll();
            var produtosDto = produtoMapper.MapperLitsClienteDto(produtos);
            return produtosDto;
        }

        public ProdutoDto GetById(int id)
        {
            var produto = produtoService.GetById(id);
            var produtoDto = produtoMapper.MapperEntityToDto(produto);
            return produtoDto;
        }

        public void Remove(ProdutoDto produtoDto)
        {
            var produto = produtoMapper.MapperDtoToEntity(produtoDto);
            produtoService.Remove(produto);
        }

        public void Update(ProdutoDto produtoDto)
        {
            var produto = produtoMapper.MapperDtoToEntity(produtoDto);
            produtoService.Update(produto);
        }
    }
}
