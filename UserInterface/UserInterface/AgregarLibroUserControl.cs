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
    public partial class AgregarLibroUserControl : UserControl
    {
        private MainWindow mainWindow;

        public AgregarLibroUserControl()
        {
            InitializeComponent();
        }

        public AgregarLibroUserControl(MainWindow mainWindow)
        {
            InitializeComponent();

            this.mainWindow = mainWindow;
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.mainWindow.Navegar(MenuOptions.MENU_PRINCIPAL);
        }
    }
}
