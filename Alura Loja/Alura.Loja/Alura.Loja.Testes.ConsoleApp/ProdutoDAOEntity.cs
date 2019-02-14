using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Loja.Testes.ConsoleApp
{
    class ProdutoDAOEntity : IProdutoDAO, IDisposable
    {
        private LojaContext Context;
        public ProdutoDAOEntity()
        {
            this.Context = new LojaContext();
        }

        public void Adicionar(Produto p)
        {
            Context.Produtos.Add(p);
            Context.SaveChanges();
        }

        public void Atualizar(Produto p)
        {
            Context.Produtos.Update(p);
            Context.SaveChanges();
        }

        public void Dispose()
        {
            Context.Dispose();
        }

        public IList<Produto> Produtos()
        {
            return Context.Produtos.ToList();
        }

        public void Remover(Produto p)
        {
            Context.Produtos.Remove(p);
            Context.SaveChanges();
        }
    }
}
