using AutoMapper;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Presentation.Controllers;
using System;
using Xunit;

namespace Presentation.UnitTests
{
    public class AudienciaControllerGet
    {
        private AudienciaController _controller;
        private Mock<IAudienciaService> _service;
        private Mock<IMapper> _mapper;

        public AudienciaControllerGet(){
            _service = new Mock<IAudienciaService>();
            _mapper = new Mock<IMapper>();
            _controller = new AudienciaController(_service.Object, _mapper.Object);
        }


        [Fact]
        public void ShouldReturnSucessResponse()
        {
            var result = _controller.Get("soma", DateTime.Now);

            Assert.IsType<ObjectResult>(result);            
        }
    }
}
