using System.ComponentModel.DataAnnotations;

namespace BancoWeb.Models
{
    public class SalvarTransacao
    {
        public string Id { get; set; }

        public DateTime Instante { get; set; }

        [DisplayFormat(DataFormatString = "{0:F2")]
        [Range(1, 10000, ErrorMessage ="O depósito tem que estar entre os valores de 1 a 10000")]
        public double Quantia { get; set; }

        public int QuantiaId { get; set; }

        public TipoTransacao tipoTransacao { get; set; }

        public SalvarTransacao()
        {
        }
    }
}
