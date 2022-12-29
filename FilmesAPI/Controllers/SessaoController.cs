using AutoMapper;
using FilmesAPI.Data;
using FilmesAPI.Models;
using FilmesAPI.Data.Dtos;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace FilmesAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SessaoController : ControllerBase
    {
        private IMapper _mapper;
        private AppContext _context;
        public SessaoController(IMapper mapper, AppContext context)        {
            _mapper = mapper;
            _context = context;
        }
        [HttpPost]
        public IActionResult AdicionaSessao(CreateSessaoDto createSessaoDto)
        {
            Sessao sessao = _mapper.Map<Sessao>(createSessaoDto);
            _context.Sessoes.Add(sessao);
            _context.SaveChanges();
            return CreatedAtAction(nameof(RecuperaSessaoPorId), new {Id = sessao.Id}, sessao);

        }

        [HttpGet("{id}")]
        public IActionResult RecuperaSessaoPorId(int id)
        {
            Sessao sessao = _context.Sessoes.FirstOrDefault(sess => sess.Id == id);
            if(sessao != null)
            {
                ReadSessaoDto readSessaoDto = _mapper.Map<ReadSessaoDto>(sessao);
                return Ok(readSessaoDto);
            }
            return NotFound();
        }

    }
}
