using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Locadora.Filmes.Web.ViewModels.Filme
{
    public class FilmeViewModel
    {
        [Required(ErrorMessage = "O IdFilme é obrigatório")]
        public int IdFilme { get; set; }

        [Required(ErrorMessage = "O nome do filme é obrigatório")]
        [MaxLength(100, ErrorMessage = "O nome do filme deve ter no máximo 100 caracteres")]
        [Display(Name = "Nome do filme")]
        public string NomeFilme { get; set; }

        [Required(ErrorMessage = "Selecione um álbum")]
        [Display(Name = "Nome do álbum")]
        public int IdAlbum { get; set; }
    }
}