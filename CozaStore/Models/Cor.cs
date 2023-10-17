using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CozaStore.Models;

    [Table("Cor")]
    public class Cor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte Id { get; set; }

        [Required(ErrorMessage = "Informe o nome")]
        [StringLength(30, ErrorMessage = "O Nome deve possuir no máximo 30 caracteres")]
        public string Nome { get; set; }
        
        [Display(Name = "Codigo da Cor")]
        [Required(ErrorMessage = "Informe o Código da Cor")]
        [StringLength(7, ErrorMessage = "O Código da cor deve possuir no máximo 7 caracteres")]
        public string CodigoHexa { get; set; }
    }
