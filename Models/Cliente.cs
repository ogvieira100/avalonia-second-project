using System.ComponentModel.DataAnnotations;

namespace customer.Models;    // Projeto WebAPI

public class Cliente
{
    public int Id { get; set; }

    [Required(ErrorMessage = "O Nome é obrigatório.")]
    [StringLength(100, ErrorMessage = "O Nome deve ter no máximo 100 caracteres.")]
    public required string Nome { get; set; }

    [Required(ErrorMessage = "O Email é obrigatório.")]
    [EmailAddress(ErrorMessage = "O Email é inválido.")]
    public required string Email { get; set; }

    [Phone(ErrorMessage = "O Telefone é inválido.")]
    public  string? Telefone { get; set; }
  
}