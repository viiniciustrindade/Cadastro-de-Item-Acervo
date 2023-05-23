using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_de_Item_Acervo
{
    [Table("mvtBibLocal")]
    public class LocalModel
    {
        [Key()]

        public string codLocal { get; set; }
        public string nomeLocal { get; set; }
    }
}
