using ExamenFinal.Controllers;
using ExamenFinal.Models;
using ExamenFinal.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace ExamenFinal.Tests.Controllers
{
    public class NotaControllerTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void FailCompartirUnaVezTest()
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
            var resultado = notaController.Compartir(1, 1);

            Assert.IsInstanceOf<ViewResult>(resultado);
        }

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
            var redirect = (RedirectToActionResult)resultado;
            Assert.AreEqual(redirect.ActionName.ToLower(), "index");
        }

        [Test]
        public void CrearNotaTest()
        {
            var userRepository = new Mock<IUserRepository>();
            var notaRepository = new Mock<INotaRepository>();
            var tagRepostory = new Mock<ITagRepository>();
            userRepository.Setup(x => x.FindByUsername(It.IsAny<string>())).Returns(new Usuario());
            notaRepository.Setup(x => x.Create(It.IsAny<NotaDatos>()));
            var notaController = new NotaController(notaRepository.Object, userRepository.Object, tagRepostory.Object);
            var resultado = notaController.Crear(new NotaDatos());
            notaRepository.Verify(x => x.Create(It.IsAny<NotaDatos>()), Times.Once);
            Assert.IsInstanceOf<RedirectToActionResult>(resultado);
            var redirect = (RedirectToActionResult)resultado;
            Assert.AreEqual(redirect.ActionName.ToLower(), "index");
        }

        [Test]
        public void EditarNotaTest()
        {
            var userRepository = new Mock<IUserRepository>();
            var notaRepository = new Mock<INotaRepository>();
            var tagRepostory = new Mock<ITagRepository>();
            userRepository.Setup(x => x.FindByUsername(It.IsAny<string>())).Returns(new Usuario());
            notaRepository.Setup(x => x.Modificar(It.IsAny<NotaDatos>()));
            var notaController = new NotaController(notaRepository.Object, userRepository.Object, tagRepostory.Object);
            var resultado = notaController.Editar(new NotaDatos());
            notaRepository.Verify(x => x.Modificar(It.IsAny<NotaDatos>()), Times.Once);
            Assert.IsInstanceOf<RedirectToActionResult>(resultado);
            var redirect = (RedirectToActionResult)resultado;
            Assert.AreEqual(redirect.ActionName.ToLower(), "index");
        }


        [Test]
        public void EliminarNotaTest()
        {
            var userRepository = new Mock<IUserRepository>();
            var notaRepository = new Mock<INotaRepository>();
            var tagRepostory = new Mock<ITagRepository>();
            userRepository.Setup(x => x.FindByUsername(It.IsAny<string>())).Returns(new Usuario());
            notaRepository.Setup(x => x.Eliminar(It.IsAny<int>()));
            var notaController = new NotaController(notaRepository.Object, userRepository.Object, tagRepostory.Object);
            var resultado = notaController.Eliminar(1);
            notaRepository.Verify(x => x.Eliminar(It.IsAny<int>()), Times.Once);
            Assert.IsInstanceOf<RedirectToActionResult>(resultado);
            var redirect = (RedirectToActionResult)resultado;
            Assert.AreEqual(redirect.ActionName.ToLower(), "index");

        }

        [Test]
        public void IndexNotaTest()
        {
            var userRepository = new Mock<IUserRepository>();
            var notaRepository = new Mock<INotaRepository>();
            var tagRepostory = new Mock<ITagRepository>();
            userRepository.Setup(x => x.FindByUsername(It.IsAny<string>())).Returns(new Usuario { Id = 1 });
            notaRepository.Setup(x => x.NotasDeUsuario(It.IsAny<int>())).Returns(new List<Nota>
            {
                new Nota
                {
                    IdUsuario = 1
                }
            });
            var notaController = new NotaController(notaRepository.Object, userRepository.Object, tagRepostory.Object);
            var resultado = notaController.Index(new NotaIndex());
            Assert.IsInstanceOf<ViewResult>(resultado);
            var redirect = (ViewResult)resultado;
            Assert.IsInstanceOf<NotaIndex>(redirect.Model);
        }
        [Test]
        public void IndexNotaByTagTest()
        {
            var userRepository = new Mock<IUserRepository>();
            var notaRepository = new Mock<INotaRepository>();
            var tagRepostory = new Mock<ITagRepository>();
            userRepository.Setup(x => x.FindByUsername(It.IsAny<string>())).Returns(new Usuario { Id = 1 });
            notaRepository.Setup(x => x.NotasDeUsuario(It.IsAny<int>())).Returns(new List<Nota>
            {
                new Nota
                {
                    IdUsuario = 1,
                    Tags = new List<NotaTag>
                    {
                        new NotaTag
                        {
                            TagId = 1
                        }
                    }
                },
                new Nota
                {
                    IdUsuario = 1,
                    Tags = new List<NotaTag>
                    {
                        new NotaTag
                        {
                            TagId = 2
                        }
                    }
                }
            });
            var notaController = new NotaController(notaRepository.Object, userRepository.Object, tagRepostory.Object);
            var resultado = notaController.Index(new NotaIndex { TagId = 1 });
            Assert.IsInstanceOf<ViewResult>(resultado);
            var redirect = (ViewResult)resultado;
            Assert.IsInstanceOf<NotaIndex>(redirect.Model);
            var notasResultado = (NotaIndex)redirect.Model;
            Assert.AreEqual(notasResultado.Notas.Count, 1);
        }


    }
}
