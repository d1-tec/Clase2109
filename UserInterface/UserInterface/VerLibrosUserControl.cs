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
    public partial class VerLibrosUserControl : UserControl
    {
        private MainWindow mainWindow;

        public VerLibrosUserControl()
        {
            InitializeComponent();
        }

        public VerLibrosUserControl(MainWindow mainWindow)
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
