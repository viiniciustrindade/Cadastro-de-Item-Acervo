using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_de_Item_Acervo
{
    [Table("mvtBibAutor")]
    public class AutorModel
    {
        [Key()]
        public int codAutor { get; set; }

        public string nomeAutor { get; set; }

    }
}
