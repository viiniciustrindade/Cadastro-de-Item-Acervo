using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro_de_Item_Acervo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        public void AbrirSegundoFormulario()
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();

            txtNomeAutor.Text = form2.ValorEnviado;

        }




        private void btn_Salvar_Click(object sender, EventArgs e)
        {

        }

        private void btnCarregarAutor_Click(object sender, EventArgs e)
        {
            AbrirSegundoFormulario();
        }

        private void Form1_Load(object sender, EventArgs e)
        {











        }
    }
}
