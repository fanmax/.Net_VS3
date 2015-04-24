using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VS3_AD
{
    public static class Produtos_AD
    {
        public static DataTable ObterProdutos_AD()
        {
            DataTable dt = new DataTable();
            DataColumn col1 = new DataColumn("id");
            DataColumn col2 = new DataColumn("nome");
            DataColumn col3 = new DataColumn("qtd");
            DataColumn col4 = new DataColumn("valor");

            col1.DataType = System.Type.GetType("System.Int32");
            col2.DataType = System.Type.GetType("System.String");
            col3.DataType = System.Type.GetType("System.Double");
            col4.DataType = System.Type.GetType("System.Double");

            dt.Columns.Add(col1);
            dt.Columns.Add(col2);
            dt.Columns.Add(col3);
            dt.Columns.Add(col4);

            DataRow row = dt.NewRow();
            row[col1] = 1;
            row[col2] = "Teclado";
            row[col3] = 10;
            row[col4] = 80.50;
            dt.Rows.Add(row);

            row = dt.NewRow();
            row[col1] = 2;
            row[col2] = "Mouse";
            row[col3] = 3;
            row[col4] = 5.80;
            dt.Rows.Add(row);

            row = dt.NewRow();
            row[col1] = 3;
            row[col2] = "Monitor";
            row[col3] = 8;
            row[col4] = 312.99;
            dt.Rows.Add(row);

            return dt;
        }

    }
}
