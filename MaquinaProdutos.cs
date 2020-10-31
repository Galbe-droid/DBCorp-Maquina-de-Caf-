using System.Globalization;

namespace DBCorp___Maquian_de_Cafe_Virtual
{
    class MaquinaProdutos
    {
        public int ProdutoID { get; private set; }
        public string ProdutoNome { get; private set; }
        public double Preco { get; private set; }

        public MaquinaProdutos(int produtoId, string produtoNome, double preco)
        {
            ProdutoID = produtoId;
            ProdutoNome = produtoNome;
            Preco = preco;
        }

        public override string ToString()
        {
            return "{ " + this.ProdutoID + " / " + this.ProdutoNome + " / R$: " + this.Preco.ToString("F2", CultureInfo.InvariantCulture) + " }";
        }
    }
}
