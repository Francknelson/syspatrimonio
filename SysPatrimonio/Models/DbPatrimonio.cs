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
        public decimal valorpatrimonio { get; set; }
        public string marcamodelo { get; set; }
        public DateOnly dataaquisicao { get; set; }
        public DateOnly databaixa { get; set; }
        public int numnf { get; set; }
        public string numserie { get; set; }
        public string situacao { get; set; }
        public int idcategoria { get; set; }
        public int idlocal { get; set; }
        public int iddepartamento { get; set; }
        public int idfornecedor { get; set; }
    }
}
