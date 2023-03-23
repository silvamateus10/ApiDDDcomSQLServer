using AutoMapper;
using RestAPIModeloDDD.application.Dtos;
using RestAPIModeloDDD.application.Interfaces;
using RestAPIModeloDDD.Domain.Core.Interface.Services;
using RestAPIModeloDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestAPIModeloDDD.application
{
    public class ClienteApplication : IClienteApplication
    {
        private readonly IClienteService clienteService;
        private readonly IMapper mapper;
        public ClienteApplication(IClienteService clienteService, IMapper mapper)
        {
            this.clienteService = clienteService;
            this.mapper = mapper;
        }

        public void Add(ClienteDto clienteDto)
        {
            var cliente = mapper.Map<Cliente>(clienteDto);
            clienteService.Add(cliente);
        }

        public IEnumerable<ClienteDto> GetAll()
        {
            var clientes = clienteService.GetAll();
            var clientesDto = mapper.Map<IEnumerable<ClienteDto>>(clientes);
            return clientesDto;
        }

        public ClienteDto GetById(int id)
        {
            var cliente = clienteService.GetById(id);
            var clienteDto = mapper.Map<ClienteDto>(cliente);
            return clienteDto;
        }

        public void Remove(ClienteDto clienteDto)
        {
            var cliente = mapper.Map<Cliente>(clienteDto);
            clienteService.Remove(cliente);
        }

        public void Update(ClienteDto clienteDto)
        {
            var cliente = mapper.Map<Cliente>(clienteDto);
            clienteService.Update(cliente);
        }
    }
}
