using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VS3_NG
{
    public static class Produtos_NG
    {
        public static DataTable ObterProdutos_NG()
        {
            return VS3_AD.Produtos_AD.ObterProdutos_AD();
        }
    }
}
