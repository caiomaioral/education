using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Sistema.Infantil.Models
{
    public partial class Usuario
    {
        public int ID_USUARIO { get; set; }
        public int ID_LICENSA { get; set; }
        public string NM_USUARIO { get; set; }

        [Required(ErrorMessage="Nome obrigatorio.")]
        public string NM_LOGIN { get; set; }
        
        [Required(ErrorMessage = "Senha obrigatoria.")]
        public string NM_SENHA { get; set; }
        public int INT_TIPO { get; set; }
    }
}
