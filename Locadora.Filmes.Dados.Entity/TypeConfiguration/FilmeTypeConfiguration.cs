using Locadora.Filmes.Dominio;
using Locadora.Filmes.Generica.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Filmes.Dados.Entity.TypeConfiguration
{
    class FilmeTypeConfiguration : LocadoraEntityAbstractConfig<Filme>
    {
        protected override void ConfigurarCamposTabela()
        {
            Property(p => p.IdFilme)
                .IsRequired()
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)
                .HasColumnName("IdFilme");

            Property(p => p.NomeFilme)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("NomeFilme");

            Property(p => p.IdAlbum)
                .IsRequired()
                .HasColumnName("IdAlbum");

        }

        protected override void ConfigurarChaveEstrangeira()
        {
            HasRequired(f => f.Album)
            .WithMany(a => a.Filmes)
            .HasForeignKey(f => f.IdAlbum);

        }

        protected override void ConfigurarChavePrimaria()
        {
            HasKey(pk => pk.IdFilme);
        }

        protected override void ConfigurarNomeTabela()
        {
            ToTable("Filme");
        }
    }
}
