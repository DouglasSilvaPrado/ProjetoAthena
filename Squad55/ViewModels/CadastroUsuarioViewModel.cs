using System;
using System.ComponentModel.DataAnnotations;


namespace Squad55.ViewModels
{
    public class CadastroUsuarioViewModel
    {
        
        [Required(ErrorMessage = "Informe seu nome")]
        [MaxLength(100, ErrorMessage = "O nome deve ter ate 100 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe seu Email")]
        [Display(Name ="E-mail")]
        [MaxLength(50, ErrorMessage = "O email deve ter ate 50 caracteres")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Email informado invalido")]
        [EmailAddress(ErrorMessage = "Email informado invalido")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Informe sua data de nascimento")] 
        [Display(Name = "Data de nascimento")]
        [DataType(DataType.Date)]
        public DateTime Nascimento { get; set; }

        [Required(ErrorMessage = "Informe sua senha")]
        [DataType(DataType.Password)]
        [MinLength(6, ErrorMessage = "A senha deve ter pelo menos 6 caracteres")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Confirme sua senha")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirmar senha")]
        [MinLength(6, ErrorMessage = "A senha deve ter pelo menos 6 caracteres")]
        [Compare(nameof(Senha), ErrorMessage = "A senha e a confirmacao nao estao iguais")]
        public string ConfirmacaoSenha { get; set; }
    }
}