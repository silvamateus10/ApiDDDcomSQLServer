using RestAPIModeloDDD.application.Dtos;
using RestAPIModeloDDD.application.Interfaces;
using RestAPIModeloDDD.Domain.Core.Interface.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestAPIModeloDDD.application
{
    public class ClienteApplicationService : IClienteApplicationService
    {
        private readonly IClienteService clienteService;
        private readonly IClienteMapper clienteMapper;
        public ClienteApplicationService(IClienteService clienteService, IClienteMapper clienteMapper)
        {
            this.clienteService = clienteService;
            this.clienteMapper = clienteMapper;
        }

        public void Add(ClienteDto clienteDto)
        {
            var cliente = clienteMapper.MapperDtoToEntity(clienteDto);
            clienteService.Add(cliente);
        }

        public IEnumerable<ClienteDto> GetAll()
        {
            var clientes = clienteService.GetAll();
            var clientesDto = clienteMapper.MapperLitsClienteDto(clientes);
            return clientesDto;
        }

        public ClienteDto GetById(int id)
        {
            var cliente = clienteService.GetById(id);
            var clienteDto = clienteMapper.MapperEntityToDto(cliente);
            return clienteDto;
        }

        public void Remove(ClienteDto clienteDto)
        {
            var cliente = clienteMapper.MapperDtoToEntity(clienteDto);
            clienteService.Remove(cliente);
        }

        public void Update(ClienteDto clienteDto)
        {
            var cliente = clienteMapper.MapperDtoToEntity(clienteDto);
            clienteService.Update(cliente);
        }
    }
}
