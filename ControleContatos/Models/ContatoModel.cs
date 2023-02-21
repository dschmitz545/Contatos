using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ControleContatos.Models
{
    public class ContatoModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "O Nome é obrigatório.")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O E-mail é obrigatório.")]
        [EmailAddress(ErrorMessage = "O E-mail informado não é valido.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "O Celular é obrigatório.")]
        [Phone(ErrorMessage = "O Celular informado não é valido.")]
        public string Celular { get; set; }
    }
}