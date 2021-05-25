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
    public class EmissoraController : Controller
    {
        private readonly IEmissoraService _service;
        private readonly IMapper _mapper;
        public EmissoraController(IEmissoraService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        // GET: api/<EmissoraController>
        [HttpGet]
        public IActionResult Get()
        {
            return new ObjectResult(_service.Get());
        }

        // POST api/<EmissoraController>
        [HttpPost]
        public IActionResult Post([FromBody] EmissoraInputModel emissoraInputModel)
        {
            try
            {
                Emissora emissora = _mapper.Map<EmissoraInputModel, Emissora>(emissoraInputModel);
                _service.Add(emissora);
                return new ObjectResult("Registro salvo com sucesso.");
            }
            catch(Exception ex)
            {
                return new ObjectResult(ex.Message);
            }
        }

        // PUT api/<EmissoraController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Emissora audiencia)
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

        // DELETE api/<EmissoraController>/5
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