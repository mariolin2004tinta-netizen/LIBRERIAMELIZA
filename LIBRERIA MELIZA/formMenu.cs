using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIBRERIA_MELIZA
{
    public partial class formMenu : Form
    {
        public formMenu()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (Form1 menu = new Form1())
            {
                menu.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (formlibros menu = new formlibros())
            {
                menu.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (formlectores menu = new formlectores())
            {
                menu.ShowDialog();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (formbibliotecarios menu = new formbibliotecarios())
            {
                menu.ShowDialog();
            }
        }
    }
}
