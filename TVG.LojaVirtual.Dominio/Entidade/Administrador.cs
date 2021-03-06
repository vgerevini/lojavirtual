﻿using System;
using System.ComponentModel.DataAnnotations;

namespace TVG.LojaVirtual.Dominio.Entidade
{
    public class Administrador
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Digite o login.")]
        [Display(Name = "Login:")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Digite a senha.")]
        [DataType(dataType: DataType.Password)]
        public string Senha { get; set; }

        public DateTime UltimoAcesso { get; set; }
    }
}
