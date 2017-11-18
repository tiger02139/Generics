using System;
using System.Windows.Forms;

namespace Generics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GenericStaticClass.GreenEggsAndHam();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NonGenericStaticClass.GreenEggsAndHam();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FearsomeGenericMethod.Demo();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NonGenericTypeWithGenericMethod.PrintList();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Lists lists = new Lists();

            lists.PlayWithLinkedList();
        }
    }
}
