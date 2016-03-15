using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PromoFinder.Models
{
    public partial class curtidas_lojas
    {
        [Key]
        public int curloj_id { get; set; }
        public int loja_id { get; set; }
        public int usuario_id { get; set; }
        public int status { get; set; }
    }
}
