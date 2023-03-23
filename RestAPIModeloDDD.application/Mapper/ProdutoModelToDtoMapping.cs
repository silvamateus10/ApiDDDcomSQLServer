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
    public class ProdutoModelToDtoMapping : Profile
    {
        public ProdutoModelToDtoMapping()
        {
            ProdutoDtoMap();
        }
        private void ProdutoDtoMap()
        {
            CreateMap<Produto, ProdutoDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(x => x.Id))
                .ForMember(dest => dest.Nome, opt => opt.MapFrom(x => x.Nome))
                .ForMember(dest => dest.Valor, opt => opt.MapFrom(x => x.Valor));
        }
    }
}
