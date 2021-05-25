using Application.InputModels;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AudienciaController : Controller
    {
        private readonly IAudienciaService _service;
        private readonly IMapper _mapper;
        public AudienciaController(IAudienciaService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        // GET: api/<AudienciaController>
        [HttpGet]
        public IActionResult Get()
        {
            return new ObjectResult(_service.Get());
        }

        // GET api/<AudienciaController>/media
        /// <summary>
        /// AudienciaController Get: Obtém a média ou somatório da audiência por emissora
        /// </summary>
        /// <param name="visao">Opções de visão: 'media' ou 'somatorio'</param>
        /// <param name="dtAudiencia"></param>
        /// <returns></returns>
        [HttpGet("{visao}")]
        public IActionResult Get(string visao, [FromQuery]DateTime dtAudiencia)
        {
            if(visao.ToLower().Equals("media"))
                return new ObjectResult(_service.GetAverage(dtAudiencia));
            
            if(visao.ToLower().Equals("somatorio") || visao.ToLower().Equals("total"))
                return new ObjectResult(_service.GetSummary(dtAudiencia));
            
            return new ObjectResult("Visão não disponível!");
        }

        // POST api/<AudienciaController>
        [HttpPost]
        public IActionResult Post([FromBody] AudienciaInputModel audienciaInputModel)
        {
            try
            {
                Audiencia audiencia = _mapper.Map<AudienciaInputModel, Audiencia>(audienciaInputModel);
                _service.Add(audiencia);
                return new ObjectResult("Registro salvo gravado com sucesso.");
            }
            catch(Exception ex)
            {
                return new ObjectResult(ex.Message);
            }
        }

        // PUT api/<AudienciaController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Audiencia audiencia)
        {
            try
            {
                _service.Update(audiencia);
                return new ObjectResult("Registro atualizado com sucesso.");
            }
            catch (Exception ex)
            {
                return new ObjectResult(ex.Message);
            }
        }

        // DELETE api/<AudienciaController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                _service.Remove(id);
                return new ObjectResult("Registro removido com sucesso.");
            }
            catch (Exception ex)
            {
                return new ObjectResult(ex.Message);
            }
        }
    }
}