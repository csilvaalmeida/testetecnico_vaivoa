using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace creditcardapi.Models
{
    public class Cartao
    {
        [Key]
        public int id { get; set; }
        
        public int numero { get; set; }

        
        [ForeignKey("clienteId")]
        public Cliente cliente  { get; set; }

    }
}