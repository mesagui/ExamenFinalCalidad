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
using Microsoft.Extensions.Configuration;
using Moq;
using NUnit.Framework;

namespace ExamenFinal.Tests.Controllers
{
    public class UserControllerTest
    {
        [SetUp]
        public void Setup()
        {
        }


        [Test]
        public void SuccessUsuarioLoginTest()
        {
            var repositoryMock = new Mock<IUserRepository>();
            repositoryMock.Setup(o => o.FindUser("admin", It.IsAny<String>())).Returns(new Usuario { });

            var authMock = new Mock<ICookieAuthService>();

            var congifMock = new Mock<IConfiguration>();
            congifMock.Setup(c => c.GetSection(It.IsAny<String>())).Returns(new Mock<IConfigurationSection>().Object);

            var controller = new UserController(repositoryMock.Object, authMock.Object, congifMock.Object);
            var result = controller.Login("admin", "admin");

            Assert.IsInstanceOf<RedirectToActionResult>(result);

        }


        [Test]
        public void FailUsuarioLoginTest()
        {
            var repositoryMock = new Mock<IUserRepository>();
            repositoryMock.Setup(o => o.FindUser("admin", It.IsAny<String>())).Returns(new Usuario { });

            var authMock = new Mock<ICookieAuthService>();

            var congifMock = new Mock<IConfiguration>();
            congifMock.Setup(c => c.GetSection(It.IsAny<String>())).Returns(new Mock<IConfigurationSection>().Object);

            var controller = new UserController(repositoryMock.Object, authMock.Object, congifMock.Object);
            var result = controller.Login("admin333", "asdasd");

            Assert.IsInstanceOf<ViewResult>(result);

        }



    }
}
