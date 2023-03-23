using RestAPIModeloDDD.application.Dtos;
using RestAPIModeloDDD.Domain.Entities;

namespace RestAPIModeloDDD.application.Interfaces
{
    public interface IClienteMapper
    {
        Cliente MapperDtoToEntity(ClienteDto clienteDto);
        IEnumerable<ClienteDto> MapperLitsClienteDto(IEnumerable<Cliente> clientes);
        ClienteDto MapperEntityToDto(Cliente cliente);
    }
}
