using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace euromilh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private int nestrelas = 0, nnumero = 0;
        private const string cruz = "X";
        private euromilhões E = new euromilhões();
        private void estrela(object sender, EventArgs e)
        {
            Label tmp = (Label)sender;
            tmp.Text = E.estrela(Convert.ToInt32(tmp.Tag)-1);
            teste1.Text = E.listao;
        }

        private void numero(object sender, EventArgs e)
        {
            Label tmp = (Label)sender; 
            tmp.Text = E.numero(Convert.ToInt32(tmp.Tag)-1);
            teste.Text = E.listanum;
        }
    }
}
