using System.Drawing;
using System.Windows.Forms;

namespace LIBRERIA_MELIZA
{
    public class MenuForm : Form
    {
        private readonly Button btnVentas;
        private readonly Button btnIngresarProductos;

        public MenuForm()
        {
            Text = "Menú principal";
            StartPosition = FormStartPosition.CenterParent;
            ClientSize = new Size(420, 230);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            btnVentas = new Button
            {
                Name = "btnVentas",
                Text = "VENTAS",
                Location = new Point(45, 80),
                Size = new Size(145, 70)
            };

            btnIngresarProductos = new Button
            {
                Name = "btnIngresarProductos",
                Text = "INGRESAR PRODUCTOS",
                Location = new Point(225, 80),
                Size = new Size(145, 70)
            };

            Controls.Add(btnVentas);
            Controls.Add(btnIngresarProductos);
        }
    }
}
