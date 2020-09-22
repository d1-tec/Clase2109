using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();

            this.Navegar(MenuOptions.MENU_PRINCIPAL);
        }

        public void Navegar(int opcionDelMenu)
        {
            UserControl siguienteUserControl = this.ObtenerSiguienteUserControl(opcionDelMenu);
            this.mainPanel.Controls.Clear();
            this.mainPanel.Controls.Add(siguienteUserControl);
        }

        private UserControl ObtenerSiguienteUserControl(int opcionDelMenu)
        {
            switch (opcionDelMenu)
            {
                case MenuOptions.MENU_PRINCIPAL:
                    return new MenuPrincipalUserControl(this);
                case MenuOptions.AGREGAR_LIBRO:
                    return new AgregarLibroUserControl(this);
                case MenuOptions.VER_LIBROS:
                    return new VerLibrosUserControl(this);
                default:
                    return null;
            }
        }
    }
}
