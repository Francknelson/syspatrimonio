using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SysPatrimonio.Models
{
    [Table("patrimonio", Schema = "public")]
    public class DbPatrimonio
    {
        [Key]
        public int id { get; set; }
        public string numetiqueta { get; set; }
        public string nomepatrimonio { get; set; }
        public string descricaopatrimonio { get; set; }
        public string valorpatrimonio { get; set; }
        public string marcamodelo { get; set; }
        public DateTime dataaquisicao { get; set; }
        public DateTime databaixa { get; set; }
        public int numnf { get; set; }
        public string numserie { get; set; }
        public string situacao { get; set; }
    }
}
