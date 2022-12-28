using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ef.Models{

    [Table("Categoria")]

    public class Categoria{

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


        [Required] //náo pode receber valor nulo
        [MinLength(3)] // tamanho min de caractere
        [MaxLength(80)]// tamanho max de caractere
        [Column("Nome", TypeName ="NVARCHAR")] // que aceita com caracteres
        public string Nome { get; set; }


        [Required] //náo pode receber valor nulo
        [MinLength(3)] // tamanho min de caractere
        [MaxLength(80)]// tamanho max de caractere
        [Column("Slug", TypeName ="VARCHAR")] // que aceita com caracteres
        public string Slug { get; set; }
    }
}