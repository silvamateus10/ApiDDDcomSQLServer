using RestAPIModeloDDD.application.Dtos;
using RestAPIModeloDDD.Domain.Entities;
using RestAPIModeloDDD.Infrastructure.CrossCutting.Interface;

namespace RestAPIModeloDDD.application.Mapper
{
    public class ProdutoMapper : IProdutoMapper
    {
        IEnumerable<ProdutoDto> produtoDto = new List<ProdutoDto>();

        public ProdutoMapper() { }

        public Produto MapperDtoToEntity(ProdutoDto produtoDto)
        {
            var produto = new Produto()
            {
                Id = produtoDto.Id,
                Nome = produtoDto.Nome!,
                Valor = produtoDto.Valor
            };

            return produto;
        }

        public ProdutoDto MapperEntityToDto(Produto produto)
        {
            var produtoDto = new ProdutoDto()
            {
                Id = produto.Id,
                Nome = produto.Nome!,
                Valor = produto.Valor
            };

            return produtoDto;
        }

        public IEnumerable<ProdutoDto> MapperLitsClienteDto(IEnumerable<Produto> produtos)
        {
            var dto = produtos.Select(p => new ProdutoDto
            {
                Id = p.Id,
                Nome = p.Nome,
                Valor = p.Valor
            });
            return dto;
        }
    }
}
