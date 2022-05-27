using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SysPatrimonio.Models
{
    [Table("categoria", Schema = "public")]
    public class DbCategoria
    {
        [Key]
        public int id { get; set; }
        public string descricaocategoria { get; set; }
    }
}
