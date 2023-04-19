using System.ComponentModel.DataAnnotations;

namespace BancoWeb.Models.ViewMoldes
{
    public class Login
    {
        [Required]
        public int Numero { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public int Senha { get; set; }


    }
}
