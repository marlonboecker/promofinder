using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PromoFinder.Models
{
    public partial class promoco
    {
        [Key]
        public int promocao_id { get; set; }

        public int loja_id { get; set; }

        [Required]
        [Display(Name = "Descrição")]
        [StringLength(100, ErrorMessage = "a {0} deve conter pelo menos {2} caracteres.", MinimumLength = 10)]
        public string descricao { get; set; }

        public System.DateTime datacadastro { get; set; }
        public System.DateTime datavalidade { get; set; }
        public int status { get; set; }
        public int visualizacoes { get; set; }
    }
}
