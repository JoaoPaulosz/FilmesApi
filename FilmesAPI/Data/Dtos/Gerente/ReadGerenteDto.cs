using FilmesAPI.Models;
using System.Collections.Generic;

namespace FilmesAPI.Data.Dtos
{
    public class ReadGerenteDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual object Cinemas { get; set; }
    }
}
