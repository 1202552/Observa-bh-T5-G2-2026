using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Observa_bh_T5_G2_2026.Models
{
    [Table("Perfil")]
    public class Perfil
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo Email é obrigatório.")]
        public string email { get; set; }

        [Required(ErrorMessage = "O campo Telefone é obrigatório.")]
        public string Telefone { get; set; }

        public string Cidade { get; set; }

        public string Estado { get; set; }

        public string Foto { get; set; }



    }
}
