using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PromoFinder.Models
{
    public partial class curtidas_promocoes
    {
        [Key]
        public int curpro_id { get; set; }
        public int promocao_id { get; set; }
        public int usuario_id { get; set; }
        public int status { get; set; }
    }
}
