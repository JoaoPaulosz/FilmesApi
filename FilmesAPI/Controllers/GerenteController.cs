using AutoMapper;
using FilmesAPI.Data;
using FilmesAPI.Data.Dtos;
using FilmesAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace FilmesAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GerenteController : ControllerBase
    {
        private IMapper _mapper;
        private AppContext _context;

        public GerenteController(IMapper mapper, AppContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        [HttpPost]
        public IActionResult AdicionaGerente(CreateGerenteDto createGerenteDto)
        {
            Gerente gerente = _mapper.Map<Gerente>(createGerenteDto);
            _context.Gerentes.Add(gerente);
            _context.SaveChanges();
            return CreatedAtAction(nameof(RecuperaGerentePorId), new {Id = gerente.Id}, gerente);

        }
        [HttpGet("{id}")]
        public IActionResult RecuperaGerentePorId(int id)
        {
            Gerente gerente = _context.Gerentes.FirstOrDefault(geren => geren.Id == id);
            if(gerente == null)
            {
                return NotFound();
            }
            ReadGerenteDto readGerenteDto = _mapper.Map<ReadGerenteDto>(gerente);
            return Ok(readGerenteDto);
        }
    }
}
