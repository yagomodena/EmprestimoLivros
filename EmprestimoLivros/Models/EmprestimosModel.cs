﻿using System.ComponentModel.DataAnnotations;

namespace EmprestimoLivros.Models
{
    //Classe dentro do Models referência a uma coluna no banco de dados 
    public class EmprestimosModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Digite o nome do Recebedor!")]
        public string Recebedor { get; set; }

        [Required(ErrorMessage = "Digite o nome do Fornecedor!")]
        public string Fornecedor { get; set; }

        [Required(ErrorMessage = "Digite o nome do Livro!")]
        public string LivroEmprestado { get; set; }

        public DateTime dataUltimaAtualizacao { get; set; } = DateTime.Now;
    }
}
