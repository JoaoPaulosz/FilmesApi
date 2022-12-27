using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace FilmesAPI.Data.Dtos.Endereco
{
    public class UpdateEnderecoDto
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Logradouro { get; set; }
        [Required]
        public string Bairro { get; set; }
        [DefaultValue(null)]
        public int Numero { get; set; }
    }
}
