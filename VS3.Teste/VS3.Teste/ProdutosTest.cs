using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;

namespace VS3_Teste
{
    [TestClass]
    public class ProdutosTest
    {
        [TestMethod]
        public void TestarObterProdutos_AD()
        {            
            Assert.AreEqual(NumeroRegistros(VS3_AD.Produtos_AD.ObterProdutos_AD()), 3);
        }

        [TestMethod]
        public void TestarObterProdutos_NG()
        {
            Assert.AreEqual(NumeroRegistros(VS3_NG.Produtos_NG.ObterProdutos_NG()), 3);
        }

        [TestMethod]
        public void TestarNomeObterProdutos_NG()
        {
            Assert.AreEqual(NomeProdutos(VS3_NG.Produtos_NG.ObterProdutos_NG(), 1), "Teclado");
            Assert.AreEqual(NomeProdutos(VS3_NG.Produtos_NG.ObterProdutos_NG(), 2), "Mouse");
            Assert.AreEqual(NomeProdutos(VS3_NG.Produtos_NG.ObterProdutos_NG(), 3), "Monitor");
            Assert.AreEqual(NomeProdutos(VS3_NG.Produtos_NG.ObterProdutos_NG(), 4), "");
        }

        private Int32 NumeroRegistros(DataTable dataTable)
        {
            return dataTable.Rows.Count;
        }

        private String NomeProdutos(DataTable dataTable, Int32 ID_Produtos)
        {
            foreach (DataRow item in dataTable.Rows)
            {
                if (Convert.ToInt32(item["id"]) == ID_Produtos)
                {
                    return item["Nome"].ToString();
                }
            }
            return "";
        }
    }
}
