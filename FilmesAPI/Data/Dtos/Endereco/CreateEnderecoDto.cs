using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace FilmesAPI.Data.Dtos.Endereco
{
    public class CreateEnderecoDto
    {
        [Required]
        public string Logradouro { get; set; }
        [Required]
        public string Bairro { get; set; }
        [DefaultValue(null)]
        public int Numero { get; set; }
    }
}
