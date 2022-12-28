using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ef.Models{

    //Mapeamento
    [Table("Usuario")]
    public class Usuario{


        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string  Email { get; set; }
        public string  SenhaHash { get; set; }
        public string Bio { get; set; }
        public string  Image { get; set; }
        public string Slug { get; set; }
    }
}