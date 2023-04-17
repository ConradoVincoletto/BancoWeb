using Microsoft.AspNetCore.Mvc.ApplicationModels;
using System.ComponentModel.DataAnnotations;

namespace BancoWeb.Models
{
    public class ContaCorrente
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O titular da conta é obrigatório")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Mínimo de 3 caracteres")]
        public string Titular { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Data de aniversário")]
        public DateTime Aniversario { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DisplayFormat(DataFormatString = "{0:F2")]
        public double Balanço { get; set; } = 0;
        public string Numero { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(6, MinimumLength = 3, ErrorMessage = "A senha deve conter no mínimo 3 a 6 caracteres.")]
        public string Senha { get; set; }

        public ContaCorrente()
        {
        }

        public ContaCorrente(int id, double balanço)
        {
            Id = id;
            Balanço = balanço;
        }
    }
}
