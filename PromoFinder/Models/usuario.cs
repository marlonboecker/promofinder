using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PromoFinder.Models
{
    public partial class usuario
    {
        [Key]
        public int usuario_id { get; set; }

        [Required]
        [Display(Name ="Nome")]
        public string nome { get; set; }

        [Required]
        [Display(Name = "Email")]
        [EmailAddress]
        public string email { get; set; }

        //gerar uma classe para isto depois que fizermos uma integração com correios
        public string cep { get; set; }
        public string rua { get; set; }
        public string numero { get; set; }
        public string complemento { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
        public DateTime datanascimento { get; set; }
        public DateTime datacadastro { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "A {0} deve conter pelo menos {2} caracteres.", MinimumLength = 6)]
        [Display(Name = "Senha")]
        [DataType(DataType.Password)]
        public string senha { get; set; }

        //Não sei que porra é isso
        public int status { get; set; }
    }
}
