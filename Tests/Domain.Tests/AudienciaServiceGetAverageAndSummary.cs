using Domain.Interfaces;
using Domain.Services;
using Moq;
using System;
using System.Collections.Generic;
using Xunit;

namespace Domain.Tests
{
    public class AudienciaServiceGetAverageAndSummary
    {
        private AudienciaService _service;
        private Mock<IAudienciaRepository> _repo;
        
        public AudienciaServiceGetAverageAndSummary()
        {
            _repo = new Mock<IAudienciaRepository>();
            _service = new AudienciaService(_repo.Object);
        }

        [Fact]
        public void ShouldReturnAverage()
        {
            var dt = DateTime.Now;
            _repo.Setup(x => x.GetAverage(dt))
                .Returns(new List<CustomResponse.GroupAudiencia>());
            
            var result = _service.GetAverage(dt);

            Assert.NotNull(result);
            Assert.IsType<List<CustomResponse.GroupAudiencia>>(result);
        }

        [Fact]
        public void ShouldReturnSummary()
        {
            var dt = DateTime.Now;
            _repo.Setup(x => x.GetSummary(dt))
                .Returns(new List<CustomResponse.GroupAudiencia>());

            var result = _service.GetSummary(dt);

            Assert.NotNull(result);
            Assert.IsType<List<CustomResponse.GroupAudiencia>>(result);
        }
    }
}
