using Microsoft.VisualBasic;
using System;
using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.Dtos.Filmes
{
    public class ReadFilmeDto
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo Titulo é obrigatório")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "O campo Diretor é obrigatório")]
        public string Diretor { get; set; }
        public string Genero { get; set; }
        [Range(60, 195, ErrorMessage = "A duração deve ter no mínimo 60 e no máximo 195 minutos")]
        public int Duracao { get; set; }
        public DateTime HoraDaConsulta { get; set; }
    }
}
