using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.Dtos;

public class CreateFilmeDto
{
    [Required(ErrorMessage = "O titulo do filme é obrigatório")]
    public string Titulo { get; set; }

    [Required(ErrorMessage = "O genêro do filme é obrigatório")]
    [StringLength(50, ErrorMessage = "O tamanho do campo genêro não pode ser maior do que 50 caracteres")]
    public string Genero { get; set; }

    [Required]
    [Range(60, 600, ErrorMessage = "A duração deve ser entre 60 a 600 minutos")]
    public int Duracao { get; set; }
}

