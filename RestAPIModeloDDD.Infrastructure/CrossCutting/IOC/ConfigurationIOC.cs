using Autofac;
using RestAPIModeloDDD.application;
using RestAPIModeloDDD.application.Interfaces;
using RestAPIModeloDDD.application.Mapper;
using RestAPIModeloDDD.Domain.Core.Interface.Repositories;
using RestAPIModeloDDD.Domain.Core.Interface.Services;
using RestAPIModeloDDD.Domain.Service;
using RestAPIModeloDDD.Infrastructure.CrossCutting.Interface;
using RestAPIModeloDDD.Infrastructure.Data.Repositories;

namespace RestAPIModeloDDD.Infrastructure.CrossCutting.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region IOC

            builder.RegisterType<ClienteApplicationService>().As<IClienteApplicationService>();
            builder.RegisterType<ProdutoApplicationService>().As<IProdutoApplicationService>();
            builder.RegisterType<ClienteService>().As<IClienteService>();
            builder.RegisterType<ProdutoService>().As<IProdutoService>();
            builder.RegisterType<ClienteRepository>().As<IClienteRepository>();
            builder.RegisterType<ProdutoRepository>().As<IProdutoRepository>();
            builder.RegisterType<ClienteMapper>().As<IClienteMapper>();
            builder.RegisterType<ProdutoMapper>().As<IProdutoMapper>();

            #endregion IOC
        }


    }
}
