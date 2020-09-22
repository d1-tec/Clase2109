using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class MenuPrincipalUserControl : UserControl
    {
        private MainWindow mainWindow;

        public MenuPrincipalUserControl()
        {
            InitializeComponent();
        }

        public MenuPrincipalUserControl(MainWindow mainWindow)
        {
            InitializeComponent();

            this.mainWindow = mainWindow;
        }

        private void mainButton_Enter(object sender, EventArgs e)
        {
            // this.mainButton.BackColor = Color.Red;
        }

        private void mainButton_MouseHover(object sender, EventArgs e)
        {
            this.buttonQuit.BackColor = Color.Red;
        }

        private void mainButton_MouseClick(object sender, MouseEventArgs e)
        {
            // this.mainWindow.Navegar(MenuOptions.AGREGAR_LIBRO);
        }

        private void mainButton_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddButton_Click(object sender, EventArgs e)
        {
            this.mainWindow.Navegar(MenuOptions.AGREGAR_LIBRO);
        }

        private void buttonViewBooks_Click(object sender, EventArgs e)
        {
            this.mainWindow.Navegar(MenuOptions.VER_LIBROS);
        }
    }
}
