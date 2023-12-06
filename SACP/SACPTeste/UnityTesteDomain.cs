using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using System.Text.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Security.Cryptography;

namespace SACPTeste
{
    [TestClass]
    public class UnityTesteDomain
    {
        [TestMethod]
        public void Teste_Entity_Usuario()
        {

            var usuario = new Entity_Usuario()
            {
                Nome = "Lucas Finistao",
                Dt_Nasci = DateTime.Today,
                Telefone_01 = "18990123945",
                Telefone_02 = "18990123945",
                Vinculo = "SUS",
                Endereco = "Jose Urbano Cursino"

            };

            Console.WriteLine(JsonSerializer.Serialize(usuario));

            Assert.AreEqual(usuario.Nome, "Lucas Finistao");
            Assert.AreEqual(usuario.Dt_Nasci, DateTime.Today);
            Assert.AreEqual(usuario.Telefone_01, "18990123945");
            Assert.AreEqual(usuario.Telefone_02, "18990123945");
            Assert.AreEqual(usuario.Vinculo,"SUS");
            Assert.AreEqual(usuario.Endereco, "Jose Urbano Cursino");
         }

        [TestMethod]
        public void Teste_Entity_Usuario_Medico() {


            var usuario = new Entity_Usuario_Medico()
            {
                Nome = "Dr Marcos Finistao",
                Dt_Nasci = DateTime.Today,
                Telefone_01 = "18990123945",
                Telefone_02 = "18990123945",
                Vinculo = "SUS",
                Endereco = "Jose Urbano Cursino",
                Codigo = "COD01",
                Especialidade = "Cardiologista"

        };

            Console.WriteLine(JsonSerializer.Serialize(usuario));

            Assert.AreEqual(usuario.Nome, "Dr Marcos Finistao");
            Assert.AreEqual(usuario.Dt_Nasci, DateTime.Today);
            Assert.AreEqual(usuario.Telefone_01, "18990123945");
            Assert.AreEqual(usuario.Telefone_02, "18990123945");
            Assert.AreEqual(usuario.Vinculo, "SUS");
            Assert.AreEqual(usuario.Endereco, "Jose Urbano Cursino");
            Assert.AreEqual(usuario.Codigo,"COD01");
            Assert.AreEqual(usuario.Especialidade,"Cardiologista");


        }

        [TestMethod]
        public void Teste_Entity_Procedimento() {

            var usuario = new Entity_Usuario()
            {
                Nome = "Lucas Finistao",
                Dt_Nasci = DateTime.Today,
                Telefone_01 = "18990123945",
                Telefone_02 = "18990123945",
                Vinculo = "SUS",
                Endereco = "Jose Urbano Cursino"

            };
            var usuario_medico = new Entity_Usuario_Medico()
            {
                Nome = "Dr Marcos Finistao",
                Dt_Nasci = DateTime.Today,
                Telefone_01 = "18990123945",
                Telefone_02 = "18990123945",
                Vinculo = "SUS",
                Endereco = "Jose Urbano Cursino",
                Codigo = "COD01",
                Especialidade = "Cardiologista"
            };

            var procedimento = new Entity_Procedimento()
            {
                Cid = "CCA",
                Descricao = "TESTE TESTE",
                Data_Agendado = DateTime.Today,
                Id_Medico = usuario_medico,
                Id_Paciente = usuario
            };

            Assert.AreEqual(procedimento.Cid, "CCA");
            Assert.AreEqual(procedimento.Data_Agendado, DateTime.Today);
            Assert.AreEqual(procedimento.Descricao, "TESTE TESTE");
            Assert.AreEqual(procedimento.Id_Medico, usuario_medico);
            Assert.AreEqual(procedimento.Id_Paciente, usuario);



        }

        [TestMethod]
        public void Teste_Entity_Agenda()
        {
            var usuario_medico = new Entity_Usuario_Medico()
            {
                Nome = "Dr Marcos Finistao",
                Dt_Nasci = DateTime.Today,
                Telefone_01 = "18990123945",
                Telefone_02 = "18990123945",
                Vinculo = "SUS",
                Endereco = "Jose Urbano Cursino",
                Codigo = "COD01",
                Especialidade = "Cardiologista"
            };
            var Agenda = new Entity_Agenda() {
                DataAgenda = DateTime.Today,
                IdMedico = usuario_medico,
                Vagas = 20,
                Vaga_Agendados = 10,
                Nome = "XYZ"
        };

            Assert.AreEqual(Agenda.IdMedico, usuario_medico);
            Assert.AreEqual(Agenda.DataAgenda, DateTime.Today);
            Assert.AreEqual(Agenda.DataAgenda, DateTime.Today);
            Assert.AreEqual(Agenda.Vagas,20);
            Assert.AreEqual(Agenda.Vaga_Agendados,10);
            Assert.AreEqual(Agenda.Nome, "XYZ");


        }


        [TestMethod]
        public void Teste_Entity_Consulta() {
            var usuario = new Entity_Usuario()
            {
                Nome = "Lucas Finistao",
                Dt_Nasci = DateTime.Today,
                Telefone_01 = "18990123945",
                Telefone_02 = "18990123945",
                Vinculo = "SUS",
                Endereco = "Jose Urbano Cursino"

            };
            var usuario_medico = new Entity_Usuario_Medico()
            {
                Nome = "Dr Marcos Finistao",
                Dt_Nasci = DateTime.Today,
                Telefone_01 = "18990123945",
                Telefone_02 = "18990123945",
                Vinculo = "SUS",
                Endereco = "Jose Urbano Cursino",
                Codigo = "COD01",
                Especialidade = "Cardiologista"
            };
            var Agendas = new Entity_Agenda()
            {
                DataAgenda = DateTime.Today,
                IdMedico = usuario_medico,
                Vagas = 20,
                Vaga_Agendados = 10,
                Nome = "XYZ"
            };

            var consulta = new Entity_Consulta()
            {
                Agenda = Agendas,
                Ativa = true,
                Realizada = false,
                Paciente = usuario
            };

            Assert.AreEqual(consulta.Agenda, Agendas);
            Assert.AreEqual(consulta.Ativa, true);
            Assert.AreEqual(consulta.Realizada, false);
            Assert.AreEqual(consulta.Paciente, usuario);

        }
    }
}
