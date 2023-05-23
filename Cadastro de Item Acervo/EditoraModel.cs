using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_de_Item_Acervo
{
    [Table("mvtBibEditora")]
    public class EditoraModel
    {
        [Key()]
        public string codEditora { get; set; }
        public string nomeEditora { get; set; }

    }
}
