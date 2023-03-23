using AutoMapper;
using RestAPIModeloDDD.application.Dtos;
using RestAPIModeloDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestAPIModeloDDD.application.Mapper
{
    public class ProdutoDtoToModelMapping : Profile
    {
        public ProdutoDtoToModelMapping()
        {
            ProdutoMap();
        }

        private void ProdutoMap()
        {
            CreateMap<ProdutoDto, Produto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(x => x.Id))
                .ForMember(dest => dest.Nome, opt => opt.MapFrom(x => x.Nome))
                .ForMember(dest => dest.Valor, opt => opt.MapFrom(x => x.Valor))
                .ForMember(dest => dest.IsDisponivel, opt => opt.Ignore());
        }
    }
}
