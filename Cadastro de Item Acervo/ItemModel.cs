using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_de_Item_Acervo
{
    [Table("mvtBibItemAcervo")]
    public class ItemModel
    {
        [Key()]
        public string codItem { get; set;}
        public string nomeItem { get; set; }
        public string volume { get; set; }
        public string numExemplar { get; set; }
        public string anoEdicao { get; set; }
        public string localizacao { get; set; }
        public string status { get; set; }
        public string tipoItem { get; set; }
        public string nomeColecao { get; set; }
        [ForeignKey("mvtBibAutor")]
        [Column("codAutor")]
        public string autorID { get; set; }
        public virtual AutorModel AutorModel { get; set; }

        [ForeignKey("mvtBibLocal")]
        [Column("codLocal")]
        public string localId { get; set; }
        public virtual LocalModel LocalModel { get; set; }

        [ForeignKey("mvtBibEditora")]
        [Column("codEditora")]
        public string editoraID { get; set; }
        public virtual EditoraModel EditoraModel { get; set; }

        [ForeignKey("mvtBibSecao")]
        [Column("codSecao")]
        public string secaoId { get; set; }
        public virtual SecaoModel SecaoModel { get; set; }

    }
}
