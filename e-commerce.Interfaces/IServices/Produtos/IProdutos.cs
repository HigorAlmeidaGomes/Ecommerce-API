using e_commerce.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_commerce.Interfaces.IServices.Produtos
{
    public interface IProdutos
    {
        Task<IEnumerable<Produto>> ObterCatalogoDeCerveja(string genero);

        Task<Produto> ObterCatalogoDeCervejaId(int id);
       
    }
}
