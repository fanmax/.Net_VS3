using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VS3_Web
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLerProdutos_Click(object sender, EventArgs e)//Chamar no VS3_NG os dados do Produtos em DataTable
        {
            DataTable dt = VS3_NG.Produtos_NG.ObterProdutos_NG();
            gvwProdutos.DataSource = dt; //Passa para o Grid o Data Table recebido de Produtos_NG
            gvwProdutos.DataBind();


        }
    }
}