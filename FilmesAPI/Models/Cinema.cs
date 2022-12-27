﻿using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Models
{
    public class Cinema
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage ="O campo de Nome é Obrigatorio")]
        public string Nome { get; set; }
        public int EnderecoFK { get; set; }
        public int GerenteFK { get; set; }

    }
}