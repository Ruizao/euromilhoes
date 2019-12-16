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

        private int[] sorteia(int qtd, int max)
        {
            List<int> lista = new List<int>();
            Random rnd = new Random();
            for (int i = 0; i < qtd; i++)
            {
                int tmp;
                do tmp = rnd.Next(1, max + 1);
                while (lista.Contains(tmp));
                lista.Add(tmp);
            }
            lista.Sort();
            return lista.ToArray();
        }

        private int nestrelas = 0, nnumero = 0;
        private const string cruz = "X";
        private euromilhões E = new euromilhões();
        private void estrela(object sender, EventArgs e)
        {
            Label tmp = (Label)sender;
            tmp.Text = E.estrela(Convert.ToInt32(tmp.Tag)-1);
            estrella.Text = E.listao;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int[] n = sorteia(5, 50);
            int[] s = sorteia(2, 12);
            n1.Text = n[0].ToString();
            n2.Text = n[1].ToString();
            n3.Text = n[2].ToString();
            n4.Text = n[3].ToString();
            n5.Text = n[4].ToString();
            el1.Text = s[0].ToString();
            el2.Text = s[1].ToString();
        }

        private void N5_Click(object sender, EventArgs e)
        {

        }

        private void numero(object sender, EventArgs e)
        {
            Label tmp = (Label)sender; 
            tmp.Text = E.numero(Convert.ToInt32(tmp.Tag)-1);
            numeroo.Text = E.listanum;
        }
    }
}
