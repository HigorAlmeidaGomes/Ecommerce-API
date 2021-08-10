using e_commerce.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_commerce.Interfaces.IServices.Compras
{
   public interface IVendas
    {
        Task<IEnumerable<Venda>> ObterVendasPorData(DateTime dataInicial, DateTime? dataFinal);

        Task<Venda> ObterVendasId(int id);
    }
}
