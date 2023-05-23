using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_de_Item_Acervo
{
    [Table("mvtBibSecao")]
    public class SecaoModel
    {
        [Key()]
        public string codSecao { get; set; }
        public string descSecao { get; set; }
    }
}
