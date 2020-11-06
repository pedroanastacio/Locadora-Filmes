using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Locadora.Filmes.Web.ViewModels.Filme
{
    public class FilmeIndexViewModel
    {
        public int IdFilme { get; set; }

        [Display(Name = "Nome do filme")]
        public string NomeFilme { get; set; }

        [Display(Name = "Nome do álbum")]
        public string NomeAlbum { get; set; }
    }
}