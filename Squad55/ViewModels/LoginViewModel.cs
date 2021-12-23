using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Squad55.ViewModels
{
    public class LoginViewModel
    {
        public string UrlRetorno { get; set; }

        [Required(ErrorMessage = "Informe o Email")]
        [MaxLength(50, ErrorMessage = "O login deve ter ate 50 caracteres")]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress,ErrorMessage ="Email informado invalido")]
        [EmailAddress(ErrorMessage ="Email informado invalido")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Informe a senha")]
        [DataType(DataType.Password)]
        [MinLength(6, ErrorMessage = "A senha deve ter pelo menos 6 caracteres")]
        public string Senha { get; set; }
    }
}