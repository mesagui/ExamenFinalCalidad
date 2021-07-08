using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamenFinal.Controllers;
using ExamenFinal.Models;
using ExamenFinal.Repository;
using ExamenFinal.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Moq;
using NUnit.Framework;

namespace ExamenFinal.Tests.Controllers
{
    public class NotaControllerTest
    {
        [SetUp]
        public void Setup()
        {
        }

        //Compartimos nota
        [Test]
        public void SuccessCompartirUnaVezTest()
        {
            var notasUsuario = new List<NotaUsuario> { new NotaUsuario { NotaId = 1, UserId = 1 } }.AsQueryable();

            var userRepository = new Mock<IUserRepository>();
            userRepository.Setup(x => x.GetAll()).Returns(new List<Usuario>());
            var tagRepostory = new Mock<ITagRepository>();
            var dbsetMock = new Mock<DbSet<NotaUsuario>>();
            var context = new Mock<IFinalContext>();
            dbsetMock.As<IQueryable<NotaUsuario>>().Setup(m => m.Provider).Returns(notasUsuario.Provider);
            dbsetMock.As<IQueryable<NotaUsuario>>().Setup(m => m.Expression).Returns(notasUsuario.Expression);
            dbsetMock.As<IQueryable<NotaUsuario>>().Setup(m => m.ElementType).Returns(notasUsuario.ElementType);
            dbsetMock.As<IQueryable<NotaUsuario>>().Setup(m => m.GetEnumerator()).Returns(notasUsuario.GetEnumerator());
            context.Setup(o => o.NotaUsuario).Returns(dbsetMock.Object);
            context.Setup(o => o.Notas.Find(It.IsAny<int>())).Returns(new Nota());

            var repository = new NotaRepository(context.Object);

            var notaController = new NotaController(repository, userRepository.Object, tagRepostory.Object);
            var resultado = notaController.Compartir(1, 2);


            Assert.IsInstanceOf<RedirectToActionResult>(resultado);
        }


        [Test]
        public void FailCompartirUnaVezTest()
        {
            var notasUsuario = new List<NotaUsuario>{ new NotaUsuario{NotaId = 1, UserId = 1}}.AsQueryable();

            var userRepository = new Mock<IUserRepository>();
            userRepository.Setup(x => x.GetAll()).Returns(new List<Usuario>());
            var tagRepostory = new Mock<ITagRepository>();
            var dbsetMock = new Mock<DbSet<NotaUsuario>>();
            var context = new Mock<IFinalContext>();
            dbsetMock.As<IQueryable<NotaUsuario>>().Setup(m => m.Provider).Returns(notasUsuario.Provider);
            dbsetMock.As<IQueryable<NotaUsuario>>().Setup(m => m.Expression).Returns(notasUsuario.Expression);
            dbsetMock.As<IQueryable<NotaUsuario>>().Setup(m => m.ElementType).Returns(notasUsuario.ElementType);
            dbsetMock.As<IQueryable<NotaUsuario>>().Setup(m => m.GetEnumerator()).Returns(notasUsuario.GetEnumerator());
            context.Setup(o => o.NotaUsuario).Returns(dbsetMock.Object);
            context.Setup(o => o.Notas.Find(It.IsAny<int>())).Returns(new Nota());

            var repository = new NotaRepository(context.Object);

            var notaController = new NotaController(repository, userRepository.Object, tagRepostory.Object);
            var resultado = notaController.Compartir(1,1);

            Assert.IsInstanceOf<ViewResult>(resultado);
        }



        //

        [Test]
        public void SuccessRegistrarUsuarioTest()
        {
            var UsuarioRegistro = new List<Usuario> { new Usuario { Id = 1, UserName = "mike", Password = "admin" } }.AsQueryable();


            var userMock = new Mock<IUserRepository>();

            userMock.Setup(o => o.FindUser());

            var dbsetMock = new Mock<DbSet<NotaUsuario>>();
            var context = new Mock<IFinalContext>();



            Assert.IsInstanceOf<RedirectToActionResult>(resultado);
            //context.Verify(x => x.Notas.Add(It.IsAny<Nota>()), Times.Once());
        }




    }
}
