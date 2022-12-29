using FilmesAPI.Models;
using System;

namespace FilmesAPI.Data.Dtos
{
    public class ReadSessaoDto
    {
        public int Id { get; set; }
        public Filme Filme { get; set; }
        public Cinema Cinema { get; set; }
        public DateTime HorarioEncerramento { get; set; }
        public DateTime HorarioInico { get; set; }
    }
}
