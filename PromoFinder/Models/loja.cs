using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PromoFinder.Models
{
    public partial class loja
    {
        [Key]
        public int loja_id { get; set; }

        [Required]
        [Display(Name = "Nome")]
        public string nome { get; set; }
        public string logo { get; set; }
        public string avaliacao { get; set; }

        [Required]
        [Display(Name = "Rua")]
        public string rua { get; set; }

        [Required]
        [Display(Name = "Numero")]
        public string numero { get; set; }

        [Required]
        [Display(Name = "Complemento")]
        public string complemento { get; set; }

        [Required]
        [Display(Name = "Cidade")]
        public string cidade { get; set; }

        [Required]
        [Display(Name = "Estado")]
        public string estado { get; set; }

        [Required]
        [Display(Name = "Telefone")]
        public string telefone { get; set; }

        [Required]
        [Display(Name = "Email")]
        [EmailAddress]
        public string email { get; set; }

        public DateTime datacadastro { get; set; }
    }
}
