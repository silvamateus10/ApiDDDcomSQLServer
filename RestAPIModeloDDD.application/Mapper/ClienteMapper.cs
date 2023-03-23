using RestAPIModeloDDD.application.Dtos;
using RestAPIModeloDDD.application.Interfaces;
using RestAPIModeloDDD.Domain.Entities;

namespace RestAPIModeloDDD.application.Mapper
{
    public class ClienteMapper : IClienteMapper
    {
        IEnumerable<ClienteDto> clientesDto = new List<ClienteDto>();
        public ClienteMapper() { }

        public Cliente MapperDtoToEntity(ClienteDto clienteDto)
        {
            var cliente = new Cliente()
            {
                Id = clienteDto.Id,
                Nome = clienteDto.Nome!,
                Sobrenome = clienteDto.Sobrenome!,
                Email = clienteDto.Email!
            };

            return cliente;
        }

        public ClienteDto MapperEntityToDto(Cliente cliente)
        {
            var clienteDto = new ClienteDto()
            {
                Id = cliente.Id,
                Nome = cliente.Nome,
                Sobrenome = cliente.Sobrenome,
                Email = cliente.Email
            };

            return clienteDto;
        }

        public IEnumerable<ClienteDto> MapperLitsClienteDto(IEnumerable<Cliente> clientes)
        {
            var dto = clientes.Select(c => new ClienteDto
            {
                Id = c.Id
                    ,
                Nome = c.Nome
                    ,
                Sobrenome = c.Sobrenome
                    ,
                Email = c.Email
            });
            return dto;
        }
    }
}
