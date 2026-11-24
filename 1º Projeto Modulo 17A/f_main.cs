using _1º_Projeto_Modulo_17A.Livros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1º_Projeto_Modulo_17A
{
    public partial class f_main : Form
    {
        public f_main()
        {
            InitializeComponent();
        }

        private void livrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f_livros f = new f_livros();
            f.Show();
        }
    }
}
