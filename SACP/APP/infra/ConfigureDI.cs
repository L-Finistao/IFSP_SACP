using APP.Forms.Cadastro;
using APP.Models;
using AutoMapper;
using Domain.Base;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Repository.Context;
using Repository.Repository;
using SACP.APP.Cadastros;
using Service.Services;

namespace APP.infra
{
    public static class ConfigureDI
    {

        public static ServiceCollection? Services;
        public static ServiceProvider? ServicesProvider;

        public static void ConfiguraServices()
        {
            Services = new ServiceCollection();
            Services.AddDbContext<MySqlContext>(options =>
            {
                var strCon = File.ReadAllText("Config/DatabaseSettings.txt");
                options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
                options.EnableSensitiveDataLogging();


                options.UseMySql(strCon, ServerVersion.AutoDetect(strCon), opt =>
                {
                    opt.CommandTimeout(180);
                    opt.EnableRetryOnFailure(5);

                });
            });

            // Repositories
            Services.AddScoped<IBaseRepository<Usuario>, BaseRepository<Usuario>>();
            Services.AddScoped<IBaseRepository<Cid>, BaseRepository<Cid>>();
            Services.AddScoped<IBaseRepository<CategoriaConsulta>, BaseRepository<CategoriaConsulta>>();
            Services.AddScoped<IBaseRepository<CategoriaEspecialidade>, BaseRepository<CategoriaEspecialidade>>();
            Services.AddScoped<IBaseRepository<Procedimento>, BaseRepository<Procedimento>>();
            Services.AddScoped<IBaseRepository<Usuario_Medico>, BaseRepository<Usuario_Medico>>();
            Services.AddScoped<IBaseRepository<Agenda>, BaseRepository<Agenda>>();
            Services.AddScoped<IBaseRepository<Medico_Especialidades>, BaseRepository<Medico_Especialidades>>();
            Services.AddScoped<IBaseRepository<Consulta>, BaseRepository<Consulta>>();



            // Services
            Services.AddScoped<IBaseService<Usuario>, BaseService<Usuario>>();
            Services.AddScoped<IBaseService<Cid>, BaseService<Cid>>();
            Services.AddScoped<IBaseService<CategoriaConsulta>, BaseService<CategoriaConsulta>>();
            Services.AddScoped<IBaseService<CategoriaEspecialidade>, BaseService<CategoriaEspecialidade>>();
            Services.AddScoped<IBaseService<Procedimento>, BaseService<Procedimento>>();
            Services.AddScoped<IBaseService<Usuario_Medico>, BaseService<Usuario_Medico>>();
            Services.AddScoped<IBaseService<Agenda>, BaseService<Agenda>>();
            Services.AddScoped<IBaseService<Medico_Especialidades>, BaseService<Medico_Especialidades>>();
            Services.AddScoped<IBaseService<Consulta>, BaseService<Consulta>>();

            // Formulários
            Services.AddTransient<Cadastro_CID, Cadastro_CID>();
            Services.AddTransient<Cadastro_Cat_Consulta, Cadastro_Cat_Consulta>();
            Services.AddTransient<Catastro_Cat_Especialidade, Catastro_Cat_Especialidade>();
            Services.AddTransient<Cadastro_Agenda, Cadastro_Agenda>();
            Services.AddTransient<Cadastro_Medico, Cadastro_Medico>();
            Services.AddTransient<Cadastro_Procedimento, Cadastro_Procedimento>();
            Services.AddTransient<Especialidade, Especialidade>();
            Services.AddTransient<UsuarioForm, UsuarioForm>();





            // Mapping
            Services.AddSingleton(new MapperConfiguration(config =>
            {
                config.CreateMap<Cid, CIDModels>();
                config.CreateMap<CategoriaConsulta, CategoriaConsultaModels>();
                config.CreateMap<CategoriaEspecialidade, CategoriaEspecialidadeModels>();
                //config.CreateMap<Usuario, UsuarioModels>();
                //config.CreateMap<Usuario_Medico, Usuario_MedicoModels>();
                _ = config.CreateMap<Procedimento, ProcedimentoModels>()
                .ForMember(d => d.Codigo_CID, d => d.MapFrom(x => x.Cid!.Codigo_CID))
                .ForMember(d => d.Nome_Especialidade, d => d.MapFrom(mapExpression: x => x.Profissional.IdMedico.UsuarioMedico.Nome));
                //config.CreateMap<Medico_Especialidades, Medico_EspecialidadesModels>();
                //config.CreateMap<Consulta, ConsultaModels>();
                //config.CreateMap<Agenda, AgendaModel>();

            }).CreateMapper());


            /*  Services.AddSingleton(new MapperConfiguration(config =>
              {
                  config.CreateMap<Usuario, UsuarioModel>();
                  config.CreateMap<Cidade, CidadeModel>().ForMember(d => d.NomeEstado, d => d.MapFrom(x => $"{x.Nome}/{x.Estado}"));
                  config.CreateMap<Cliente, ClienteModel>()
                      .ForMember(d => d.Cidade, d => d.MapFrom(x => $"{x.Cidade!.Nome}/{x.Cidade!.Estado}"))
                      .ForMember(d => d.IdCidade, d => d.MapFrom(x => x.Cidade!.Id));
                  config.CreateMap<Grupo, Grupo>();
                  config.CreateMap<Produto, ProdutoModel>()
                      .ForMember(d => d.Grupo, d => d.MapFrom(x => x.Grupo!.Nome))
                      .ForMember(d => d.IdGrupo, d => d.MapFrom(x => x.Grupo!.Id));
                  config.CreateMap<Venda, VendaModel>()
                      .ForMember(d => d.IdCliente, d => d.MapFrom(x => x.Cliente!.Id))
                      .ForMember(d => d.Cliente, d => d.MapFrom(x => x.Cliente!.Nome))
                      .ForMember(d => d.IdUsuario, d => d.MapFrom(x => x.Usuario!.Id))
                      .ForMember(d => d.Usuario, d => d.MapFrom(x => x.Usuario!.Nome));

                  config.CreateMap<VendaItem, VendaItemModel>()
                      .ForMember(d => d.IdProduto, d => d.MapFrom(x => x.Produto!.Id))
                      .ForMember(d => d.Produto, d => d.MapFrom(x => x.Produto!.Nome));

              }).CreateMapper());*/

            ServicesProvider = Services.BuildServiceProvider();
        }

    }
}
