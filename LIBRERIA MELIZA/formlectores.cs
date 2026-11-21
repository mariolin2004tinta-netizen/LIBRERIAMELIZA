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
    public partial class formlectores : Form
    {
        public formlectores()
        {
            InitializeComponent();
        }

        private void REGRESAR_Click(object sender, EventArgs e)
        {
            using (formMenu menu = new formMenu())
            {
                menu.ShowDialog();
            }
        }
    }
}
