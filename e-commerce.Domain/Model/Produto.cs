using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace e_commerce.Domain.Model
{
    [Table("TB_PRODUTO")]
    public class Produto
    {
        [Column("PRD_ID")]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Column("PRD_NOME")]
        [Display(Name = "Nome")]
        [MaxLength(255)]
        public string Nome { get; set; }

        [Column("PRD_DESCRICAO")]
        [Display(Name = "Descrição")]
        [MaxLength(150)]
        public string Descricao { get; set; }

        [Column("PRD_OBSERVACAO")]
        [Display(Name = "Observação")]
        [MaxLength(20000)]
        public string Observacao { get; set; }

        [Column("PRD_VALOR")]
        [Display(Name = "Valor")]
        public decimal Valor { get; set; }

        [Column("PRD_QTD_ESTOQUE")]
        [Display(Name = "Quantidade Estoque")]
        public int QtdEstoque { get; set; }
    }
}
