using RestAPIModeloDDD.Domain.Core.Interface.Repositories;
using RestAPIModeloDDD.Domain.Core.Interface.Services;
using RestAPIModeloDDD.Domain.Entities;

namespace RestAPIModeloDDD.Domain.Service
{
    public class ClienteService : BaseService<Cliente>, IClienteService
    {
        private readonly IClienteRepository clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
            : base(clienteRepository)
        {
            this.clienteRepository = clienteRepository;
        }
    }
}
