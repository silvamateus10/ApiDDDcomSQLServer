using RestAPIModeloDDD.application.Dtos;

namespace RestAPIModeloDDD.application.Interfaces
{
    public interface IClienteApplicationService
    {
        void Add(ClienteDto clienteDto);
        void Update(ClienteDto clienteDto);
        void Remove(ClienteDto clienteDto);
        IEnumerable<ClienteDto> GetAll();
        ClienteDto GetById(int id);

    }
}
