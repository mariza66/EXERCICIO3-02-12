using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()

        {
            InitializeComponent();
            mensagem1.Visible = false;
        }

        private void mensagemClicada(object sender, EventArgs e)
        {
            botao1.BackColor = Color.Yellow;
            mensagem1.Visible = false;
        }

        private void botao1_Click(object sender, EventArgs e)
        {
            mensagem1.Visible = true;
            mensagem1.Text = "Agora,clique em mim para alterar a cor do botao1!";

        }
    }
}
    
    

