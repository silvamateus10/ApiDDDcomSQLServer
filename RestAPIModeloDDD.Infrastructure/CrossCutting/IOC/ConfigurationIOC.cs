using Autofac;
using AutoMapper;
using RestAPIModeloDDD.application;
using RestAPIModeloDDD.application.Interfaces;
using RestAPIModeloDDD.application.Mapper;
using RestAPIModeloDDD.Domain.Core.Interface.Repositories;
using RestAPIModeloDDD.Domain.Core.Interface.Services;
using RestAPIModeloDDD.Domain.Service;
using RestAPIModeloDDD.Infrastructure.Data.Repositories;

namespace RestAPIModeloDDD.Infrastructure.CrossCutting.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region IOC

            builder.RegisterType<ClienteApplication>().As<IClienteApplication>();
            builder.RegisterType<ProdutoApplication>().As<IProdutoApplication>();
            builder.RegisterType<ClienteService>().As<IClienteService>();
            builder.RegisterType<ProdutoService>().As<IProdutoService>();
            builder.RegisterType<ClienteRepository>().As<IClienteRepository>();
            builder.RegisterType<ProdutoRepository>().As<IProdutoRepository>();

            builder.Register(ctx => new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new ClienteDtoToModelMapping());
                cfg.AddProfile(new ClienteModelToDtoMapping());
                cfg.AddProfile(new ProdutoDtoToModelMapping());
                cfg.AddProfile(new ProdutoModelToDtoMapping());

            }));

            builder.Register(ctx => ctx.Resolve<MapperConfiguration>().CreateMapper()).As<IMapper>().InstancePerLifetimeScope();

            #endregion IOC
        }


    }
}
