using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_commerce.Domain.Model
{
    public class Venda
    {
        [Column("CUS_ID")]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Display(Name = "Produto")]
        [ForeignKey("TB_PRODUTO")]
        [Column(Order = 1)]
        public int IdProduto { get; set; }
        public virtual Produto Produtos { get; set; }

        [Column("CUS_ESTADO")]
        [Display(Name = "Estado")]
        public EnumEstadoCompra Estado { get; set; }

        [Column("CSU_QTD")]
        [Display(Name = "Quantidade")]
        public int QtdCompra { get; set; }

        [NotMapped]
        [Display(Name = "Quantidade Total")]
        public int QuantidadeProdutos { get; set; }

        [NotMapped]
        [Display(Name = "Valor Total")]
        public decimal ValorTotal { get; set; }

        [NotMapped]
        [Display(Name = "Endereço de entrega")]
        public string EnderecoCompleto { get; set; }

        [NotMapped]
        public List<Produto> ListaProdutos { get; set; }
    }
}
