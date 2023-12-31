﻿using APP.Base.Registro;
using APP.Forms.Cadastro;
using APP.Models;
using AutoMapper;
using Domain.Base;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Repository.Context;
using Repository.Repository;
using Service.Services;
using Microsoft.Extensions.Logging;
using SGA;
using App.Outros;
using App.Models;
using App.Cadastro;

namespace APP.infra
{
    public static class ConfigureDI
    {

        public static ServiceCollection? Services;
        public static ServiceProvider? ServicesProvider;

        public static void ConfiguraServices()
        {
            Services = new ServiceCollection();
            var strCon = File.ReadAllText("Config/DatabaseSettings.txt");
            Services.AddDbContext<MySqlContext>(options =>
            {
                options.LogTo(Console.WriteLine)
                    .EnableSensitiveDataLogging();
                //options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
                //options.EnableSensitiveDataLogging();


                options.UseMySql(strCon, ServerVersion.AutoDetect(strCon), opt =>
                {
                    opt.CommandTimeout(180);
                    opt.EnableRetryOnFailure(5);
                });
            });


            // Repositories
            Services.AddScoped<IBaseRepository<Entity_Usuario>, BaseRepository<Entity_Usuario>>();
            Services.AddScoped<IBaseRepository<Entity_Usuario_Medico>, BaseRepository<Entity_Usuario_Medico>>();
            Services.AddScoped<IBaseRepository<Entity_Procedimento>, BaseRepository<Entity_Procedimento>>();
            Services.AddScoped<IBaseRepository<Entity_Agenda>, BaseRepository<Entity_Agenda>>();
            Services.AddScoped<IBaseRepository<Entity_Consulta>, BaseRepository<Entity_Consulta>>();
            Services.AddScoped<IBaseRepository<Usuario>, BaseRepository<Usuario>>();


            // Services
            Services.AddScoped<IBaseService<Usuario>, BaseService<Usuario>>();
            Services.AddScoped<IBaseService<Entity_Usuario>, BaseService<Entity_Usuario>>();
            Services.AddScoped<IBaseService<Entity_Usuario_Medico>, BaseService<Entity_Usuario_Medico>>();
            Services.AddScoped<IBaseService<Entity_Procedimento>, BaseService<Entity_Procedimento>>();
            Services.AddScoped<IBaseService<Entity_Agenda>, BaseService<Entity_Agenda>>();
            Services.AddScoped<IBaseService<Entity_Consulta>, BaseService<Entity_Consulta>>();
           

            // Formulários

            Services.AddTransient<Cad_Usuario, Cad_Usuario>();
            Services.AddTransient<Cad_Medicos, Cad_Medicos>();
            Services.AddTransient<Cad_Procedimento, Cad_Procedimento>();
            Services.AddTransient<Cad_Agenda, Cad_Agenda>();
            Services.AddTransient<Cad_Consulta, Cad_Consulta>();
            Services.AddTransient<FormReport, FormReport>();
            Services.AddTransient<FormReportCurso, FormReportCurso>();
            Services.AddTransient<Login, Login>();
            Services.AddTransient<CadastroUsuario, CadastroUsuario>();





            // Mapping
            Services.AddSingleton(new MapperConfiguration(config =>
            {
                config.CreateMap<Usuario, UsuarioModel>();
                config.CreateMap<Entity_Usuario, Entity_ModelsUsuario>();
                config.CreateMap<Entity_Usuario_Medico, Entity_ModelsUsuarioMedico>();
                config.CreateMap<Entity_Procedimento, Entity_ModelsProcedimento>()
                   .ForMember(d => d.Nome_Medico, d => d.MapFrom(x => x.Id_Medico.Nome))
                   .ForMember(d => d.Especialidade_Medico, d => d.MapFrom(x => x.Id_Medico.Especialidade))
                   .ForMember(d => d.Nome_Paciente, d => d.MapFrom(x => x.Id_Paciente.Nome))
                   .ForMember(d => d.Vinculo_Paciente, d => d.MapFrom(x => x.Id_Paciente.Vinculo));
                config.CreateMap<Entity_Agenda, Entity_ModelsAgenda>()
                   .ForMember(d => d.Nome_Medico, d => d.MapFrom(x => x.IdMedico.Nome))
                   .ForMember(d => d.Especialidade_Medico, d => d.MapFrom(x => x.IdMedico.Especialidade));

                config.CreateMap<Entity_Consulta, Entity_ModelsConsulta>()
                    .ForMember(d => d.Nome_Medico, d => d.MapFrom(x => x.Agenda.IdMedico.Nome))
                    .ForMember(d => d.IdMedico, d => d.MapFrom(x => x.Agenda.Id))
                    .ForMember(d => d.Especialidade_Medico, d => d.MapFrom(x => x.Agenda.IdMedico.Especialidade))
                    .ForMember(d => d.Nome, d => d.MapFrom(x => x.Paciente.Nome)) 
                    .ForMember(d => d.IdPaciente, d => d.MapFrom(x => x.Paciente.Id)) 
                    .ForMember(d => d.Nome_Agenda, d => d.MapFrom(x => x.Agenda.Nome))
                    .ForMember(d => d.Periodo_Consulta, d => d.MapFrom(x => x.Agenda.Periodo))
                    .ForMember(d => d.DataAgenda, d => d.MapFrom(x => x.Agenda.DataAgenda))
                    .ForMember(d => d.Vinculo, d => d.MapFrom(x => x.Paciente.Vinculo));




            }).CreateMapper());

            ServicesProvider = Services.BuildServiceProvider();
        }

    }
}
