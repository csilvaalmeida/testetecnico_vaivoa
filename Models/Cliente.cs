using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace creditcardapi.Models
{
    public class Cliente
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "Email é Obrigatório")]
        public string email { get; set; }

        public virtual List<Cartao> cartoes { get; set; }

    }
}