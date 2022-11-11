using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;

namespace ControleDeEstoque.Models
{
    public class LoginViewModel
    {
        [Display(Name="Usuário")]
        public string Usuario { get; set; }

        [Display(Name = "Senha")]
        public string Senha { get; set; }

        [Display(Name = "Lembrar-me")]
        public bool LembrarMe { get; set; } 

    }
}