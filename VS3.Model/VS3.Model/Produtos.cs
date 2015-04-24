using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VS3_.Model
{
    [System.ComponentModel.DataObject(true)]
    class Produtos
    {
        public System.Int32 id { get; set; }
        public System.String nome { get; set; }
        public System.Double qtd { get; set; }
        public System.Double valor { get; set; }
    }
}
