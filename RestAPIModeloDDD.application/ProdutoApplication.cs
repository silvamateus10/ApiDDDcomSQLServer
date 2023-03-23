using AutoMapper;
using RestAPIModeloDDD.application.Dtos;
using RestAPIModeloDDD.application.Interfaces;
using RestAPIModeloDDD.Domain.Core.Interface.Services;
using RestAPIModeloDDD.Domain.Entities;
using RestAPIModeloDDD.Infrastructure.CrossCutting.Interface;

namespace RestAPIModeloDDD.application
{
    public class ProdutoApplication : IProdutoApplication
    {
        private readonly IProdutoService produtoService;
        private readonly IMapper mapper;


        public ProdutoApplication(IProdutoService produtoService, IMapper mapper)
        {
            this.produtoService = produtoService;
            this.mapper = mapper;
        }

        public void Add(ProdutoDto produtoDto)
        {
            var produto = mapper.Map<Produto>(produtoDto);
            produtoService.Add(produto);
        }

        public IEnumerable<ProdutoDto> GetAll()
        {
            var produtos = produtoService.GetAll();
            var produtosDto = mapper.Map<IEnumerable<ProdutoDto>>(produtos);
            return produtosDto;
        }

        public ProdutoDto GetById(int id)
        {
            var produto = produtoService.GetById(id);
            var produtoDto = mapper.Map<ProdutoDto>(produto);
            return produtoDto;
        }

        public void Remove(ProdutoDto produtoDto)
        {
            var produto = mapper.Map<Produto>(produtoDto);
            produtoService.Remove(produto);
        }

        public void Update(ProdutoDto produtoDto)
        {
            var produto = mapper.Map<Produto>(produtoDto);
            produtoService.Update(produto);
        }
    }
}
