using AutoMapper;
using FilmesAPI.Data.Dtos.Endereco;
using FilmesAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace FilmesAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EnderecoController : ControllerBase
    {
        private Data.AppContext _context;
        private IMapper _mapper;

        public EnderecoController(Data.AppContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult AdicionarEndereco([FromBody] CreateEnderecoDto enderDto)
        {
            Endereco endereco = _mapper.Map<Endereco>(enderDto);
            _context.Endereco.Add(endereco);
            _context.SaveChanges();
            return CreatedAtAction(nameof(RecuperarEnderById), new {Id = endereco.Id}, endereco);
        }

        [HttpGet("{id}")]
        public IActionResult RecuperarEnderById(int id)
        {
            Endereco endereco = _context.Endereco.FirstOrDefault(ender => ender.Id == id);
            if (endereco != null)
            {
                ReadEnderecoDto enderDto = _mapper.Map<ReadEnderecoDto>(endereco);
                return Ok(enderDto);
            }
            return NotFound();
        }

        [HttpGet]
        public IEnumerable<Endereco> RecperaEnderAll() 
        {
            return _context.Endereco;
        }

        [HttpPut("{id}")]
        public IActionResult AtualizaEnder(int id, UpdateEnderecoDto updEnderDto)
        {
            Endereco endereco = _context.Endereco.FirstOrDefault(ender => ender.Id == id);
            if (endereco == null)
            {
                return NotFound();
            }
            _mapper.Map(updEnderDto, endereco);
            _context.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeletaEnder(int id)
        {
            Endereco endreco = _context.Endereco.FirstOrDefault(ender => ender.Id == id);
            if(endreco == null)
            {
                return NotFound();
            }
            _context.Remove(endreco);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
