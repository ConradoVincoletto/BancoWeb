using System.ComponentModel.DataAnnotations;

namespace BancoWeb.Models.ViewMoldes
{
    public class SaqueFormulario
    {
        public SalvarTransacao Transacao { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public int Senha { get; set; }
    }
}
