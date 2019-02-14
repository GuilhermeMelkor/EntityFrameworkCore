using System.Collections;
using System.Collections.Generic;

namespace Alura.Loja.Testes.ConsoleApp
{
    public class Produto
    {
        public int Id { get; internal set; }
        public string Nome { get; internal set; }
        public string Categoria { get; internal set; }
        public double PrecoUnitario { get; internal set; }
        public string Unidade { get; set; }
        public IList<PromocaoProduto> Promocoes { get; set; }

        //Sobrescrita do metodo ToString() e return com interpolação de string(disponivel a partir do C# 6)
        public override string ToString() => $"Produto: {this.Id}, {this.Nome}, {this.Categoria},{this.PrecoUnitario}";
    }
}