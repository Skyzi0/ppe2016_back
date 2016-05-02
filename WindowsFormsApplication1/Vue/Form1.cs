using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Vue;

namespace WindowsFormsApplication1
{
    public partial class FormAccueil : Form
    {
        public FormAccueil()
        {
            InitializeComponent();
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            Form2 x = new Form2();
            x.Show();
            this.Hide();

        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Form3 y = new Form3();
            y.Show();
            this.Hide();
        }

        private void buttonStock_Click(object sender, EventArgs e)
        {
            Form4 z = new Form4();
            z.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
